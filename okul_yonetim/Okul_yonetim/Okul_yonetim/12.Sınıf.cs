using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Okul_yonetim
{
    public partial class S12 : Form
    {
        public S12()
        {
            InitializeComponent();
        }
        public SqlConnection baglantı = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf");

        public SqlCommand komut = new SqlCommand();
        public SqlDataAdapter adaptor = new SqlDataAdapter();
        public DataTable TB = new DataTable();
        public DataSet ds = new DataSet();


        public SqlCommand Nkomut = new SqlCommand();
        public SqlDataAdapter Nadaptor = new SqlDataAdapter();
        public DataTable NTB = new DataTable();
        public DataSet Nds = new DataSet();


        public SqlCommand Dkomut = new SqlCommand();
        public SqlDataAdapter Dadaptor = new SqlDataAdapter();
        public DataTable DTB = new DataTable();
        public DataSet Dds = new DataSet();
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }

        private void S12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet11.Hocalar' table. You can move, or remove it, as needed.
            this.hocalarTableAdapter.Fill(this.database1DataSet11.Hocalar);
            // TODO: This line of code loads data into the 'database1DataSet10.Dersler_12' table. You can move, or remove it, as needed.
            this.dersler_12TableAdapter.Fill(this.database1DataSet10.Dersler_12);
            // TODO: This line of code loads data into the 'database1DataSet9.Ogrenciler_12' table. You can move, or remove it, as needed.
            this.ogrenciler_12TableAdapter.Fill(this.database1DataSet9.Ogrenciler_12);
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button5.Visible = false;



            txt_1dönem.Visible = false;
            txt_2dönem.Visible = false;
            txt_notlar_DersKodu.Visible = false;
            txt_dersyılı.Visible = false;
            txt_Notlar_ogrNumrasi.Visible = false;
            button6.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label19.Visible = false;
            label10.Visible = false;




            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            txt_Osoyadı.Visible = false;
            txt_OAdres1.Visible = false;
            txt_Oadı.Visible = false;
            txt_ODTarıhı1.Visible = false;
            txt_OAdres1.Visible = false;
            txt_DOYEri1.Visible = false;
            txt_OgrNo.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            lable5.Visible = false;
            lable6.Visible = false;
            lable7.Visible = false;
            label2.Visible = false;



            button7.Visible = false;
            button8.Visible = false;
            button5.Visible = false;
            txt_dersadı.Visible = false;
            txt_ders_hoca.Visible = false;
            txt_Teorik.Visible = false;
            txt_uygulama.Visible = false;
            txt_icerk.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label11.Visible = false;
            txt_derskodu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Nlistele()
        {
            NTB.Clear();
            Nkomut.Parameters.Clear();
            baglantı.Open();
            Nadaptor = new SqlDataAdapter("select * from Notlar_12", baglantı);

            Nadaptor.Fill(NTB);
            dataGridView1.DataSource = NTB;
            Nadaptor.Dispose();
            baglantı.Close();

        }
        public void Dlistele()
        {
            DTB.Clear();
            Dkomut.Parameters.Clear();
            baglantı.Open();
            Dadaptor = new SqlDataAdapter("select * from Dersler_12", baglantı);

            Dadaptor.Fill(DTB);
            dataGridView1.DataSource = DTB;
            Dadaptor.Dispose();
            baglantı.Close();

        }
        public void Olistele()
        {
            TB.Clear();
            komut.Parameters.Clear();
            baglantı.Open();
            adaptor = new SqlDataAdapter("select * from Ogrenciler_12", baglantı);

            adaptor.Fill(TB);
            dataGridView1.DataSource = TB;
            adaptor.Dispose();
            baglantı.Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Green;
            dataGridView1.BackgroundColor = Color.Green;
            dataGridView1.Refresh();
            Nlistele();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Green;
            dataGridView1.BackgroundColor = Color.Green;
            dataGridView1.Refresh();
            Olistele();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Blue;
            dataGridView1.BackgroundColor = Color.Blue;
            dataGridView1.Refresh();
            Dlistele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (lable7.Text == "" || txt_Oadı.Text == "" || txt_OAdres1.Text == "" || txt_OgrNo.Text == "" || txt_Osoyadı.Text == "")
                {
                    MessageBox.Show("Girilen bilgileri kontrol edin");
                    return;

                }

                else

                    baglantı.Open();
                komut.Connection = baglantı;
                komut.CommandText = "INSERT into Ogrenciler_12(OgrNo,Adı,Soyadı,Dtarihi,dyeri,Adres)values('" + txt_OgrNo.Text + "','" + txt_Oadı.Text + "','" + txt_Osoyadı.Text + "','" + txt_ODTarıhı1.Value.ToString() + "','" + txt_DOYEri1.Text + "','" + txt_OAdres1.Text + "')";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglantı.Close();
                MessageBox.Show("Kayıt eklendi..");

                dataGridView1.Refresh();
                Olistele();
                txt_DOYEri1.Text = "";
                txt_OAdres1.Text = "";
                txt_Oadı.Text = "";
                lable5.Text = "";
                txt_OgrNo.Text = "";
                txt_Osoyadı.Text = "";
                txt_OgrNo.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txt_OgrNo.Visible = true;
            label2.Visible = true;
            button2.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            txt_Osoyadı.Visible = true;
            txt_OAdres1.Visible = true;
            txt_Oadı.Visible = true;
            txt_ODTarıhı1.Visible = true;
            txt_OAdres1.Visible = true;
            txt_DOYEri1.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            lable5.Visible = true;
            lable6.Visible = true;
            lable7.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                komut.Connection = baglantı;
                komut.CommandText = "UPDATE Ogrenciler_12 set Adı='" + txt_Oadı.Text + "'," + "Soyadı='" + txt_Osoyadı.Text + "' ," + "Dtarihi='" + txt_ODTarıhı1.Value.ToString() + "' ," + "dyeri='" + txt_DOYEri1.Text + "'," + "Adres='" + txt_OAdres1.Text + "' where OgrNo='" + txt_OgrNo.Text + "'";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglantı.Close();
                MessageBox.Show(txt_OgrNo.Text + " Numaralı öğrencinin bilgileri güncellendi..");
                Olistele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            txt_OgrNo.Visible = true;
            label2.Visible = true;
            groupBox2.Visible = true;
            button2.Visible = false;
            button3.Visible = true;
            button4.Visible = false;
            txt_Osoyadı.Visible = true;
            txt_OAdres1.Visible = true;
            txt_Oadı.Visible = true;
            txt_ODTarıhı1.Visible = true;
            txt_OAdres1.Visible = true;
            txt_DOYEri1.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            lable5.Visible = true;
            lable6.Visible = true;
            lable7.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show(txt_OgrNo.Text + " numaralı öğrenci silinecek?", "DİKKAT",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    baglantı.Open();
                    komut.Connection = baglantı;
                    komut.CommandText = "Delete from Ogrenciler_12 where OgrNo=" + txt_OgrNo.Text + "";
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglantı.Close();
                    MessageBox.Show("Kayıt Silindi..");
                    Olistele();
                }
                else if (cevap == DialogResult.No)
                {
                    komut.Dispose();
                    baglantı.Close();
                    MessageBox.Show(txt_OgrNo.Text + " numaralı öğrenciyi silmekten vazgeçti");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            txt_Osoyadı.Visible = false;
            txt_OAdres1.Visible = false;
            txt_Oadı.Visible = false;
            txt_ODTarıhı1.Visible = false;
            txt_OAdres1.Visible = false;
            txt_DOYEri1.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            lable5.Visible = false;
            lable6.Visible = false;
            lable7.Visible = false;
            txt_OgrNo.Visible = true;
            label2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                komut.Connection = baglantı;
                komut.CommandText = "INSERT into Dersler_12(Derskodu,DersAdı,teorik,Uygulama,icerik,Hoca)values('" + txt_derskodu.Text + "','" + txt_dersadı.Text + "','" + txt_Teorik.Text + "','" + txt_uygulama.Text + "','" + txt_icerk.Text + "','" + txt_ders_hoca.SelectedValue + "')";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglantı.Close();
                MessageBox.Show("Kayıt eklendi..");

                dataGridView1.Refresh();
                Dlistele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                komut.Connection = baglantı;
                komut.CommandText = "UPDATE Dersler_12 set DersAdı='" + txt_dersadı.Text + "'," + "teorik='" + txt_Teorik.Text + "' ," + "Uygulama='" + txt_uygulama.Text + "' ," + "icerik='" + txt_icerk.Text + "'," + "Hoca='" + txt_ders_hoca.SelectedValue + "' where Derskodu='" + txt_derskodu.Text + "'";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglantı.Close();
                MessageBox.Show(txt_derskodu.Text + " Numaralı Ders Kodu bilgileri güncellendi..");
                Dlistele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show(txt_derskodu.Text + " numaralı ders kodu silinecek?", "DİKKAT",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    baglantı.Open();
                    komut.Connection = baglantı;
                    komut.CommandText = "Delete from Dersler_12 where Derskodu=" + txt_derskodu.Text + "";
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglantı.Close();
                    MessageBox.Show("Kayıt Silindi..");
                    Dlistele();

                }
                else if (cevap == DialogResult.No)
                {
                    komut.Dispose();
                    baglantı.Close();
                    MessageBox.Show(txt_derskodu.Text + " numaralı ders kodu silmekten vazgeçti");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int s1 = int.Parse(txt_1dönem.Text);
                int s2 = int.Parse(txt_2dönem.Text);
                int s3 = (s1 + s2) / 2;
                label19.Text = "Yıl Sonu Notu = " + s3.ToString();

                baglantı.Open();
                komut.Connection = baglantı;
                komut.CommandText = "INSERT into Notlar_12(OgrNo,Derskodu,Dersyılı,[1.Dönem Notu],[2.Dönem Notu] , [Yil Sonu Notu])values('" + txt_Notlar_ogrNumrasi.SelectedValue + "','" + txt_notlar_DersKodu.SelectedValue + "','" + txt_dersyılı.Value.ToString() + "','" + txt_1dönem.Text + "','" + txt_2dönem.Text + "','" + s3.ToString() + "')";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglantı.Close();
                MessageBox.Show("Kayıt eklendi..");
                Nlistele();
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            button7.Visible = false;
            button8.Visible = false;
            button5.Visible = true;
            txt_dersadı.Visible = true;
            txt_ders_hoca.Visible = true;
            txt_Teorik.Visible = true;
            txt_uygulama.Visible = true;
            txt_icerk.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label11.Visible = true;
            txt_derskodu.Visible = true;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

            button7.Visible = true;
            button8.Visible = false;
            button5.Visible = false;
            txt_dersadı.Visible = true;
            txt_ders_hoca.Visible = true;
            txt_Teorik.Visible = true;
            txt_uygulama.Visible = true;
            txt_icerk.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label11.Visible = true;
            txt_derskodu.Visible = true;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            button7.Visible = false;
            button8.Visible = true;
            button5.Visible = false;
            txt_dersadı.Visible = false;
            txt_ders_hoca.Visible = false;
            txt_Teorik.Visible = false;
            txt_uygulama.Visible = false;
            txt_icerk.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label11.Visible = true;
            txt_derskodu.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                int s1 = int.Parse(txt_1dönem.Text);
                int s2 = int.Parse(txt_2dönem.Text);
                int s3 = (s1 + s2) / 2;
                label19.Text = "Yıl Sonu Notu = " + s3.ToString();
                baglantı.Open();
                komut.Connection = baglantı;
                komut.CommandText = "UPDATE Notlar_12 set Derskodu='" + txt_notlar_DersKodu.SelectedValue + "'," + "Dersyılı='" + txt_dersyılı.Value.ToString() + "' ," + "[1.Dönem Notu]='" + txt_1dönem.Text + "' ," + "[2.Dönem Notu]='" + txt_2dönem.Text + "'," + " [Yil Sonu Notu]='" + s3.ToString() + "' where OgrNo='" + txt_Notlar_ogrNumrasi.SelectedValue + "'";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglantı.Close();
                MessageBox.Show(txt_Notlar_ogrNumrasi.SelectedValue + " Numaralı öğrencinin Notlari güncellendi..");
                Nlistele();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show(txt_Notlar_ogrNumrasi.SelectedValue + " numaralı öğrenci Notları silinecek?", "DİKKAT",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    baglantı.Open();
                    komut.Connection = baglantı;
                    komut.CommandText = "Delete from Notlar_12 where OgrNo=" + txt_Notlar_ogrNumrasi.SelectedValue + "";
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglantı.Close();
                    MessageBox.Show("Kayıt Silindi..");
                    Nlistele();
                }
                else if (cevap == DialogResult.No)
                {
                    komut.Dispose();
                    baglantı.Close();
                    MessageBox.Show(txt_OgrNo.Text + " numaralı öğrenciyi Notları silmekten vazgeçti");
                    return;
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label10.Visible = true;
            txt_Notlar_ogrNumrasi.Visible = true;
            txt_1dönem.Visible = true;
            txt_2dönem.Visible = true;
            txt_notlar_DersKodu.Visible = true;
            txt_dersyılı.Visible = true;
            button6.Visible = true;
            button9.Visible = false;
            button10.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            label19.Visible = true;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            label10.Visible = true;
            txt_Notlar_ogrNumrasi.Visible = true;
          
            txt_1dönem.Visible = true;
            txt_2dönem.Visible = true;
            txt_notlar_DersKodu.Visible = true;
            txt_dersyılı.Visible = true;
            button6.Visible = false;
            button9.Visible = true;
            button10.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            label19.Visible = true;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            txt_1dönem.Visible = false;
            txt_2dönem.Visible = false;
            txt_notlar_DersKodu.Visible = false;
            txt_dersyılı.Visible = false;
            button6.Visible = false;
            button9.Visible = false;
            button10.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label19.Visible = false;
            label10.Visible = true;
            txt_Notlar_ogrNumrasi.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
