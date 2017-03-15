using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIIAUScrapper
{
    class Scrapper
    {
        private const string host = @"siiau.udg.mx/";
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

        }


        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            doGetRequests();
        }

        private void doGetRequests() {
            req = (HttpWebRequest)WebRequest.Create("http://www."+host);
            req.Method = "GET";
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            req.Headers.Add(HttpRequestHeader.AcceptLanguage, "es-ES,es;q=0.8,en;q=0.6,gl;q=0.4");
            req.UserAgent = userAgent;
            req.Headers.Add("Upgrade-Insecure-Requests", "1");
            req.KeepAlive = true;
            req.CookieContainer = myContainer;
            req.Host = "www.siiau.udg.mx";
            res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            CURRENT_HTML = reader.ReadToEnd();

            
            req = (HttpWebRequest)WebRequest.Create("http://consulta." + host + "wco/sspseca.forma_consulta");
            req.Method = "GET";
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            req.Headers.Add(HttpRequestHeader.AcceptLanguage, "es-ES,es;q=0.8,en;q=0.6,gl;q=0.4");
            req.UserAgent = userAgent;
            req.Referer = "http://www.siiau.udg.mx/";
            req.Headers.Add("Upgrade-Insecure-Requests", "1");
            req.KeepAlive = true;
            req.CookieContainer = myContainer;
            req.Host = "consulta.siiau.udg.mx";
            res = (HttpWebResponse)req.GetResponse();
            reader = new StreamReader(res.GetResponseStream());
            CURRENT_HTML = reader.ReadToEnd();
        }

    }
}
