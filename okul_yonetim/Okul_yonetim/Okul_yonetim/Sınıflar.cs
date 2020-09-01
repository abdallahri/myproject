using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul_yonetim
{
    public partial class Sınıflar : Form
    {
        public Sınıflar()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            S9 l = new S9();
            l.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            S10 l = new S10();
            l.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            S11 l = new S11();
            l.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            S12 l = new S12();
            l.ShowDialog();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString()+ "  " + DateTime.Now.ToLongTimeString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Sınıflar_Load(object sender, EventArgs e)
        {

        }
    }
}
