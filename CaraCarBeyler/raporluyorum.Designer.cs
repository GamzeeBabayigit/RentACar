namespace CaraCarBeyler
{
    partial class raporluyorum
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.OdenenDenemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RentACarDataSet1 = new CaraCarBeyler.RentACarDataSet1();
            this.KiralananDenemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RentACarDataSet = new CaraCarBeyler.RentACarDataSet();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.KiralananDenemeTableAdapter = new CaraCarBeyler.RentACarDataSetTableAdapters.KiralananDenemeTableAdapter();
            this.OdenenDenemeTableAdapter = new CaraCarBeyler.RentACarDataSet1TableAdapters.OdenenDenemeTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.OdenenDenemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentACarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KiralananDenemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentACarDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OdenenDenemeBindingSource
            // 
            this.OdenenDenemeBindingSource.DataMember = "OdenenDeneme";
            this.OdenenDenemeBindingSource.DataSource = this.RentACarDataSet1;
            // 
            // RentACarDataSet1
            // 
            this.RentACarDataSet1.DataSetName = "RentACarDataSet1";
            this.RentACarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KiralananDenemeBindingSource
            // 
            this.KiralananDenemeBindingSource.DataMember = "KiralananDeneme";
            this.KiralananDenemeBindingSource.DataSource = this.RentACarDataSet;
            // 
            // RentACarDataSet
            // 
            this.RentACarDataSet.DataSetName = "RentACarDataSet";
            this.RentACarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.linkLabel1.Location = new System.Drawing.Point(15, 156);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(244, 20);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ücreti Zamanında Getirenler :";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label2.Location = new System.Drawing.Point(15, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Araç Plakaya Göre Raporla : ";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.textBox2.Location = new System.Drawing.Point(316, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1675, 27);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Müşteri Adına Göre Raporla : ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.textBox1.Location = new System.Drawing.Point(316, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1675, 27);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.linkLabel2.Location = new System.Drawing.Point(15, 205);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(279, 20);
            this.linkLabel2.TabIndex = 15;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Ücreti Zamanında Getirmeyenler :";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // KiralananDenemeTableAdapter
            // 
            this.KiralananDenemeTableAdapter.ClearBeforeFill = true;
            // 
            // OdenenDenemeTableAdapter
            // 
            this.OdenenDenemeTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(49, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1962, 633);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OdenenDenemeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CaraCarBeyler.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 21);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1938, 589);
            this.reportViewer1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(49, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1962, 278);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // raporluyorum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 961);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "raporluyorum";
            this.Text = "Raporlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.raporluyorum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OdenenDenemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentACarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KiralananDenemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentACarDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.BindingSource KiralananDenemeBindingSource;
        private RentACarDataSet RentACarDataSet;
        private RentACarDataSetTableAdapters.KiralananDenemeTableAdapter KiralananDenemeTableAdapter;
        private System.Windows.Forms.BindingSource OdenenDenemeBindingSource;
        private RentACarDataSet1 RentACarDataSet1;
        private RentACarDataSet1TableAdapters.OdenenDenemeTableAdapter OdenenDenemeTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}