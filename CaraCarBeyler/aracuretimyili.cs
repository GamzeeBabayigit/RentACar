﻿using System;
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
    public partial class aracuretimyili : Form
    {
        public aracuretimyili()
        {
            InitializeComponent();
        }

        SqlDataReader okuyucubey;
        SqlConnection baglanti = new SqlConnection("SERVER=LAPTOP-PDQV3R54\\SQLEXPRESS; Database=RentACar;  Integrated Security=True;");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();

        void doldur()
        {
            comboBox1.Items.Clear();
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT UretimYili FROM UretimYili ORDER BY UretimYili ASC", baglanti);
            sorgu.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sorgu);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["UretimYili"].ToString());
            }
            baglanti.Close();
        }
        private void aracuretimyili_Load(object sender, EventArgs e)
        {
            doldur();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Lütfen Bir Değer Giriniz..");
            }
            else
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "SELECT ID FROM UretimYili WHERE UretimYili = '" + comboBox1.Text + "'";
                okuyucubey = cmd.ExecuteReader();
                if (okuyucubey.Read())
                {
                    MessageBox.Show("Bu Araç Üretim Yılından Bulunmaktadır");
                    okuyucubey.Close();
                }
                    
                else
                {
                    okuyucubey.Close();
                    SqlCommand ekle = new SqlCommand();
                    ekle.Connection = baglanti;
                    ekle.CommandText = "INSERT INTO UretimYili(UretimYili)VALUES(@UretimYili)";
                    ekle.Parameters.AddWithValue("@UretimYili", comboBox1.Text);
                    ekle.ExecuteNonQuery();
                    DialogResult cevap = MessageBox.Show("Ekleme işlemi başarılı. Kayıt Yapmaya Devam Etmek İster Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (cevap == DialogResult.No)
                    {
                        ayarlar ayar = new ayarlar();
                        this.Hide();
                        ayar.Show();
                    }
                    

                    baglanti.Close();
                    doldur();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "DELETE FROM UretimYili WHERE UretimYili = '" + comboBox1.SelectedItem + "'";
            komut.ExecuteNonQuery();
            komut.Dispose();
            DialogResult cevap = MessageBox.Show("Silme işlemi başarılı. Kayıt Yapmaya Devam Etmek İster Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.No)
            {
                ayarlar ayar = new ayarlar();
                this.Hide();
                ayar.Show();
            }
            
            baglanti.Close();
            doldur();
        }

        private void aracuretimyili_FormClosing(object sender, FormClosingEventArgs e)
        {
            ayarlar ayar = new ayarlar();
            this.Hide();
            ayar.Show();
        }
    }
}
