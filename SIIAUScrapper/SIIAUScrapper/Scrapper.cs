using HtmlAgilityPack;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SIIAUScrapper
{
    class Scrapper
    {
        private bool isBrowserBusy;
        private const string postUrl = @"http://consulta.siiau.udg.mx/wco/sspseca.consulta_oferta";
        private readonly WebBrowser wb;
        private HttpWebRequest req;
        private HttpWebResponse res;
        private string CURRENT_HTML;
        private CookieContainer myContainer;
        private const string userAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36";
        private BackgroundWorker bw;

        public Scrapper(WebBrowser web) {
            bw = new BackgroundWorker();
            bw.WorkerSupportsCancellation = false;
            bw.WorkerReportsProgress = false;
            CURRENT_HTML = "";
            myContainer = new CookieContainer();
            wb = web;
            wb.ScriptErrorsSuppressed = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerAsync();
        }

        private void waitToLoadDocument() {
            isBrowserBusy = true;
            DateTime start = DateTime.Now;
            while (isBrowserBusy && start.AddSeconds(4) > DateTime.Now) {
                Application.DoEvents();
            }
        }

        void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if((sender as WebBrowser).ReadyState == WebBrowserReadyState.Complete)
            {
                isBrowserBusy = false;
                CURRENT_HTML = ((WebBrowser)sender).DocumentText;
            }
        }

        private HtmlNode LoadCurrentPage()
        {
            var html = new HtmlAgilityPack.HtmlDocument();
            html.OptionAutoCloseOnEnd = true;
            html.LoadHtml(CURRENT_HTML);
            var root = html.DocumentNode;
            return root;
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            doGetRequests();
        }

        private void doGetRequests() {
            //req = (HttpWebRequest)WebRequest.Create("http://www."+host);
            //req.Method = "GET";
            //req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            //req.Headers.Add(HttpRequestHeader.AcceptLanguage, "es-ES,es;q=0.8,en;q=0.6,gl;q=0.4");
            //req.UserAgent = userAgent;
            //req.Headers.Add("Upgrade-Insecure-Requests", "1");
            //req.KeepAlive = true;
            //req.CookieContainer = myContainer;
            //req.Host = "www.siiau.udg.mx";
            //res = (HttpWebResponse)req.GetResponse();
            //StreamReader reader = new StreamReader(res.GetResponseStream());
            //CURRENT_HTML = reader.ReadToEnd();

            
            req = (HttpWebRequest)WebRequest.Create(postUrl);
            req.Method = "GET";
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            req.Headers.Add(HttpRequestHeader.AcceptLanguage, "es-ES,es;q=0.8,en;q=0.6,gl;q=0.4");
            req.UserAgent = userAgent;
            //req.Referer = "http://www.siiau.udg.mx/";
            req.Headers.Add("Upgrade-Insecure-Requests", "1");
            req.KeepAlive = true;
            req.CookieContainer = myContainer;
            req.Host = "consulta.siiau.udg.mx";
            res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            CURRENT_HTML = reader.ReadToEnd();
        }

        public void doPostRequest(string data) {
            try
            {
                byte[] postData = Encoding.UTF8.GetBytes(data);
                req = (HttpWebRequest)WebRequest.Create(postUrl);
                req.Method = "POST";
                req.Headers.Add(HttpRequestHeader.CacheControl, "max-age=0");
                req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                req.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
                req.Headers.Add(HttpRequestHeader.AcceptLanguage, "es-ES,es;q=0.8,en;q=0.6,gl;q=0.4");
                req.UserAgent = userAgent;
                req.CookieContainer = new CookieContainer();
                req.CookieContainer = myContainer;
                req.ContentLength = postData.Length;
                req.ContentType = "application/x-www-form-urlencoded";
                req.Referer = postUrl;
                req.Headers.Add("Origin", "http://consulta.siiau.udg.mx");
                req.Headers.Add("Upgrade-Insecure-Requests", "1");
                req.KeepAlive = true;
                req.Host = "consulta.siiau.udg.mx";
                //req.AllowAutoRedirect = false;
                Stream dataStream = req.GetRequestStream();
                dataStream.Write(postData, 0, postData.Length);
                dataStream.Close();
                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                CURRENT_HTML = reader.ReadToEnd();
                reader.Close();
                res.Close();
                wb.DocumentText = CURRENT_HTML;
                waitToLoadDocument();
            }catch(WebException ex)
            {
                res = ex.Response as HttpWebResponse;
                StreamReader reader = new StreamReader(res.GetResponseStream());
                CURRENT_HTML = reader.ReadToEnd();
                reader.Close();
                res.Close();
                wb.DocumentText = CURRENT_HTML;
                waitToLoadDocument();
            }
        }
    }
}
