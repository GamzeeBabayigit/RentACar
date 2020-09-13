using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using Microsoft.VisualBasic;
using System.IO;


namespace CaraCarBeyler
{
    public partial class ayarlar : Form
    {
        public ayarlar()
        {
            InitializeComponent();
        }

        SqlDataReader okuyucubey;

        SqlConnection baglanti = new SqlConnection("SERVER=LAPTOP-PDQV3R54\\SQLEXPRESS; Database=RentACar;  Integrated Security=True;");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();

      
        void verileri_cek() //personel verileri çek
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kullanici", baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            dataGridView1.Refresh();
        }

        void musteriVeri_cek() //Musteri verileri çek
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Musteri", baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();
            dataGridView2.Refresh();
        }
        void aracverilerimiz() //ARAC VERİLERİ
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Araclar",baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            baglanti.Close();
            dataGridView3.Refresh();
            txtdurum.Enabled= false;
        }

        void plakayagoreara()  //ARAÇ PLAKASINA GÖRE ARAMA YAPMAK İÇİN
        {
            baglanti.Open();
            DataTable table = new DataTable();
            string var, cumlem;
            var = txtaracplakaara.Text;
            cumlem = "Select * From Araclar where AracPlaka like '%" + txtaracplakaara.Text + "%'";
            SqlDataAdapter daa = new SqlDataAdapter(cumlem, baglanti);
            daa.Fill(table);
            baglanti.Close();
            dataGridView3.DataSource = table;
        }

        void musteritcgoreara()  //MÜŞTERİ TC'SİNE GÖRE ARAMA YAPMAK İÇİN
        {
            baglanti.Open();
            DataTable table = new DataTable();
            string var, cumlem;
            var = txtmusteriara.Text;
            cumlem = "Select * From Musteri where TC like '%" + txtmusteriara.Text + "%'";
            SqlDataAdapter daa = new SqlDataAdapter(cumlem, baglanti);
            daa.Fill(table);
            baglanti.Close();
            dataGridView2.DataSource = table;
        }

        void personelara()  
        {
            baglanti.Open();
            DataTable table = new DataTable();
            string var, cumlem;
            var = txtpersonelara.Text;
            cumlem = "Select * From Kullanici where KullaniciAdi like '%" + txtpersonelara.Text + "%'";
            SqlDataAdapter daa = new SqlDataAdapter(cumlem, baglanti);
            daa.Fill(table);
            baglanti.Close();
            dataGridView1.DataSource = table;
        }

        void cbdoldur()
        {
            cburetimyili.Items.Clear();
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT UretimYili FROM UretimYili ORDER BY UretimYili ASC", baglanti);
            sorgu.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sorgu);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cburetimyili.Items.Add(dr["UretimYili"].ToString());
            }
            baglanti.Close();
        }

        void yakitdoldur()
        {
            cbyakit.Items.Clear();
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT AracYakitTuru FROM YakitTuru ORDER BY AracYakitTuru ASC", baglanti);
            sorgu.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sorgu);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbyakit.Items.Add(dr["AracYakitTuru"].ToString());
            }
            baglanti.Close();
        }

        void renkdoldur()
        {
            cbrenk.Items.Clear();
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT Renk FROM AracRenk ORDER BY Renk ASC", baglanti);
            sorgu.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sorgu);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbrenk.Items.Add(dr["Renk"].ToString());
            }
            baglanti.Close();
        }

        void kasadoldur()
        {
            cbkasatipi.Items.Clear();
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT KasaTipi FROM KasaTipi ORDER BY KasaTipi ASC",baglanti);
            sorgu.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sorgu);
            adp.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbkasatipi.Items.Add(dr["KasaTipi"].ToString());
            }
            baglanti.Close();
        }
        private void ayarlar_Load(object sender, EventArgs e)
        {
            markadoldur();
            markaekle mark = new markaekle();
            mark.Refresh();

            aracuretimyili yil = new aracuretimyili();
            yil.Refresh();
            cbdoldur();

            kasatipi kasa = new kasatipi();
            kasa.Refresh();
            kasadoldur();

            renkdoldur();
            renkekle renk = new renkekle();
            renk.Refresh();

            yakitdoldur();
            YakitTuru tur = new YakitTuru();
            tur.Refresh();

            verileri_cek();
            musteriVeri_cek();
            aracverilerimiz();
         
        }

        void temizleyelim() //personel textboxları temizle
        {
            txtadi.Text = "";
            txtKullaniciadi.Text = "";
            txtsifre.Text = "";
            txtsoyadi.Text = "";
            txttel.Text = "";
        }

        void musteritemizle() //müşteri textbocları temizle
        {
            musteriadi.Text = "";
            musteriadres.Text = "";
            musterisoyadi.Text = "";
            musteritc.Text = "";
            musteritel.Text = "";
        }


        private void btnEkle_Click(object sender, EventArgs e) //personel ekle
        {
            if (txtadi.Text == "" || txtKullaniciadi.Text == "" || txtsifre.Text == "" || txtsoyadi.Text == "" || txttel.Text == "")
            {
                MessageBox.Show("Lütfen ilgili alanları doldurun...");
            }
            else
            {

                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand hmm = new SqlCommand();
                hmm.Connection = baglanti;
                hmm.CommandText = "SELECT id FROM Kullanici WHERE KullaniciAdi='" + txtKullaniciadi.Text + "'";
                okuyucubey = hmm.ExecuteReader();
                if (okuyucubey.Read())
                {
                    MessageBox.Show("Bu Kullanıcı İsminde Bir Kayıt Bulunmuştur..");
                    okuyucubey.Close();
                }
                else
                {
                    okuyucubey.Close();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "INSERT INTO Kullanici(KullaniciAdi,Adi,Soyadi,Sifre,Telefon) VALUES(@KullaniciAdi,@Adi,@Soyadi,@Sifre,@Telefon)";
                    cmd.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciadi.Text);
                    cmd.Parameters.AddWithValue("@Adi", txtadi.Text);
                    cmd.Parameters.AddWithValue("@Soyadi", txtsoyadi.Text);
                    cmd.Parameters.AddWithValue("Sifre", txtsifre.Text);
                    cmd.Parameters.AddWithValue("Telefon", txttel.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Personel kayıt işleminiz başarıyla gerçekleşmiştir.");
                    baglanti.Close();
                    temizleyelim();
                    verileri_cek();
                    txtKullaniciadi.Focus();
                }
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e) //personel guncelle
        {
            if (txtadi.Text == "" || txtKullaniciadi.Text == "" || txtsifre.Text == "" || txtsoyadi.Text == "" || txttel.Text == "")
            {
                MessageBox.Show("Lütfen ilgili alanları doldurun...");
            }
           
                else
                {
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;

                    cmd.CommandText = "UPDATE Kullanici SET KullaniciAdi=@KullaniciAdi,Adi=@Adi,Soyadi=@Soyadi,Sifre=@Sifre,Telefon=@Telefon WHERE id=@id";
                    cmd.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciadi.Text);
                    cmd.Parameters.AddWithValue("@Adi", txtadi.Text);
                    cmd.Parameters.AddWithValue("@Soyadi", txtsoyadi.Text);
                    cmd.Parameters.AddWithValue("@Sifre", txtsifre.Text);
                    cmd.Parameters.AddWithValue("@Telefon", txttel.Text);
                    cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşmiştir");
                    baglanti.Close();
                    temizleyelim();
                    verileri_cek();
                    txtKullaniciadi.Focus();
                }
            }
        
        private void btnSil_Click(object sender, EventArgs e) //personel sil
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "DELETE FROM Kullanici WHERE id=@id";
            komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
            ds.Clear();
            verileri_cek();
            MessageBox.Show("Silme İşleminiz Başarıyla Gerçekleşti.");
            temizleyelim();
        }

        private void musteriekle_Click(object sender, EventArgs e) //müşteri ekle
        {
            if (musteritc.Text == "" || musteritel.Text == "" || musteriadi.Text == "" || musterisoyadi.Text == "" || musteriadres.Text == "")
            {
                MessageBox.Show("Lütfen ilgili alanları doldurun...");
            }
            else
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;

                cmd.CommandText = "SELECT id FROM Musteri WHERE TC='" + musteritc.Text + "'";
                okuyucubey = cmd.ExecuteReader();
                if (okuyucubey.Read())
                {
                    MessageBox.Show("Bu TC Kimlik Numaralı Bir Müşteri Bulunmaktadır..");
                    okuyucubey.Close();
                }
                else
                {
                    okuyucubey.Close();
                    cmd.CommandText = "INSERT INTO Musteri(TC,Adi,Soyadi,Telefon,Adres) VALUES(@TC,@Adi,@Soyadi,@Telefon,@Adres)";
                    cmd.Parameters.AddWithValue("@TC", musteritc.Text);
                    cmd.Parameters.AddWithValue("@Adi", musteriadi.Text);
                    cmd.Parameters.AddWithValue("@Soyadi", musterisoyadi.Text);
                    cmd.Parameters.AddWithValue("@Telefon", musteritel.Text);
                    cmd.Parameters.AddWithValue("@Adres", musteriadres.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Müşteri Ekleme İşlemi Başarıyla Gerçekleşmiştir");
                    baglanti.Close();
                    musteritemizle();
                    musteriVeri_cek();
                    musteritc.Focus();
                }
            }
        }

        private void musterisil_Click(object sender, EventArgs e) //müşteri sil
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "DELETE FROM Musteri Where id=@id";
            komut.Parameters.AddWithValue("@id", dataGridView2.CurrentRow.Cells[0].Value.ToString());
            komut.ExecuteNonQuery();
            komut.Dispose();
            ds.Clear();
            baglanti.Close();
            musteriVeri_cek();
            
            MessageBox.Show("Müşteri Silme İşleminiz Başarıyla Gerçekleşti..");
            musteritemizle();
            
            
        }

        private void musteriguncelle_Click(object sender, EventArgs e) //müşteri güncelle
        {
            if (musteritc.Text == "" || musteritel.Text == "" || musteriadi.Text == "" || musterisoyadi.Text == "" || musteriadres.Text == "")
            {
                MessageBox.Show("Lütfen ilgili alanları doldurun...");
            }
            else
            {
                
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "UPDATE Musteri SET TC=@TC,Adi=@Adi,Soyadi=@Soyadi,Telefon=@Telefon,Adres=@Adres WHERE id=@id";
                    cmd.Parameters.AddWithValue("@TC", musteritc.Text);
                    cmd.Parameters.AddWithValue("@Adi", musteriadi.Text);
                    cmd.Parameters.AddWithValue("@Soyadi", musterisoyadi.Text);
                    cmd.Parameters.AddWithValue("@Telefon", musteritel.Text);
                    cmd.Parameters.AddWithValue("@Adres", musteriadres.Text);
                    cmd.Parameters.AddWithValue("@id", dataGridView2.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşmiştir");
                    baglanti.Close();
                    musteritemizle();
                    musteriVeri_cek();
                    musteritc.Focus();
                }
            }
        
        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //ARAÇ SİLME
        {
            try
            {
                DialogResult silelim = MessageBox.Show("Araç Silme İşlemini Onaylamak İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (silelim == DialogResult.Yes)
                {
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "DELETE FROM Araclar WHERE id=@id";
                    komut.Parameters.AddWithValue("@id", dataGridView3.CurrentRow.Cells[0].Value.ToString());
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    ds.Clear();
                    aracverilerimiz();

                    arabamizitemizleyelim();
                }
               
            }
            catch(Exception)
            {
                MessageBox.Show("Lütfen Seçim Yapınız..");
            }
        }
        

        void arabamizitemizleyelim()
        {
            cbyakit.SelectedIndex = -1;
            cburetimyili.SelectedIndex = -1;
            txtucret.Text = "";
            cbrenk.SelectedIndex = -1;
            txtplaka.Text = "";
            
            txtkm.Text = "";
            cbmarka.SelectedIndex = -1;
            cbmodel.SelectedIndex = -1;
            txtdurum.Text = "0"; 
            pictureBox1.Image=null;
            cbkasatipi.SelectedIndex = -1;
        }

        private void aracekle_Click(object sender, EventArgs e)  //ARAÇ EKLE BUTONU
        {
            
                if (txtplaka.Text == "" || cbmodel.Text == "" || cbmarka.Text == "" || txtkm.Text == "" || txtdurum.Text == "" || cbkasatipi.Text == "" || cbrenk.Text == "" || txtucret.Text == "" || cbyakit.Text == "" || cburetimyili.Text == "")
                {
                    MessageBox.Show("Lütfen İlgili Alanları Doldurunuz...");
                }
                else
                {
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "SELECT id FROM Araclar WHERE AracPlaka='" + txtplaka.Text + "'";
                    okuyucubey = cmd.ExecuteReader();
                    if (okuyucubey.Read())
                    {
                        MessageBox.Show("Bu plakaya sahip bir araç bulunmaktadır...");
                        okuyucubey.Close();
                    }
                    else
                    {
                        okuyucubey.Close();
                        cmd.CommandText = "INSERT INTO Araclar(AracMarka, AracModel, AracUretimYili, AracRenk, AracPlaka, AracKasaTipi, AracYakitTuru, AracKm, AracUcret, AracDurum, AracGorsel) VALUES(@AracMarka, @AracModel, @AracUretimYili, @AracRenk, @AracPlaka, @AracKasaTipi, @AracYakitTuru, @AracKm, @AracUcret, @AracDurum, @AracGorsel)";
                        cmd.Parameters.AddWithValue("@AracMarka", cbmarka.Text);
                        cmd.Parameters.AddWithValue("@AracModel", cbmodel.Text);
                        cmd.Parameters.AddWithValue("@AracUretimYili", cburetimyili.Text);
                        cmd.Parameters.AddWithValue("@AracRenk", cbrenk.Text);
                        cmd.Parameters.AddWithValue("@AracPlaka", txtplaka.Text);
                        cmd.Parameters.AddWithValue("@AracKasaTipi", cbkasatipi.Text);
                        cmd.Parameters.AddWithValue("@AracYakitTuru", cbyakit.Text);
                        cmd.Parameters.AddWithValue("@AracKm", txtkm.Text);
                        cmd.Parameters.AddWithValue("@AracUcret", txtucret.Text);
                        cmd.Parameters.AddWithValue("@AracDurum", txtdurum.Text);
                        cmd.Parameters.AddWithValue("@AracGorsel", dosyaYolu.Trim());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Araç Ekleme İşlemi Başarıyla Gerçekleşmiştir...");
                        baglanti.Close();
                        arabamizitemizleyelim();
                        txtplaka.Focus();
                        aracverilerimiz();

                    }
                }
        }
        string dosyaYolu;
        private void btngorselekle_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Görsel Seç";
            fd.Filter = "(*.jpg)|*.jpg|(*.png)|*.png";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = new Bitmap(fd.OpenFile());
               dosyaYolu = fd.FileName;
               
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbyakit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e) //ARAÇ ÜRETİM YILI EKLE
        {
            
            aracuretimyili uret = new aracuretimyili();
            
            uret.Show();
            this.Hide();
            
        }
   

        private void pictureBox3_Click(object sender, EventArgs e)//RENK EKLE
        {
            renkekle renk = new renkekle();
            renk.Show();
            this.Hide();
            
            
        }

        private void aracguncelle_Click(object sender, EventArgs e)
        {
            dosyaYolu = pictureBox1.ImageLocation;

            if (txtplaka.Text == "" || cbmodel.Text == "" || cbmarka.Text == "" || txtkm.Text == "" || txtdurum.Text == "" || cbkasatipi.Text == "" || cbrenk.Text == "" || txtucret.Text == "" || cbyakit.Text == "" || cburetimyili.Text == "")
            {
                MessageBox.Show("Lütfen İlgili Alanları Doldurunuz...");
            }
            else
            {

                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                try
                {
                    cmd.CommandText = "UPDATE Araclar SET AracMarka=@AracMarka, AracModel=@AracModel, AracUretimYili=@AracUretimYili, AracRenk=@AracRenk, AracPlaka=@AracPlaka, AracKasaTipi=@AracKasaTipi, AracYakitTuru=@AracYakitTuru, AracKm=@AracKm, AracUcret=@AracUcret, AracDurum=@AracDurum, AracGorsel=@AracGorsel WHERE id=@id";

                    cmd.Parameters.AddWithValue("@AracMarka", cbmarka.Text);
                    cmd.Parameters.AddWithValue("@AracModel", cbmodel.Text);
                    cmd.Parameters.AddWithValue("@AracUretimYili", cburetimyili.Text);
                    cmd.Parameters.AddWithValue("@AracRenk", cbrenk.Text);
                    cmd.Parameters.AddWithValue("@AracPlaka", txtplaka.Text);
                    cmd.Parameters.AddWithValue("@AracKasaTipi", cbkasatipi.Text);
                    cmd.Parameters.AddWithValue("@AracYakitTuru", cbyakit.Text);
                    cmd.Parameters.AddWithValue("@AracKm", txtkm.Text);
                    cmd.Parameters.AddWithValue("@AracUcret", txtucret.Text);
                    cmd.Parameters.AddWithValue("@AracDurum", txtdurum.Text);
                    cmd.Parameters.AddWithValue("@AracGorsel", dosyaYolu.Trim());
                    cmd.Parameters.AddWithValue("@id", dataGridView3.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Araç Güncelleme İşlemi Başarıyla Gerçekleşmiştir...");
                    baglanti.Close();
                    arabamizitemizleyelim();
                    txtplaka.Focus();
                    aracverilerimiz();
                }
                catch (Exception)
                {
                    MessageBox.Show("Güncelleme işlemi sırasında bir hata ile karşılaşıldı..","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e) //URETİM YILI SİLME
        {

        }

        int tindex = 0;
        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        int tindex2 = 0;
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        int tindex3 = 0;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void temizlebtn_Click(object sender, EventArgs e)
        {
            arabamizitemizleyelim();
            cbrenk.SelectedIndex = -1;
            cburetimyili.SelectedIndex = -1;
            cbyakit.SelectedIndex = -1;
            cbkasatipi.SelectedIndex = -1;
        }

        private void temizlemusteri_Click(object sender, EventArgs e)
        {
            musteritemizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizleyelim();
        }

        private void txtucret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtkm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void musteritel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void musteritc_KeyPress(object sender, KeyPressEventArgs e)//SADECE SAYI GİRİŞİ İÇİN
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtpersonelara_TextChanged(object sender, EventArgs e)
        {
            personelara();
        }

        private void txtmusteriara_TextChanged(object sender, EventArgs e)
        {
            musteritcgoreara();
        }

        private void txtaracplakaara_TextChanged(object sender, EventArgs e)
        {
            plakayagoreara();
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            YakitTuru yakit = new YakitTuru();
            yakit.Show();
            this.Hide();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                tindex3 = dataGridView1.SelectedRows[0].Index;
                if (tindex3 >= 0)
                {

                    txtKullaniciadi.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    txtadi.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    txtsoyadi.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    txtsifre.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    txttel.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                }
            }
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                tindex2 = dataGridView2.SelectedRows[0].Index;
                if (tindex2 >= 0)
                {
                    musteritc.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                    musteritel.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                    musterisoyadi.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                    musteriadres.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                    musteriadi.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                }
            }
        }

        private void dataGridView3_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                tindex = dataGridView3.SelectedRows[0].Index;
                if (tindex >= 0)
                {
                    txtplaka.Text = dataGridView3.SelectedRows[0].Cells[5].Value.ToString();
                    cbmodel.Text = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
                    cburetimyili.Text = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();
                    cbrenk.Text = dataGridView3.SelectedRows[0].Cells[4].Value.ToString();
                    cbmarka.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
                    cbkasatipi.Text = dataGridView3.SelectedRows[0].Cells[6].Value.ToString();
                    cbyakit.Text = dataGridView3.SelectedRows[0].Cells[7].Value.ToString();
                    txtkm.Text = dataGridView3.SelectedRows[0].Cells[8].Value.ToString();
                    txtucret.Text = dataGridView3.SelectedRows[0].Cells[9].Value.ToString();
                    pictureBox1.ImageLocation = dataGridView3.SelectedRows[0].Cells[11].Value.ToString();
                    txtdurum.Text = dataGridView3.SelectedRows[0].Cells[10].Value.ToString();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            kasatipi kasa = new kasatipi();
            kasa.Show();
            this.Hide();
        }

       

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            markaekle marka = new markaekle();
            marka.Show(); 
            this.Hide();

        }
        void markadoldur()
        {

            cbmarka.Items.Clear();
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT DISTINCT AracMarka FROM AracMarka", baglanti);
            sorgu.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sorgu);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbmarka.Items.Add(dr["AracMarka"].ToString());
            }
            baglanti.Close();
        }
        private void cbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbmodel.Items.Clear();
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT AracModel FROM AracMarka WHERE AracMarka='"+cbmarka.Text+"' ", baglanti);
            sorgu.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sorgu);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbmodel.Items.Add(dr["AracModel"].ToString());
            }
            baglanti.Close();
        }
    }
}
