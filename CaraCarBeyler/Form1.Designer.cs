namespace CaraCarBeyler
{
    partial class Form1
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
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.sifreonay = new System.Windows.Forms.Button();
            this.soruonay = new System.Windows.Forms.Button();
            this.sifreyeni = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cevabi = new System.Windows.Forms.TextBox();
            this.soru = new System.Windows.Forms.TextBox();
            this.sifrekurtarmakadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.txtkullaniciadi.Location = new System.Drawing.Point(167, 31);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(210, 27);
            this.txtkullaniciadi.TabIndex = 0;
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.txtsifre.Location = new System.Drawing.Point(167, 77);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(210, 27);
            this.txtsifre.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtkullaniciadi);
            this.groupBox1.Controls.Add(this.txtsifre);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 198);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Girişi";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.linkLabel1.Location = new System.Drawing.Point(6, 175);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(148, 20);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum..";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.button1.Location = new System.Drawing.Point(279, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 38F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 83);
            this.label3.TabIndex = 4;
            this.label3.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(265, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 82);
            this.label4.TabIndex = 4;
            this.label4.Text = "CAR";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::CaraCarBeyler.Properties.Resources.no_parking;
            this.pictureBox2.Location = new System.Drawing.Point(596, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::CaraCarBeyler.Properties.Resources.rent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.sifreonay);
            this.panel1.Controls.Add(this.soruonay);
            this.panel1.Controls.Add(this.sifreyeni);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cevabi);
            this.panel1.Controls.Add(this.soru);
            this.panel1.Controls.Add(this.sifrekurtarmakadi);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 322);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::CaraCarBeyler.Properties.Resources.no_parking;
            this.pictureBox3.Location = new System.Drawing.Point(573, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // sifreonay
            // 
            this.sifreonay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sifreonay.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.sifreonay.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.sifreonay.Location = new System.Drawing.Point(324, 204);
            this.sifreonay.Name = "sifreonay";
            this.sifreonay.Size = new System.Drawing.Size(100, 39);
            this.sifreonay.TabIndex = 11;
            this.sifreonay.Text = "Onay";
            this.sifreonay.UseVisualStyleBackColor = false;
            this.sifreonay.Click += new System.EventHandler(this.sifreonay_Click);
            // 
            // soruonay
            // 
            this.soruonay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.soruonay.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.soruonay.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.soruonay.Location = new System.Drawing.Point(324, 103);
            this.soruonay.Name = "soruonay";
            this.soruonay.Size = new System.Drawing.Size(100, 39);
            this.soruonay.TabIndex = 10;
            this.soruonay.Text = "Onay";
            this.soruonay.UseVisualStyleBackColor = false;
            this.soruonay.Click += new System.EventHandler(this.soruonay_Click);
            // 
            // sifreyeni
            // 
            this.sifreyeni.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.sifreyeni.Location = new System.Drawing.Point(151, 161);
            this.sifreyeni.Name = "sifreyeni";
            this.sifreyeni.PasswordChar = '*';
            this.sifreyeni.Size = new System.Drawing.Size(167, 27);
            this.sifreyeni.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label9.Location = new System.Drawing.Point(22, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Yeni Şifre:";
            // 
            // cevabi
            // 
            this.cevabi.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.cevabi.Location = new System.Drawing.Point(151, 95);
            this.cevabi.Name = "cevabi";
            this.cevabi.Size = new System.Drawing.Size(167, 27);
            this.cevabi.TabIndex = 5;
            this.cevabi.TextChanged += new System.EventHandler(this.cevabi_TextChanged);
            // 
            // soru
            // 
            this.soru.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.soru.Location = new System.Drawing.Point(151, 55);
            this.soru.Name = "soru";
            this.soru.Size = new System.Drawing.Size(167, 27);
            this.soru.TabIndex = 4;
            this.soru.TextChanged += new System.EventHandler(this.soru_TextChanged);
            // 
            // sifrekurtarmakadi
            // 
            this.sifrekurtarmakadi.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.sifrekurtarmakadi.Location = new System.Drawing.Point(151, 14);
            this.sifrekurtarmakadi.Name = "sifrekurtarmakadi";
            this.sifrekurtarmakadi.Size = new System.Drawing.Size(167, 27);
            this.sifrekurtarmakadi.TabIndex = 3;
            this.sifrekurtarmakadi.TextChanged += new System.EventHandler(this.sifrekurtarmakadi_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label7.Location = new System.Drawing.Point(22, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Onay:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label6.Location = new System.Drawing.Point(22, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cevap:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label5.Location = new System.Drawing.Point(22, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kullanıcı Adı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(677, 328);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cevabi;
        private System.Windows.Forms.TextBox soru;
        private System.Windows.Forms.TextBox sifrekurtarmakadi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sifreonay;
        private System.Windows.Forms.Button soruonay;
        private System.Windows.Forms.TextBox sifreyeni;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox3;

    }
}

