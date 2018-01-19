namespace WindowsFormsApp4
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
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmnAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDYili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUcret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnIndirimliUcret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnYas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.dateDogumTarihi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(76, 11);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 0;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(282, 57);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(100, 20);
            this.txtUcret.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doğum Yılı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ücret";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(282, 10);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(100, 21);
            this.cmbCinsiyet.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnAdi,
            this.clmnDYili,
            this.clmnCinsiyet,
            this.clmnUcret,
            this.clmnIndirimliUcret,
            this.clmnYas});
            this.dataGridView1.Location = new System.Drawing.Point(13, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // clmnAdi
            // 
            this.clmnAdi.HeaderText = "Adı";
            this.clmnAdi.Name = "clmnAdi";
            this.clmnAdi.ReadOnly = true;
            // 
            // clmnDYili
            // 
            this.clmnDYili.HeaderText = "Doğum Yılı";
            this.clmnDYili.Name = "clmnDYili";
            this.clmnDYili.ReadOnly = true;
            this.clmnDYili.Width = 50;
            // 
            // clmnCinsiyet
            // 
            this.clmnCinsiyet.HeaderText = "Cinsiyet";
            this.clmnCinsiyet.Name = "clmnCinsiyet";
            this.clmnCinsiyet.ReadOnly = true;
            this.clmnCinsiyet.Width = 50;
            // 
            // clmnUcret
            // 
            this.clmnUcret.HeaderText = "Ücret";
            this.clmnUcret.Name = "clmnUcret";
            this.clmnUcret.ReadOnly = true;
            // 
            // clmnIndirimliUcret
            // 
            this.clmnIndirimliUcret.HeaderText = "İndirimli Ücret";
            this.clmnIndirimliUcret.Name = "clmnIndirimliUcret";
            this.clmnIndirimliUcret.ReadOnly = true;
            // 
            // clmnYas
            // 
            this.clmnYas.HeaderText = "Yaşı";
            this.clmnYas.Name = "clmnYas";
            this.clmnYas.ReadOnly = true;
            this.clmnYas.Width = 50;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(441, 53);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Hasta Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(441, 13);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 11;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(472, 107);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(10, 13);
            this.lblToplam.TabIndex = 12;
            this.lblToplam.Text = "-";
            // 
            // dateDogumTarihi
            // 
            this.dateDogumTarihi.Location = new System.Drawing.Point(72, 57);
            this.dateDogumTarihi.Name = "dateDogumTarihi";
            this.dateDogumTarihi.Size = new System.Drawing.Size(161, 20);
            this.dateDogumTarihi.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 333);
            this.Controls.Add(this.dateDogumTarihi);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.txtAdi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDYili;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnUcret;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnIndirimliUcret;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnYas;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.DateTimePicker dateDogumTarihi;
    }
}

