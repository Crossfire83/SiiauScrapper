using System.Windows.Forms;

namespace SIIAUScrapper
{
    public partial class Form1 : Form
    {
        Scrapper scrapper;

        public Form1()
        {
            InitializeComponent();
            ((Control)webBrowser1).Enabled = false;
            scrapper = new Scrapper(webBrowser1);
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {

            tabControl1.SelectedTab = BrowserTab;
        }
    }
}
