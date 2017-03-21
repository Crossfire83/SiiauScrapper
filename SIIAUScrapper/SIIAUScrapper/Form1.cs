using System.Text;
using System.Web;
using System.Windows.Forms;

namespace SIIAUScrapper
{
    public partial class Form1 : Form
    {
        Scrapper scrapper;

        public Form1()
        {
            InitializeComponent();
            //((Control)webBrowser1).Enabled = false;
            webBrowser1.AllowNavigation = false;

            scrapper = new Scrapper(webBrowser1);
            CentroCb.SelectedIndex = 3;
            CarreraCb.SelectedIndex = 33;
            orderTypeCb.SelectedIndex = 0;
            ShowRegistersCb.SelectedIndex = 0;
            //((Control)BrowserTab).Enabled = false;
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            Button senderbtn = sender as Button;
            senderbtn.Enabled = false;
            string postParams = "";
            postParams += "ciclop=" + CicloTb.Text;
            string centro = CentroCb.GetItemText(CentroCb.SelectedItem);
            postParams += "&cup=" + centro.Split('-')[0].Trim();
            string carrera = CarreraCb.GetItemText(CarreraCb.SelectedItem);
            postParams += "&majrp=" + carrera.Split('-')[0].Trim();
            postParams += "&crsep=";
            if (ClaveTb.Text != "")
                postParams += ClaveTb.Text;
            postParams += "&materiap=";
            if (MateriaTb.Text != "")
                postParams += HttpUtility.UrlEncode(MateriaTb.Text);
            postParams += "&horaip=";
            if (HoraInicioTb.Text != "")
                postParams += HoraInicioTb.Text;
            postParams += "&horafp=";
            if (HoraFinTb.Text != "")
                postParams += HoraFinTb.Text;
            if (LunesChB.Checked)
            {
                postParams += "&lup=M";
            }
            if (MartesChB.Checked)
            {
                postParams += "&map=T";
            }
            if (MiercolesChB.Checked)
            {
                postParams += "&mip=W";
            }
            if (JuevesChB.Checked)
            {
                postParams += "&jup=R";
            }
            if (ViernesChB.Checked)
            {
                postParams += "&vip=F";
            }
            if (SabadoChB.Checked)
            {
                postParams += "&sap=S";
            }
            postParams += "&edifp=";
            if (EdificioTb.Text != "")
                postParams += EdificioTb.Text;
            postParams += "&aulap=";
            if (AulaTb.Text != "")
                postParams += AulaTb.Text;
            postParams += "&dispp=D";
            postParams += "&ordenp=" + orderTypeCb.SelectedIndex.ToString();
            string show = ShowRegistersCb.GetItemText(ShowRegistersCb.SelectedItem);
            postParams += "&mostrarp=" + show.Split(' ')[0];
            scrapper.doPostRequest(postParams);

            tabControl1.SelectedTab = BrowserTab;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(e.TabPage == FormTab)
            {
                SearchButton.Enabled = true;
                this.MaximumSize = new System.Drawing.Size(593, 495);
            }else
            {
                this.MinimumSize = new System.Drawing.Size(1119, 495);
            }
        }
    }
}
