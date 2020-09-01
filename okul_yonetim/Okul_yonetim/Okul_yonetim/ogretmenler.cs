using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Okul_yonetim
{
  public partial class ogretmenler : Form
    {
        public SqlConnection baglantı = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf");

        public SqlCommand komut = new SqlCommand();
        public SqlDataAdapter adaptor = new SqlDataAdapter();
        public DataTable TB = new DataTable();
        public DataSet ds = new DataSet();
        public void hocalar()
        {
            TB.Clear();
            komut.Parameters.Clear();
            baglantı.Open();
            adaptor = new SqlDataAdapter("select * from Hocalar", baglantı);

            adaptor.Fill(TB);
            dataGridView1.DataSource = TB;
            adaptor.Dispose();
            baglantı.Close();
        }
        public ogretmenler()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }
        private void ogretmenler_Load(object sender, EventArgs e)
        {

            hocalar();
            label2.Visible = false;
                label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            txt_H_unvan.Visible = false;
            txt_H_soyadı.Visible = false;
            txt_H_numrası.Visible = false;
            txt_H_Adı.Visible = false;
         }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                    baglantı.Open();
                komut.Connection = baglantı;
                komut.CommandText = "INSERT into Hocalar(Ad,Soyad,unvan)values('" + txt_H_Adı.Text + "','" + txt_H_soyadı.Text + "','" +txt_H_unvan.Text + "')";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglantı.Close();
                MessageBox.Show("Kayıt eklendi..");

                dataGridView1.Refresh();
                hocalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            txt_H_unvan.Visible = true;
            txt_H_soyadı.Visible = true;
            txt_H_numrası.Enabled = false;
            txt_H_Adı.Visible = true;
            txt_H_numrası.Visible = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = true;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_H_numrası.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            txt_H_unvan.Visible = true;
            txt_H_soyadı.Visible = true;
            txt_H_numrası.Enabled = true;
            txt_H_Adı.Visible = true;
            button2.Enabled = true;
            button1.Enabled = false;
            button3.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                komut.Connection = baglantı;
                komut.CommandText = "UPDATE Hocalar set Ad='" + txt_H_Adı.Text + "'," + "Soyad='" + txt_H_soyadı.Text + "' ," + "unvan='" + txt_H_unvan.Text + "'  where HocaNo='" + txt_H_numrası.Text + "'";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglantı.Close();
                MessageBox.Show(txt_H_numrası.Text + " Numaralı öğrencinin bilgileri güncellendi..");
                hocalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show(txt_H_numrası.Text + " numaralı Hocayı silinecek?", "DİKKAT",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    baglantı.Open();
                    komut.Connection = baglantı;
                    komut.CommandText = "Delete from Hocalar where HocaNo=" + txt_H_numrası.Text + "";
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglantı.Close();
                    MessageBox.Show("Kayıt Silindi..");
                    hocalar();
                }
                else if (cevap == DialogResult.No)
                {
                    komut.Dispose();
                    baglantı.Close();
                    MessageBox.Show(txt_H_numrası.Text + " numaralı Hocayı silmekten vazgeçti");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txt_H_numrası.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible =    false;
            txt_H_unvan.Visible = false;
            txt_H_soyadı.Visible = false;
            txt_H_numrası.Enabled = true;
            txt_H_Adı.Visible = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button1.Enabled = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
