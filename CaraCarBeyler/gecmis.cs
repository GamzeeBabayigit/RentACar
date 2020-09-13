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

namespace CaraCarBeyler
{
    public partial class gecmis : Form
    {
        public gecmis()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("SERVER=LAPTOP-PDQV3R54\\SQLEXPRESS; Database=RentACar;  Integrated Security=True;");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();


        void verilericek()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Distinct * FROM KiralananDeneme WHERE AracDurum='1' ", baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            dataGridView1.Refresh();
        }

        void araclaricek()
        {
            SqlDataAdapter hoayda = new SqlDataAdapter("SELECT Distinct * FROM Araclar", baglanti);
            baglanti.Open();
            DataTable masa = new DataTable();
            hoayda.Fill(masa);
            dataGridView2.DataSource = masa;
            baglanti.Close();
            dataGridView2.Refresh();
        }
        void musteriara()
        {
            baglanti.Open();
            DataTable tb = new DataTable();
            string vara, cumle;
            vara = txtada.Text;
            cumle = "Select Distinct * from KiralananDeneme where AracDurum='1' and Adi like '%" + txtada.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(cumle, baglanti);
            da.Fill(tb);
            baglanti.Close();
            dataGridView1.DataSource = tb;

        }

        void gizemliöö()
        {
            AracYakitTuru.Visible = false;
            AracUretimYili.Visible = false;
            AracModel.Visible = false;
            AracMarka.Visible = false;
            AracDurum.Visible = false;
            AracGorsel.Visible = false;
            AracKacGunKira.Visible = false;
            AracKasaTipi.Visible = false;
            AracKiraTarihi.Visible = false;
            AracKiraTutar.Visible = false;
            AracKm.Visible = false;
            AracMarka.Visible = false;
            AracModel.Visible = false;
            AracPlaka.Visible = false;
            AracRenk.Visible = false;
            AracTeslim.Visible = false;
            AracTutarBirim.Visible = false;
            GecKalmaSuresi.Visible = false;
            Adi.Visible = false;
            Soyadi.Visible = false;
            Telefon.Visible = false;
            adres.Visible = false;
            TC.Visible = false;
            AracUcret.Visible = false;
            dataGridView2.Visible = false;

            textBox1.Visible = false;
            gamze.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
        }
        private void gecmis_Load(object sender, EventArgs e)
        {

            araclaricek();
            gizemliöö();
            verilericek();
        }
        void aracara()
        {
            baglanti.Open();
            DataTable table = new DataTable();
            string var, cumlem;
            var = txtplakaya.Text;
            cumlem = "Select Distinct * From KiralananDeneme where AracDurum='1' and AracPlaka like '%" + txtplakaya.Text + "%'";
            SqlDataAdapter daa = new SqlDataAdapter(cumlem, baglanti);
            daa.Fill(table);
            baglanti.Close();
            dataGridView1.DataSource = table;
        }
        private void txtada_TextChanged(object sender, EventArgs e)
        {
            musteriara();
        }

        private void txtplakaya_TextChanged(object sender, EventArgs e)
        {
            aracara();
        }

        private void odemeYap_Click(object sender, EventArgs e)
        {
            try
            {
                gamze.Text = (dateTimePicker2.Value - dateTimePicker1.Value).Days.ToString();

                int ilk = int.Parse(gamze.Text);
                int iki = int.Parse(AracKacGunKira.Text);
                int tutar = int.Parse(AracTutarBirim.Text);

                int normal = (ilk+iki)*tutar;

                if (int.Parse(gamze.Text) > 0)
                {
                    baglanti.Open();
                    int carpilacak = 2 * (ilk + iki) * tutar;

                  
                    String gecikmevar = "INSERT INTO OdenenDeneme(AracMarka,AracModel,AracUretimYili,AracRenk,AracPlaka,AracKasaTipi,AracYakitTuru,AracKm,AracUcret,AracDurum,AracGorsel,AracKiraTarihi,AracTeslimTarihi,AracTutarBirim,AracKacGunKira,AracKiraTutar,GecKalmaSuresi,Musteri_Adi,Musteri_Soyadi,Musteri_Tel,Musteri_TC,Musteri_Adres) VALUES (@AracMarka,@AracModel,@AracUretimYili,@AracRenk,@AracPlaka,@AracKasaTipi,@AracYakitTuru,@AracKm,@AracUcret,@AracDurum,@AracGorsel,@AracKiraTarihi,@AracTeslimTarihi,@AracTutarBirim,@AracKacGunKira,@AracKiraTutar,@GecKalmaSuresi,@Musteri_Adi,@Musteri_Soyadi,@Musteri_Tel,@Musteri_TC,@Musteri_Adres)";
                    SqlCommand eklemeklazim = new SqlCommand(gecikmevar, baglanti);
                    eklemeklazim.Parameters.AddWithValue("@AracMarka", AracMarka.Text);
                    eklemeklazim.Parameters.AddWithValue("@AracModel", AracModel.Text);
                    eklemeklazim.Parameters.AddWithValue("@AracUretimYili", AracUretimYili.Text);
                    eklemeklazim.Parameters.AddWithValue("@AracRenk", AracRenk.Text);
                    eklemeklazim.Parameters.AddWithValue("@AracPlaka", AracPlaka.Text);
                    eklemeklazim.Parameters.AddWithValue("@AracKasaTipi", AracKasaTipi.Text);
                    eklemeklazim.Parameters.AddWithValue("@AracYakitTuru", AracYakitTuru.Text);
                    eklemeklazim.Parameters.AddWithValue("@AracKm", AracKm.Text);
                    eklemeklazim.Parameters.AddWithValue("@AracUcret", AracUcret.Text);
                    eklemeklazim.Parameters.AddWithValue("@AracDurum", textBox1.Text);
                    eklemeklazim.Parameters.AddWithValue("@AracGorsel", AracGorsel.Text);
                    eklemeklazim.Parameters.AddWithValue("@AracKiraTarihi", AracKiraTarihi.Text);
                    eklemeklazim.Parameters.AddWithValue("@AracTeslimTarihi", AracTeslim.Text);
                    eklemeklazim.Parameters.AddWithValue("@AracTutarBirim", AracTutarBirim.Text);
                    eklemeklazim.Parameters.AddWithValue("@AracKacGunKira", AracKacGunKira.Text);
                    eklemeklazim.Parameters.AddWithValue("@AracKiraTutar", carpilacak.ToString());
                    eklemeklazim.Parameters.AddWithValue("@GecKalmaSuresi", gamze.Text);
                    eklemeklazim.Parameters.AddWithValue("@Musteri_Adi", Adi.Text);
                    eklemeklazim.Parameters.AddWithValue("@Musteri_Soyadi", Soyadi.Text);
                    eklemeklazim.Parameters.AddWithValue("@Musteri_Tel", Telefon.Text);
                    eklemeklazim.Parameters.AddWithValue("@Musteri_TC", TC.Text);
                    eklemeklazim.Parameters.AddWithValue("@Musteri_Adres", adres.Text);
                    eklemeklazim.ExecuteNonQuery();
                    eklemeklazim.Dispose();


                    String deneme = "UPDATE Araclar SET AracDurum=@AracDurum WHERE AracPlaka='" + AracPlaka.Text + "'";
                    SqlCommand hoayda = new SqlCommand(deneme, baglanti);
                    hoayda.Parameters.AddWithValue("@AracDurum", textBox1.Text);
                    hoayda.ExecuteNonQuery();
                    hoayda.Dispose();

                    String geckalmadi = "UPDATE KiralananDeneme SET GecKalmaSuresi=@GecKalmaSuresi,AracDurum=@AracDurum WHERE ID=@ID ";
                    SqlCommand gec = new SqlCommand(geckalmadi, baglanti);
                    gec.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    gec.Parameters.AddWithValue("@GecKalmaSuresi", gamze.Text);
                    gec.Parameters.AddWithValue("@AracDurum", textBox1.Text);//SIFIRLAMA
                    gec.ExecuteNonQuery();
                    gec.Dispose();
                    baglanti.Close();
                    MessageBox.Show("Cezalı Ödeme İşlemi Yapıldı.. Ödenen Tutar = " + carpilacak.ToString() + "  Aracın Geç Getirilme Süresi=" + gamze.Text);
                    verilericek();
                }
                else
                {
                    //GECİKME YOK
                    baglanti.Open();
                    String odendi = "INSERT INTO OdenenDeneme(AracMarka,AracModel,AracUretimYili,AracRenk,AracPlaka,AracKasaTipi,AracYakitTuru,AracKm,AracUcret,AracDurum,AracGorsel,AracKiraTarihi,AracTeslimTarihi,AracTutarBirim,AracKacGunKira,AracKiraTutar,GecKalmaSuresi,Musteri_Adi,Musteri_Soyadi,Musteri_Tel,Musteri_TC,Musteri_Adres) VALUES (@AracMarka,@AracModel,@AracUretimYili,@AracRenk,@AracPlaka,@AracKasaTipi,@AracYakitTuru,@AracKm,@AracUcret,@AracDurum,@AracGorsel,@AracKiraTarihi,@AracTeslimTarihi,@AracTutarBirim,@AracKacGunKira,@AracKiraTutar,@GecKalmaSuresi,@Musteri_Adi,@Musteri_Soyadi,@Musteri_Tel,@Musteri_TC,@Musteri_Adres)";
                    SqlCommand ekle = new SqlCommand(odendi, baglanti);
                    ekle.Parameters.AddWithValue("@AracMarka", AracMarka.Text);
                    ekle.Parameters.AddWithValue("@AracModel", AracModel.Text);
                    ekle.Parameters.AddWithValue("@AracUretimYili", AracUretimYili.Text);
                    ekle.Parameters.AddWithValue("@AracRenk", AracRenk.Text);
                    ekle.Parameters.AddWithValue("@AracPlaka", AracPlaka.Text);
                    ekle.Parameters.AddWithValue("@AracKasaTipi", AracKasaTipi.Text);
                    ekle.Parameters.AddWithValue("@AracYakitTuru", AracYakitTuru.Text);
                    ekle.Parameters.AddWithValue("@AracKm", AracKm.Text);
                    ekle.Parameters.AddWithValue("@AracUcret", AracUcret.Text);
                    ekle.Parameters.AddWithValue("@AracDurum", textBox1.Text);
                    ekle.Parameters.AddWithValue("@AracGorsel", AracGorsel.Text);
                    ekle.Parameters.AddWithValue("@AracKiraTarihi", AracKiraTarihi.Text);
                    ekle.Parameters.AddWithValue("@AracTeslimTarihi", AracTeslim.Text);
                    ekle.Parameters.AddWithValue("@AracTutarBirim", AracTutarBirim.Text);
                    ekle.Parameters.AddWithValue("@AracKacGunKira", AracKacGunKira.Text);
                  
                    ekle.Parameters.AddWithValue("@AracKiraTutar",normal.ToString());
                    ekle.Parameters.AddWithValue("@GecKalmaSuresi", GecKalmaSuresi.Text);
                    ekle.Parameters.AddWithValue("@Musteri_Adi", Adi.Text);
                    ekle.Parameters.AddWithValue("@Musteri_Soyadi", Soyadi.Text);
                    ekle.Parameters.AddWithValue("@Musteri_Tel", Telefon.Text);
                    ekle.Parameters.AddWithValue("@Musteri_TC", TC.Text);
                    ekle.Parameters.AddWithValue("@Musteri_Adres", adres.Text);
                    ekle.ExecuteNonQuery();
                    ekle.Dispose();


                    String deneme = "UPDATE Araclar SET AracDurum=@AracDurum WHERE AracPlaka='" + AracPlaka.Text + "'";
                    SqlCommand hoayda = new SqlCommand(deneme, baglanti);
                    hoayda.Parameters.AddWithValue("@AracDurum", textBox1.Text);
                    hoayda.ExecuteNonQuery();
                    hoayda.Dispose();

                    String geckalmadi = "UPDATE KiralananDeneme SET GecKalmaSuresi=@GecKalmaSuresi,AracDurum=@AracDurum WHERE ID=@ID ";
                    SqlCommand gec = new SqlCommand(geckalmadi, baglanti);
                    gec.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    gec.Parameters.AddWithValue("@GecKalmaSuresi", textBox1.Text);
                    gec.Parameters.AddWithValue("@AracDurum", textBox1.Text);
                    gec.ExecuteNonQuery();
                    gec.Dispose();

                    baglanti.Close();
                 // MessageBox.Show("Ücret Ödeme İşlemi Başarıyla Gerçekleştirildi..Ödenen Tutar= " + AracKiraTutar.Text);
                    MessageBox.Show("Ücret Ödeme İşlemi Başarıyla Gerçekleştirildi.. Ödenen Tutar=" +normal.ToString());
                    verilericek();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Satır Seçiniz..");
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int tindex2;

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                tindex2 = dataGridView1.SelectedRows[0].Index;
                if (tindex2 >= 0)
                {

                    dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[18].Value.ToString();
                    AracMarka.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    AracModel.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    AracUretimYili.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    AracRenk.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    AracPlaka.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    AracKasaTipi.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    AracYakitTuru.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    AracKm.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                    AracUcret.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                    AracDurum.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                    AracGorsel.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                    AracKiraTarihi.Text = dataGridView1.SelectedRows[0].Cells[17].Value.ToString();
                    AracTeslim.Text = dataGridView1.SelectedRows[0].Cells[18].Value.ToString();
                    AracTutarBirim.Text = dataGridView1.SelectedRows[0].Cells[19].Value.ToString();
                    AracKacGunKira.Text = dataGridView1.SelectedRows[0].Cells[21].Value.ToString();
                    AracKiraTutar.Text = dataGridView1.SelectedRows[0].Cells[20].Value.ToString();
                    GecKalmaSuresi.Text = dataGridView1.SelectedRows[0].Cells[22].Value.ToString();
                    Adi.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                    Soyadi.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
                    Telefon.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
                    TC.Text = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
                    adres.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();

                }

            }
        }

        private void islemiptal_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Index < 0) MessageBox.Show("Lütfen Seçim Yapınız");
                else
                {

                    baglanti.Open();
                    string iptal = "INSERT INTO IptalDeneme (AracMarka,AracModel,AracUretimYili,AracRenk,AracPlaka,AracKasaTipi,AracYakitTuru,AracKm,AracUcret,AracDurum,AracGorsel,AracKiraTarihi,AracTeslimTarihi,AracTutarBirim,AracKacGunKira,AracKiraTutar,GecKalmaSuresi,Musteri_Adi,Musteri_Soyadi,Musteri_Tel,Musteri_TC) VALUES (@AracMarka,@AracModel,@AracUretimYili,@AracRenk,@AracPlaka,@AracKasaTipi,@AracYakitTuru,@AracKm,@AracUcret,@AracDurum,@AracGorsel,@AracKiraTarihi,@AracTeslimTarihi,@AracTutarBirim,@AracKacGunKira,@AracKiraTutar,@GecKalmaSuresi,@Musteri_Adi,@Musteri_Soyadi,@Musteri_Tel,@Musteri_TC)";
                    SqlCommand ekle = new SqlCommand(iptal, baglanti);
                    ekle.Parameters.AddWithValue("@AracMarka", AracMarka.Text);
                    ekle.Parameters.AddWithValue("@AracModel", AracModel.Text);
                    ekle.Parameters.AddWithValue("@AracUretimYili", AracUretimYili.Text);
                    ekle.Parameters.AddWithValue("@AracRenk", AracRenk.Text);
                    ekle.Parameters.AddWithValue("@AracPlaka", AracPlaka.Text);
                    ekle.Parameters.AddWithValue("@AracKasaTipi", AracKasaTipi.Text);
                    ekle.Parameters.AddWithValue("@AracYakitTuru", AracYakitTuru.Text);
                    ekle.Parameters.AddWithValue("@AracKm", AracKm.Text);
                    ekle.Parameters.AddWithValue("@AracUcret", AracUcret.Text);
                    ekle.Parameters.AddWithValue("@AracDurum", '0');
                    ekle.Parameters.AddWithValue("@AracGorsel", AracGorsel.Text);
                    ekle.Parameters.AddWithValue("@AracKiraTarihi", AracKiraTarihi.Text);
                    ekle.Parameters.AddWithValue("@AracTeslimTarihi", AracTeslim.Text);
                    ekle.Parameters.AddWithValue("@AracTutarBirim", AracTutarBirim.Text);
                    ekle.Parameters.AddWithValue("@AracKacGunKira", AracKacGunKira.Text);
                    ekle.Parameters.AddWithValue("@AracKiraTutar", AracKiraTutar.Text);
                    ekle.Parameters.AddWithValue("@GecKalmaSuresi", GecKalmaSuresi.Text);
                    ekle.Parameters.AddWithValue("@Musteri_Adi", Adi.Text);
                    ekle.Parameters.AddWithValue("@Musteri_Soyadi", Soyadi.Text);
                    ekle.Parameters.AddWithValue("@Musteri_Tel", Telefon.Text);
                    ekle.Parameters.AddWithValue("@Musteri_TC", TC.Text);
                    ekle.ExecuteNonQuery();
                    ekle.Dispose();


                    String deneme = "UPDATE Araclar SET AracDurum=@AracDurum WHERE AracPlaka='" + AracPlaka.Text + "'";
                    SqlCommand hoayda = new SqlCommand(deneme, baglanti);
                    hoayda.Parameters.AddWithValue("@AracDurum", textBox1.Text);
                    hoayda.ExecuteNonQuery();
                    hoayda.Dispose();

                    String geckalmadi = "UPDATE KiralananDeneme SET GecKalmaSuresi=@GecKalmaSuresi,AracDurum=@AracDurum WHERE ID=@ID ";
                    SqlCommand gec = new SqlCommand(geckalmadi, baglanti);
                    gec.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    gec.Parameters.AddWithValue("@GecKalmaSuresi", GecKalmaSuresi.Text);
                    gec.Parameters.AddWithValue("@AracDurum", textBox1.Text);
                    gec.ExecuteNonQuery();
                    gec.Dispose();


                    baglanti.Close();
                    MessageBox.Show("Araç Kiralama İşlemi İptal Edilmiştir..");
                    verilericek();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Seçim Yapınız..");
            }
        }
    }

        }
    
