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
using System.Data.Sql;

namespace CaraCarBeyler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("SERVER=LAPTOP-PDQV3R54\\SQLEXPRESS; Database=RentACar;  Integrated Security=True;");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        SqlDataReader dr;

        


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult cikalim = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cikalim == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text == "" || txtsifre.Text == "")
            {
                MessageBox.Show("Lütfen ilgili alanları doldurunuz..", "Bilgilendirme penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "select * from kullanici where KullaniciAdi ='" + txtkullaniciadi.Text + "' and Sifre='" + txtsifre.Text + "'";
                baglanti.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    anamenu ana = new anamenu();
                    this.Hide();
                    ana.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Yanlış kullanıcı adı veya şifre girdiniz", "Bilgilendirme penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtkullaniciadi.Text = "";
                    txtsifre.Text = "";
                    txtkullaniciadi.Focus();
                }
                baglanti.Close();
                dr.Close();
            }
        }

        private void sifrekurtarmakadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void soru_TextChanged(object sender, EventArgs e)
        {

        }

        private void cevabi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            panel1.Visible = false;
            label9.Visible = false;
            sifreyeni.Visible = false;
            sifreonay.Visible = false;

            Random rastgele = new Random();
            string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZabcçdefgğhıijklmnoöprsştuüvyz";
            string uret = "";
            for (int i = 0; i < 6; i++)
            {
                uret += harfler[rastgele.Next(harfler.Length)];
            }
            soru.Text = uret;
            
           

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
        }

        private void soruonay_Click(object sender, EventArgs e)
        {
            if (sifrekurtarmakadi.Text == "" || cevabi.Text == "")
            {
                MessageBox.Show("Lütfen ilgili alanları doldurunuz.");
            }
            else
            {
                if (cevabi.Text == soru.Text)
                 {
                    label9.Visible = true;
                    sifreyeni.Visible = true;
                    sifreonay.Visible = true;
                  }
                 else
                 {
                     MessageBox.Show("Yanlış bir şeyler var...");
                 }
                
            }
        }


        void temizle()
        {
            sifrekurtarmakadi.Text = "";
            sifreonay.Text = "";
            soru.Text = "";
            cevabi.Text = "";
        }

        private void sifreonay_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select id From Kullanici Where KullaniciAdi= '"+sifrekurtarmakadi.Text+"'";
            
            SqlDataReader oku = komut.ExecuteReader();
            if(oku.Read())
            {
                oku.Close();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "UPDATE Kullanici SET KullaniciAdi=@KullaniciAdi, Sifre=@Sifre WHERE KullaniciAdi = '" + sifrekurtarmakadi.Text + "'";
                cmd.Parameters.AddWithValue("KullaniciAdi", sifrekurtarmakadi.Text);
                cmd.Parameters.AddWithValue("@Sifre", sifreyeni.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Şifreniz güncellenmiştir ama siz yine de lütfen bir daha unutmayınız..");
                baglanti.Close();
                temizle();
                panel1.Visible = false;
                
               
            }
            else{
                
                MessageBox.Show("Böyle Bir Kullanıcı Bulunamadı");
                
                oku.Close();
                sifrekurtarmakadi.Text = "";
                sifreyeni.Text = "";
                cevabi.Text = "";
                label9.Visible = false;
                sifreyeni.Visible = false;
                sifreonay.Visible = false;
                  }
            }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
