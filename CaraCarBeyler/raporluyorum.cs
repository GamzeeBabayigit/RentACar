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
using Microsoft.Reporting.WinForms;

namespace CaraCarBeyler
{
    public partial class raporluyorum : Form
    {
        public raporluyorum()
        {
            InitializeComponent();
        }

        
        SqlConnection baglanti = new SqlConnection("SERVER=LAPTOP-PDQV3R54\\SQLEXPRESS; Database=RentACar;  Integrated Security=True;");
        BindingSource bs = new BindingSource();

        void musteriada()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM OdenenDeneme WHERE Musteri_Adi like '%" + textBox1.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "OdenenDeneme");

            ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["OdenenDeneme"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

        }
        void aracplaka()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM OdenenDeneme WHERE AracPlaka like '%" + textBox2.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "OdenenDeneme");

            ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["OdenenDeneme"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
        private void raporluyorum_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RentACarDataSet1.OdenenDeneme' table. You can move, or remove it, as needed.
            this.OdenenDenemeTableAdapter.Fill(this.RentACarDataSet1.OdenenDeneme);
            // TODO: This line of code loads data into the 'RentACarDataSet.OdenenDeneme' table. You can move, or remove it, as needed.
          //  this.OdenenDenemeTableAdapter.Fill(this.RentACarDataSet.OdenenDeneme);

            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            musteriada();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            aracplaka();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM OdenenDeneme WHERE GecKalmaSuresi = 0 ", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "OdenenDeneme");

            ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["OdenenDeneme"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlDataAdapter daa = new SqlDataAdapter("SELECT DISTINCT * FROM OdenenDeneme WHERE GecKalmaSuresi > 0 ", baglanti);
            DataSet data = new DataSet();
            daa.Fill(data, "OdenenDeneme");

            ReportDataSource rda = new ReportDataSource("DataSet1", data.Tables["OdenenDeneme"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rda);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        
    }
}
