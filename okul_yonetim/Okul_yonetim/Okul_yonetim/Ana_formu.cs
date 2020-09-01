using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul_yonetim
{
    public partial class Ana_form : Form
    {
        public Ana_form()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Sınıflar l = new Sınıflar();
            l.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            ogretmenler l = new ogretmenler();
            l.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.pass !="" && Properties.Settings.Default.user!="")
            {
                Giris l = new Giris();
                l.ShowDialog();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }
    }
}
