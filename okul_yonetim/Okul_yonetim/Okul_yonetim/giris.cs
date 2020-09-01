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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }
        private void giris_Load(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == Properties.Settings.Default.pass && textBox1.Text == Properties.Settings.Default.user)
            {
                this.Visible = false;
            }
            else if (textBox2.Text != Properties.Settings.Default.pass && textBox1.Text != Properties.Settings.Default.user)

            {
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                MessageBox.Show("şifre ve adı yalnış ");
            }
            else if (textBox2.Text != Properties.Settings.Default.pass && textBox1.Text == Properties.Settings.Default.user)
            {
                textBox2.Clear();
                MessageBox.Show("şifre yalniş");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }
    }
}
