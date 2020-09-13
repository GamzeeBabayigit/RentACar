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
    public partial class modelekle : Form
    {
        public modelekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("SERVER=LAPTOP-PDQV3R54\\SQLEXPRESS; Database=RentACar;  Integrated Security=True;");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        private void modelekle_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT AracModel FROM AracModel ORDER BY AracModel ASC", baglanti);
            sorgu.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sorgu);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["AracModel"].ToString());
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             baglanti.Open();
            SqlCommand ekle = new SqlCommand();
            ekle.Connection = baglanti;
            ekle.CommandText = "INSERT INTO AracModel(AracMdodel)VALUES(@AracMdodel)";
            ekle.Parameters.AddWithValue("@UretimYili",comboBox1.Text);
            ekle.ExecuteNonQuery();
        DialogResult cevap= MessageBox.Show("Ekleme işlemi başarılı.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        if (cevap == DialogResult.OK)
        {
            ayarlar ayar = new ayarlar();
            this.Hide();
            ayar.Show();
        }
            
       //     comboBox1.Items.Clear();
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "DELETE FROM AracModel WHERE AracModel = '" + comboBox1.SelectedItem + "'";
            komut.ExecuteNonQuery();
            komut.Dispose();
            MessageBox.Show("Silme işlemi başarılı..");
            comboBox1.Refresh();
            
            baglanti.Close();
        }

        }
    }

