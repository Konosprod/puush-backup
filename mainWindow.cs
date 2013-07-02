using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Collections.Specialized;
using System.Configuration;

namespace WindowsFormsApplication3
{

    public partial class mainWindow : Form
    {
        String key = "";
        String path = "";
        public mainWindow()
        {
            InitializeComponent();
            if ((key = ConfigurationManager.AppSettings["api"]) == "")
            {
                getKeyWindow gkw = new getKeyWindow();
                gkw.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backupPublic(string urlbase)
        {
            Directory.CreateDirectory(path + "/Public/");
            if (textBox1.Text != "")
            {
                WebClientEx wb = new WebClientEx();
                String src = "";
                String pages = "";
                Regex nbPages = new Regex("@?page=[0-9]*\">[0-9]*</a><a class=\"noborder\"");
                Regex nom = new Regex("_blank\" title=\".*\"");
                Regex urls = new Regex("\\('[A-Za-z0-9]*'\\)\"");
                src = wb.DownloadString("http://puush.me/login/go/?k=" + key);
                src = wb.DownloadString("http://puush.me" + urlbase);

                if (nbPages.IsMatch(src))
                {
                    pages = nbPages.Match(src).ToString();
                    pages = pages.Remove(pages.LastIndexOf('>'));
                    pages = pages.Remove(pages.LastIndexOf('<'));
                    pages = pages.Substring(pages.IndexOf('>') + 1);
                }
                else
                {
                    pages = "1";
                }

                for (int i = 0; i < int.Parse(pages); i++)
                {
                    src = wb.DownloadString("http://puush.me/"+ urlbase + "&page=" + (i + 1));
                    for (int j = 0; j < urls.Matches(src).Count; j++)
                    {
                        String name = nom.Matches(src)[j].ToString();
                        String url = urls.Matches(src)[j].ToString();
                        name = name.Remove(0, 15);
                        name = name.Remove(name.LastIndexOf('(') - 1);
                        url = url.Remove(0, 2);
                        url = url.Remove(url.Length - 3);

                        wb.DownloadFile("http://puu.sh/" + url, path + "/Public/" + name);
                    }
                }
            }
        }

        private void backupPrivate(string urlbase)
        {
            if (textBox1.Text != "")
            {
                Directory.CreateDirectory(path + "/Private/");
                WebClientEx wb = new WebClientEx();
                String src = "";
                String pages = "";
                Regex nbPages = new Regex("@?page=[0-9]*\">[0-9]*</a><a class=\"noborder\"");
                Regex nom = new Regex("_blank\" title=\".*\"");
                Regex urls = new Regex("\\('[A-Za-z0-9]*'\\)\"");
                src = wb.DownloadString("http://puush.me/login/go/?k=" + key);
                src = wb.DownloadString("http://puush.me" + urlbase);

                if (nbPages.IsMatch(src))
                {
                    pages = nbPages.Match(src).ToString();
                    pages = pages.Remove(pages.LastIndexOf('>'));
                    pages = pages.Remove(pages.LastIndexOf('<'));
                    pages = pages.Substring(pages.IndexOf('>') + 1);
                }
                else
                {
                    pages = "1";
                }

                for (int i = 0; i < int.Parse(pages); i++)
                {
                    src = wb.DownloadString("http://puush.me/" + urlbase + "&page=" + (i + 1));
                    for (int j = 0; j < urls.Matches(src).Count; j++)
                    {
                        String name = nom.Matches(src)[j].ToString();
                        String url = urls.Matches(src)[j].ToString();
                        name = name.Remove(0, 15);
                        name = name.Remove(name.LastIndexOf('(') - 1);
                        url = url.Remove(0, 2);
                        url = url.Remove(url.Length - 3);

                        wb.DownloadFile("http://puush.me/account/view/" + url, path + "/Private/" + name);
                    }
                }
            }
        }

        private void backupGallery(string urlbase)
        {
            if (textBox1.Text != "")
            {
                Directory.CreateDirectory(path + "/Gallery/");
                WebClientEx wb = new WebClientEx();
                String src = "";
                String pages = "";
                Regex nbPages = new Regex("@?page=[0-9]*\">[0-9]*</a><a class=\"noborder\"");
                Regex nom = new Regex("_blank\" title=\".*\"");
                Regex urls = new Regex("\\('[A-Za-z0-9]*'\\)\"");
                src = wb.DownloadString("http://puush.me/login/go/?k=" + key);
                src = wb.DownloadString("http://puush.me" + urlbase);

                if (nbPages.IsMatch(src))
                {
                    pages = nbPages.Match(src).ToString();
                    pages = pages.Remove(pages.LastIndexOf('>'));
                    pages = pages.Remove(pages.LastIndexOf('<'));
                    pages = pages.Substring(pages.IndexOf('>') + 1);
                }
                else
                {
                    pages = "1";
                }

                for (int i = 0; i < int.Parse(pages); i++)
                {
                    src = wb.DownloadString("http://puush.me/" + urlbase + "&page=" + (i + 1));
                    for (int j = 0; j < urls.Matches(src).Count; j++)
                    {
                        String name = nom.Matches(src)[j].ToString();
                        String url = urls.Matches(src)[j].ToString();
                        name = name.Remove(0, 15);
                        name = name.Remove(name.LastIndexOf('(') - 1);
                        url = url.Remove(0, 2);
                        url = url.Remove(url.Length - 3);

                        wb.DownloadFile("http://puu.sh/" + url, path + "/Gallery/" + name);
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClientEx wb = new WebClientEx();
            Regex r = new Regex(@"/account/\?pool=[0-9]*");
            String src = wb.DownloadString("http://puush.me/login/go/?k=" + key);

            if (checkBoxPublic.Checked)
            {
                backupPublic(r.Matches(src)[0].ToString());
            }
            if (checkBoxPrivate.Checked)
            {
                backupPrivate(r.Matches(src)[1].ToString());
            }
            if (checkBoxGallery.Checked)
            {
                backupGallery(r.Matches(src)[2].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void editerLaClefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getKeyWindow gkw = new getKeyWindow();
            if (gkw.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String newKey = ConfigurationManager.AppSettings["api"];
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove("api");
                config.AppSettings.Settings.Add("api", newKey);
                config.Save();
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            if (folderBrowserDialog1.SelectedPath != "")
            {
                this.textBox1.Text = folderBrowserDialog1.SelectedPath;
                path = this.textBox1.Text;
            }
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}


public class WebClientEx : WebClient
{
    public CookieContainer CookieContainer { get; private set; }

    public WebClientEx()
    {
        CookieContainer = new CookieContainer();
    }

    protected override WebRequest GetWebRequest(Uri address)
    {
        var request = base.GetWebRequest(address);
        if (request is HttpWebRequest)
        {
            (request as HttpWebRequest).CookieContainer = CookieContainer;
        }
        return request;
    }
}