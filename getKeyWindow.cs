using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApplication3
{
    public partial class getKeyWindow : Form
    {
        public getKeyWindow()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.SetToolTip(this.label1, "Clef API privée. Vous l'aurez dans Settings -> Account");

            textBox1.Text = ConfigurationManager.AppSettings["api"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings["api"] = textBox1.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
