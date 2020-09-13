using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace CaraCarBeyler
{
    public partial class islemler : Form
    {
        public islemler()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("SERVER=LAPTOP-PDQV3R54\\SQLEXPRESS; Database=RentACar;  Integrated Security=True;");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();

        void musterileriCek()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Musteri", baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            dataGridView1.Refresh();
        }

        void araclarıCek()
        {
            SqlDataAdapter arac = new SqlDataAdapter("SELECT * FROM Araclar WHERE AracDurum='0'", baglanti);
            baglanti.Open();
            DataTable table = new DataTable();
            arac.Fill(table);
            dataGridView2.DataSource = table;
            baglanti.Close();
            dataGridView2.Refresh();
        }
        private void islemler_Load(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox1.Visible = false;
            label10.Visible = false;
            musterileriCek();
            araclarıCek();
            txtadi.Enabled = false;
            txtadres.Enabled = false;
            txtsoyadi.Enabled = false;
            txttc.Enabled = false;
            txttel.Enabled = false;

            aracyakit.Enabled = false;
            aracuretim.Enabled = false;
            aracucret.Enabled = false;
            aracrenk.Enabled = false;
            aracplaka.Enabled = false;
            aracmodel.Enabled = false;
            aracmarka.Enabled = false;
            arackm.Enabled = false;
            arackasatipi.Enabled = false;
            aracdurum.Enabled = false;  
        }

        int tindex = 0;
        int tindex2 = 0;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e) 
        {
           
        }

        string AracId, MusteriId;

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtadi.Text == "" || txtadres.Text == "" || txtsoyadi.Text == "" || txttc.Text == "" || txttel.Text == "" || aracyakit.Text == "" || aracucret.Text == "")
                {
                    MessageBox.Show("Lütfen İşlem İçin Seçim Yapınız..");
                }
                else
                {
                    baglanti.Open();
                    textBox1.Text = (dateTimePicker2.Value - dateTimePicker1.Value).Days.ToString();


                    int birim = int.Parse(aracucret.Text);
                    int of = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                    int tutar = of * birim;

                    string ekleyelim = "INSERT INTO KiralananDeneme(AracMarka,AracModel,AracUretimYili,AracRenk,AracPlaka,AracKasaTipi,AracYakitTuru,AracKm,AracUcret,AracDurum,AracGorsel,Adi,Soyadi,Telefon,Adres,TC,AracKiraTarihi,AracTeslimTarihi,AracTutarBirim,AracKacGunKira,AracKiraTutar) VALUES(@AracMarka,@AracModel,@AracUretimYili,@AracRenk,@AracPlaka,@AracKasaTipi,@AracYakitTuru,@AracKm,@AracUcret,@AracDurum,@AracGorsel,@Adi,@Soyadi,@Telefon,@Adres,@TC,@AracKiraTarihi,@AracTeslimTarihi,@AracTutarBirim,@AracKacGunKira,@AracKiraTutar)";
                    SqlCommand ekle = new SqlCommand(ekleyelim, baglanti);
                    ekle.Parameters.AddWithValue("@AracMarka", aracmarka.Text);
                    ekle.Parameters.AddWithValue("@AracModel", aracmodel.Text);
                    ekle.Parameters.AddWithValue("@AracUretimYili", aracuretim.Text);
                    ekle.Parameters.AddWithValue("@AracRenk", aracrenk.Text);
                    ekle.Parameters.AddWithValue("@AracPlaka", aracplaka.Text);
                    ekle.Parameters.AddWithValue("@AracKasaTipi", arackasatipi.Text);
                    ekle.Parameters.AddWithValue("@AracYakitTuru", aracyakit.Text);
                    ekle.Parameters.AddWithValue("@AracKm", arackm.Text);
                    ekle.Parameters.AddWithValue("@AracUcret", aracucret.Text);
                    ekle.Parameters.AddWithValue("@AracDurum", aracdurum.Text);
                    ekle.Parameters.AddWithValue("@AracGorsel", aracgorsel.ImageLocation);
                    ekle.Parameters.AddWithValue("@Adi", txtadi.Text);
                    ekle.Parameters.AddWithValue("@Soyadi", txtsoyadi.Text);
                    ekle.Parameters.AddWithValue("@Telefon", txttel.Text);
                    ekle.Parameters.AddWithValue("@Adres", txtadres.Text);
                    ekle.Parameters.AddWithValue("@TC", txttc.Text);
                    ekle.Parameters.AddWithValue("@AracKiraTarihi", DateTime.Parse(dateTimePicker1.Text));
                    ekle.Parameters.AddWithValue("@AracTeslimTarihi", DateTime.Parse(dateTimePicker2.Text));
                    ekle.Parameters.AddWithValue("@AracTutarBirim", aracucret.Text);
                    ekle.Parameters.AddWithValue("@AracKacGunKira", of);
                    ekle.Parameters.AddWithValue("@AracKiraTutar", tutar);


                    ekle.ExecuteNonQuery();
                    ekle.Dispose();

                    String deneme = "UPDATE Araclar SET AracDurum=@AracDurum WHERE AracPlaka='" + aracplaka.Text + "'";
                    SqlCommand hoayda = new SqlCommand(deneme, baglanti);
                    hoayda.Parameters.AddWithValue("@AracDurum", aracdurum.Text);
                    hoayda.ExecuteNonQuery();
                    hoayda.Dispose();

                    baglanti.Close();
                    MessageBox.Show("Araç Kiralama işlemi Başarıyla Gerçekleşmiştir..");
                    araclarıCek();
                    temizle();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Araç Kiralama İşlemi Sırasında Bir Hata İle Karşılaşıldı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     





        void musteriara()
        {
            baglanti.Open();
            DataTable tb = new DataTable();
            string vara, cumle;
            vara = txtmusteriara.Text;
            cumle = "Select * from Musteri where Adi like '%" + txtmusteriara.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(cumle, baglanti);
            da.Fill(tb);
            baglanti.Close();
            dataGridView1.DataSource = tb;
        }

        void aracara()
        {
            baglanti.Open();
            DataTable table = new DataTable();
            string var, cumlem;
            var = txtaracara.Text;
            cumlem = "Select * From Araclar where AracPlaka like '%" + txtaracara.Text + "%'";
            SqlDataAdapter daa = new SqlDataAdapter(cumlem, baglanti);
            daa.Fill(table);
            baglanti.Close();
            dataGridView2.DataSource = table;
        }

        private void txtmusteriara_TextChanged(object sender, EventArgs e)
        {
            musteriara();
        }

        private void txtaracara_TextChanged(object sender, EventArgs e)
        {
            aracara();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                MusteriId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tindex = dataGridView1.SelectedRows[0].Index;
                if (tindex >= 0)
                {
                    txtadi.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    txtsoyadi.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    txttc.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    txttel.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    txtadres.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                }
            }
        }
        void temizle()
        {
            aracplaka.Text = "";
            aracrenk.Text = "";
            aracmodel.Text = "";
            aracmarka.Text = "";
            aracucret.Text = "";
            arackasatipi.Text = "";
            aracuretim.Text = "";
            arackm.Text = "";
            aracgorsel.ImageLocation = "";
            aracyakit.Text = "";
            txtadi.Text = "";
            txtsoyadi.Text = "";
            txttel.Text = "";
            txtadres.Text = "";
            txttc.Text = "";
        }
        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                AracId = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                tindex2 = dataGridView2.SelectedRows[0].Index;
                if (tindex2 >= 0)
                {
                    aracplaka.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                    aracrenk.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                    aracmodel.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                    aracmarka.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                    aracucret.Text = dataGridView2.SelectedRows[0].Cells[9].Value.ToString();
                    arackasatipi.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
                    aracuretim.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                    arackm.Text = dataGridView2.SelectedRows[0].Cells[8].Value.ToString();
                    aracgorsel.ImageLocation = dataGridView2.SelectedRows[0].Cells[11].Value.ToString();
                    aracyakit.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();

                }
            }
        }
    }
}

