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
    public partial class markaekle : Form
    {
        public markaekle()
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
            SqlCommand sorgu = new SqlCommand("SELECT DISTINCT AracMarka FROM AracMarka", baglanti);
            sorgu.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sorgu);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["AracMarka"].ToString());
            }
            baglanti.Close();
            
        }
        private void markaekle_Load(object sender, EventArgs e)
        {

            doldur();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "" && comboBox1.Text == "")
            {
                MessageBox.Show("Lütfen ilgili alanları doldurunuz..");
            }

            else
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
               SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;

                cmd.CommandText = "SELECT ID FROM AracMarka WHERE AracMarka='" + comboBox1.Text + "' and AracModel ='"+comboBox2.Text+"'" ;
                okuyucubey = cmd.ExecuteReader();
                if (okuyucubey.Read())
                {
                    MessageBox.Show("Bu Marka ve Modelden Bulunmaktadır..");
                    okuyucubey.Close();
                }

                else
                {

                    okuyucubey.Close(); 
                    SqlCommand ekle = new SqlCommand();
                    ekle.Connection = baglanti;
                    ekle.CommandText = "INSERT INTO AracMarka(AracMarka,AracModel)VALUES(@AracMarka,@AracModel)";
                    ekle.Parameters.AddWithValue("@AracMarka", comboBox1.Text);
                    ekle.Parameters.AddWithValue("@AracModel", comboBox2.Text);
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

        private void button2_Click(object sender, EventArgs e) //MARKA VE MODEL SİLME
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "DELETE FROM AracMarka WHERE AracMarka = '" + comboBox1.SelectedItem + "' and AracModel ='"+comboBox2.SelectedItem+"'";  
            komut.ExecuteNonQuery();
            komut.Dispose();
            DialogResult cevap = MessageBox.Show("Silme işlemi başarılı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (cevap == DialogResult.OK)
            {
                ayarlar ayar = new ayarlar();
                this.Hide();
                ayar.Show();
            }
            comboBox1.Refresh();

            baglanti.Close();
            doldur();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT AracModel FROM AracMarka WHERE AracMarka='" + comboBox1.Text + "' ", baglanti);
            sorgu.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sorgu);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr["AracModel"].ToString());
            }
            baglanti.Close();
        }

        private void markaekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            ayarlar ayar = new ayarlar();
            this.Hide();
            ayar.Show();
        }
    }
}
