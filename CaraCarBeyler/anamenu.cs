using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaraCarBeyler
{
    public partial class anamenu : Form
    {
        public anamenu()
        {
            InitializeComponent();
        }

        private void anamenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ayarlar ayarlarimiz = new ayarlar();
        //    this.Hide();
            ayarlarimiz.Show();
           
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gecmis gecmisimiz = new gecmis();
          //  this.Hide();
            gecmisimiz.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            islemler islemlerimiz = new islemler();
      //      this.Hide();
            islemlerimiz.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            raporluyorum raporla = new raporluyorum();
      //     this.Hide();
            raporla.ShowDialog();
        }
    }
}
