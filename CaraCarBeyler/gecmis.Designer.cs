namespace CaraCarBeyler
{
    partial class gecmis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtplakaya = new System.Windows.Forms.TextBox();
            this.islemiptal = new System.Windows.Forms.Button();
            this.odemeYap = new System.Windows.Forms.Button();
            this.txtada = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.gamze = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.adres = new System.Windows.Forms.Label();
            this.TC = new System.Windows.Forms.Label();
            this.Telefon = new System.Windows.Forms.Label();
            this.Soyadi = new System.Windows.Forms.Label();
            this.Adi = new System.Windows.Forms.Label();
            this.GecKalmaSuresi = new System.Windows.Forms.Label();
            this.AracKiraTutar = new System.Windows.Forms.Label();
            this.AracKacGunKira = new System.Windows.Forms.Label();
            this.AracTutarBirim = new System.Windows.Forms.Label();
            this.AracTeslim = new System.Windows.Forms.Label();
            this.AracKiraTarihi = new System.Windows.Forms.Label();
            this.AracGorsel = new System.Windows.Forms.Label();
            this.AracDurum = new System.Windows.Forms.Label();
            this.AracUcret = new System.Windows.Forms.Label();
            this.AracKm = new System.Windows.Forms.Label();
            this.AracYakitTuru = new System.Windows.Forms.Label();
            this.AracKasaTipi = new System.Windows.Forms.Label();
            this.AracPlaka = new System.Windows.Forms.Label();
            this.AracRenk = new System.Windows.Forms.Label();
            this.AracUretimYili = new System.Windows.Forms.Label();
            this.AracModel = new System.Windows.Forms.Label();
            this.AracMarka = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtplakaya);
            this.groupBox1.Controls.Add(this.islemiptal);
            this.groupBox1.Controls.Add(this.odemeYap);
            this.groupBox1.Controls.Add(this.txtada);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(66, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1941, 921);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(275, 891);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(480, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "**Araç Girilen Teslim Tarihinden Sonra Teslim Edilirse *2 İle Ücretlendirilir...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Araç Plakasına Göre Ara :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Müşteri Adına Göre Ara : ";
            // 
            // txtplakaya
            // 
            this.txtplakaya.Location = new System.Drawing.Point(278, 83);
            this.txtplakaya.Name = "txtplakaya";
            this.txtplakaya.Size = new System.Drawing.Size(1568, 22);
            this.txtplakaya.TabIndex = 32;
            this.txtplakaya.TextChanged += new System.EventHandler(this.txtplakaya_TextChanged);
            // 
            // islemiptal
            // 
            this.islemiptal.BackColor = System.Drawing.Color.Red;
            this.islemiptal.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.islemiptal.Location = new System.Drawing.Point(604, 803);
            this.islemiptal.Name = "islemiptal";
            this.islemiptal.Size = new System.Drawing.Size(151, 63);
            this.islemiptal.TabIndex = 31;
            this.islemiptal.Text = "İşlemi İptal Et";
            this.islemiptal.UseVisualStyleBackColor = false;
            this.islemiptal.Click += new System.EventHandler(this.islemiptal_Click);
            // 
            // odemeYap
            // 
            this.odemeYap.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.odemeYap.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.odemeYap.Location = new System.Drawing.Point(278, 803);
            this.odemeYap.Name = "odemeYap";
            this.odemeYap.Size = new System.Drawing.Size(151, 63);
            this.odemeYap.TabIndex = 30;
            this.odemeYap.Text = "Ödeme Yap";
            this.odemeYap.UseVisualStyleBackColor = false;
            this.odemeYap.Click += new System.EventHandler(this.odemeYap_Click);
            // 
            // txtada
            // 
            this.txtada.Location = new System.Drawing.Point(278, 35);
            this.txtada.Name = "txtada";
            this.txtada.Size = new System.Drawing.Size(1568, 22);
            this.txtada.TabIndex = 29;
            this.txtada.TextChanged += new System.EventHandler(this.txtada_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1568, 587);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-3, 978);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 22);
            this.textBox1.TabIndex = 69;
            this.textBox1.Text = "0";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(26, 998);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(10, 22);
            this.dateTimePicker2.TabIndex = 68;
            // 
            // gamze
            // 
            this.gamze.AutoSize = true;
            this.gamze.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gamze.Location = new System.Drawing.Point(29, 983);
            this.gamze.Name = "gamze";
            this.gamze.Size = new System.Drawing.Size(6, 2);
            this.gamze.TabIndex = 67;
            this.gamze.Text = "label4";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 970);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(10, 22);
            this.dateTimePicker1.TabIndex = 66;
            // 
            // adres
            // 
            this.adres.AutoSize = true;
            this.adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adres.Location = new System.Drawing.Point(3, 936);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(7, 2);
            this.adres.TabIndex = 65;
            this.adres.Text = "label30";
            // 
            // TC
            // 
            this.TC.AutoSize = true;
            this.TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TC.Location = new System.Drawing.Point(29, 936);
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(7, 2);
            this.TC.TabIndex = 64;
            this.TC.Text = "label30";
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Telefon.Location = new System.Drawing.Point(29, 918);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(7, 2);
            this.Telefon.TabIndex = 63;
            this.Telefon.Text = "label29";
            // 
            // Soyadi
            // 
            this.Soyadi.AutoSize = true;
            this.Soyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Soyadi.Location = new System.Drawing.Point(3, 912);
            this.Soyadi.Name = "Soyadi";
            this.Soyadi.Size = new System.Drawing.Size(7, 2);
            this.Soyadi.TabIndex = 62;
            this.Soyadi.Text = "label28";
            // 
            // Adi
            // 
            this.Adi.AutoSize = true;
            this.Adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Adi.Location = new System.Drawing.Point(3, 894);
            this.Adi.Name = "Adi";
            this.Adi.Size = new System.Drawing.Size(7, 2);
            this.Adi.TabIndex = 61;
            this.Adi.Text = "label27";
            // 
            // GecKalmaSuresi
            // 
            this.GecKalmaSuresi.AutoSize = true;
            this.GecKalmaSuresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GecKalmaSuresi.Location = new System.Drawing.Point(29, 946);
            this.GecKalmaSuresi.Name = "GecKalmaSuresi";
            this.GecKalmaSuresi.Size = new System.Drawing.Size(3, 2);
            this.GecKalmaSuresi.TabIndex = 60;
            this.GecKalmaSuresi.Text = "0";
            // 
            // AracKiraTutar
            // 
            this.AracKiraTutar.AutoSize = true;
            this.AracKiraTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracKiraTutar.Location = new System.Drawing.Point(29, 940);
            this.AracKiraTutar.Name = "AracKiraTutar";
            this.AracKiraTutar.Size = new System.Drawing.Size(7, 2);
            this.AracKiraTutar.TabIndex = 59;
            this.AracKiraTutar.Text = "label25";
            // 
            // AracKacGunKira
            // 
            this.AracKacGunKira.AutoSize = true;
            this.AracKacGunKira.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracKacGunKira.Location = new System.Drawing.Point(29, 913);
            this.AracKacGunKira.Name = "AracKacGunKira";
            this.AracKacGunKira.Size = new System.Drawing.Size(7, 2);
            this.AracKacGunKira.TabIndex = 58;
            this.AracKacGunKira.Text = "label24";
            // 
            // AracTutarBirim
            // 
            this.AracTutarBirim.AutoSize = true;
            this.AracTutarBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracTutarBirim.Location = new System.Drawing.Point(29, 906);
            this.AracTutarBirim.Name = "AracTutarBirim";
            this.AracTutarBirim.Size = new System.Drawing.Size(7, 2);
            this.AracTutarBirim.TabIndex = 57;
            this.AracTutarBirim.Text = "label23";
            // 
            // AracTeslim
            // 
            this.AracTeslim.AutoSize = true;
            this.AracTeslim.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracTeslim.Location = new System.Drawing.Point(29, 893);
            this.AracTeslim.Name = "AracTeslim";
            this.AracTeslim.Size = new System.Drawing.Size(7, 2);
            this.AracTeslim.TabIndex = 56;
            this.AracTeslim.Text = "label22";
            // 
            // AracKiraTarihi
            // 
            this.AracKiraTarihi.AutoSize = true;
            this.AracKiraTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracKiraTarihi.Location = new System.Drawing.Point(29, 930);
            this.AracKiraTarihi.Name = "AracKiraTarihi";
            this.AracKiraTarihi.Size = new System.Drawing.Size(7, 2);
            this.AracKiraTarihi.TabIndex = 55;
            this.AracKiraTarihi.Text = "label21";
            // 
            // AracGorsel
            // 
            this.AracGorsel.AutoSize = true;
            this.AracGorsel.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracGorsel.Location = new System.Drawing.Point(29, 924);
            this.AracGorsel.Name = "AracGorsel";
            this.AracGorsel.Size = new System.Drawing.Size(7, 2);
            this.AracGorsel.TabIndex = 54;
            this.AracGorsel.Text = "label20";
            // 
            // AracDurum
            // 
            this.AracDurum.AutoSize = true;
            this.AracDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracDurum.Location = new System.Drawing.Point(3, 949);
            this.AracDurum.Name = "AracDurum";
            this.AracDurum.Size = new System.Drawing.Size(7, 2);
            this.AracDurum.TabIndex = 53;
            this.AracDurum.Text = "label19";
            // 
            // AracUcret
            // 
            this.AracUcret.AutoSize = true;
            this.AracUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracUcret.Location = new System.Drawing.Point(3, 924);
            this.AracUcret.Name = "AracUcret";
            this.AracUcret.Size = new System.Drawing.Size(7, 2);
            this.AracUcret.TabIndex = 52;
            this.AracUcret.Text = "label18";
            // 
            // AracKm
            // 
            this.AracKm.AutoSize = true;
            this.AracKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracKm.Location = new System.Drawing.Point(5, 918);
            this.AracKm.Name = "AracKm";
            this.AracKm.Size = new System.Drawing.Size(7, 2);
            this.AracKm.TabIndex = 51;
            this.AracKm.Text = "label17";
            // 
            // AracYakitTuru
            // 
            this.AracYakitTuru.AutoSize = true;
            this.AracYakitTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracYakitTuru.Location = new System.Drawing.Point(3, 906);
            this.AracYakitTuru.Name = "AracYakitTuru";
            this.AracYakitTuru.Size = new System.Drawing.Size(7, 2);
            this.AracYakitTuru.TabIndex = 50;
            this.AracYakitTuru.Text = "label16";
            // 
            // AracKasaTipi
            // 
            this.AracKasaTipi.AutoSize = true;
            this.AracKasaTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracKasaTipi.Location = new System.Drawing.Point(3, 900);
            this.AracKasaTipi.Name = "AracKasaTipi";
            this.AracKasaTipi.Size = new System.Drawing.Size(7, 2);
            this.AracKasaTipi.TabIndex = 49;
            this.AracKasaTipi.Text = "label15";
            // 
            // AracPlaka
            // 
            this.AracPlaka.AutoSize = true;
            this.AracPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracPlaka.Location = new System.Drawing.Point(3, 926);
            this.AracPlaka.Name = "AracPlaka";
            this.AracPlaka.Size = new System.Drawing.Size(7, 2);
            this.AracPlaka.TabIndex = 48;
            this.AracPlaka.Text = "label14";
            // 
            // AracRenk
            // 
            this.AracRenk.AutoSize = true;
            this.AracRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracRenk.Location = new System.Drawing.Point(3, 893);
            this.AracRenk.Name = "AracRenk";
            this.AracRenk.Size = new System.Drawing.Size(7, 2);
            this.AracRenk.TabIndex = 47;
            this.AracRenk.Text = "label13";
            // 
            // AracUretimYili
            // 
            this.AracUretimYili.AutoSize = true;
            this.AracUretimYili.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracUretimYili.Location = new System.Drawing.Point(29, 900);
            this.AracUretimYili.Name = "AracUretimYili";
            this.AracUretimYili.Size = new System.Drawing.Size(7, 2);
            this.AracUretimYili.TabIndex = 46;
            this.AracUretimYili.Text = "label12";
            // 
            // AracModel
            // 
            this.AracModel.AutoSize = true;
            this.AracModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracModel.Location = new System.Drawing.Point(3, 943);
            this.AracModel.Name = "AracModel";
            this.AracModel.Size = new System.Drawing.Size(7, 2);
            this.AracModel.TabIndex = 45;
            this.AracModel.Text = "label11";
            // 
            // AracMarka
            // 
            this.AracMarka.AutoSize = true;
            this.AracMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracMarka.Location = new System.Drawing.Point(3, 930);
            this.AracMarka.Name = "AracMarka";
            this.AracMarka.Size = new System.Drawing.Size(7, 2);
            this.AracMarka.TabIndex = 44;
            this.AracMarka.Text = "label10";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 962);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(10, 10);
            this.dataGridView2.TabIndex = 29;
            // 
            // gecmis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::CaraCarBeyler.Properties.Resources.desen_motif_01581;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gamze);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.AracMarka);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.AracModel);
            this.Controls.Add(this.TC);
            this.Controls.Add(this.AracUretimYili);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.AracRenk);
            this.Controls.Add(this.Soyadi);
            this.Controls.Add(this.AracPlaka);
            this.Controls.Add(this.Adi);
            this.Controls.Add(this.AracKasaTipi);
            this.Controls.Add(this.GecKalmaSuresi);
            this.Controls.Add(this.AracYakitTuru);
            this.Controls.Add(this.AracKiraTutar);
            this.Controls.Add(this.AracKm);
            this.Controls.Add(this.AracKacGunKira);
            this.Controls.Add(this.AracUcret);
            this.Controls.Add(this.AracTutarBirim);
            this.Controls.Add(this.AracDurum);
            this.Controls.Add(this.AracTeslim);
            this.Controls.Add(this.AracGorsel);
            this.Controls.Add(this.AracKiraTarihi);
            this.Name = "gecmis";
            this.Text = "Ödeme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.gecmis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtplakaya;
        private System.Windows.Forms.Button islemiptal;
        private System.Windows.Forms.Button odemeYap;
        private System.Windows.Forms.TextBox txtada;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TC;
        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.Label Soyadi;
        private System.Windows.Forms.Label Adi;
        private System.Windows.Forms.Label GecKalmaSuresi;
        private System.Windows.Forms.Label AracKiraTutar;
        private System.Windows.Forms.Label AracKacGunKira;
        private System.Windows.Forms.Label AracTutarBirim;
        private System.Windows.Forms.Label AracTeslim;
        private System.Windows.Forms.Label AracKiraTarihi;
        private System.Windows.Forms.Label AracGorsel;
        private System.Windows.Forms.Label AracDurum;
        private System.Windows.Forms.Label AracUcret;
        private System.Windows.Forms.Label AracKm;
        private System.Windows.Forms.Label AracYakitTuru;
        private System.Windows.Forms.Label AracKasaTipi;
        private System.Windows.Forms.Label AracPlaka;
        private System.Windows.Forms.Label AracRenk;
        private System.Windows.Forms.Label AracUretimYili;
        private System.Windows.Forms.Label AracModel;
        private System.Windows.Forms.Label AracMarka;
        private System.Windows.Forms.Label adres;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label gamze;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox1;

    }
}