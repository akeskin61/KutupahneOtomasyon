namespace Kutuphane_Otomasyonu
{
    partial class FormKitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Barkod = new System.Windows.Forms.TextBox();
            this.txt_KitapAdi = new System.Windows.Forms.TextBox();
            this.txt_KitapYazari = new System.Windows.Forms.TextBox();
            this.txt_BasimYili = new System.Windows.Forms.TextBox();
            this.txt_SayfaSayisi = new System.Windows.Forms.TextBox();
            this.txt_StokSayisi = new System.Windows.Forms.TextBox();
            this.cmb_YayinEvi = new System.Windows.Forms.ComboBox();
            this.cmb_KitapTuru = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dt_KitapListe = new System.Windows.Forms.DataGridView();
            this.kitapId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYayinEvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapStok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapSayfa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapBasimYili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmb_Arama = new System.Windows.Forms.ComboBox();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_KitapListe)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Yazarı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yayın Evi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Barkod No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kitap Türü :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stok Sayısı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sayfa Sayısı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Basım Yılı :";
            // 
            // txt_Barkod
            // 
            this.txt_Barkod.Location = new System.Drawing.Point(110, 31);
            this.txt_Barkod.Name = "txt_Barkod";
            this.txt_Barkod.Size = new System.Drawing.Size(160, 21);
            this.txt_Barkod.TabIndex = 8;
            // 
            // txt_KitapAdi
            // 
            this.txt_KitapAdi.Location = new System.Drawing.Point(110, 67);
            this.txt_KitapAdi.Name = "txt_KitapAdi";
            this.txt_KitapAdi.Size = new System.Drawing.Size(160, 21);
            this.txt_KitapAdi.TabIndex = 9;
            // 
            // txt_KitapYazari
            // 
            this.txt_KitapYazari.Location = new System.Drawing.Point(110, 102);
            this.txt_KitapYazari.Name = "txt_KitapYazari";
            this.txt_KitapYazari.Size = new System.Drawing.Size(160, 21);
            this.txt_KitapYazari.TabIndex = 10;
            // 
            // txt_BasimYili
            // 
            this.txt_BasimYili.Location = new System.Drawing.Point(395, 137);
            this.txt_BasimYili.Name = "txt_BasimYili";
            this.txt_BasimYili.Size = new System.Drawing.Size(161, 21);
            this.txt_BasimYili.TabIndex = 15;
            // 
            // txt_SayfaSayisi
            // 
            this.txt_SayfaSayisi.Location = new System.Drawing.Point(395, 67);
            this.txt_SayfaSayisi.Name = "txt_SayfaSayisi";
            this.txt_SayfaSayisi.Size = new System.Drawing.Size(161, 21);
            this.txt_SayfaSayisi.TabIndex = 13;
            // 
            // txt_StokSayisi
            // 
            this.txt_StokSayisi.Location = new System.Drawing.Point(395, 31);
            this.txt_StokSayisi.Name = "txt_StokSayisi";
            this.txt_StokSayisi.Size = new System.Drawing.Size(161, 21);
            this.txt_StokSayisi.TabIndex = 12;
            // 
            // cmb_YayinEvi
            // 
            this.cmb_YayinEvi.FormattingEnabled = true;
            this.cmb_YayinEvi.Location = new System.Drawing.Point(110, 137);
            this.cmb_YayinEvi.Name = "cmb_YayinEvi";
            this.cmb_YayinEvi.Size = new System.Drawing.Size(160, 23);
            this.cmb_YayinEvi.TabIndex = 16;
            // 
            // cmb_KitapTuru
            // 
            this.cmb_KitapTuru.FormattingEnabled = true;
            this.cmb_KitapTuru.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Korku",
            "Çocuk",
            "Polisiye"});
            this.cmb_KitapTuru.Location = new System.Drawing.Point(396, 102);
            this.cmb_KitapTuru.Name = "cmb_KitapTuru";
            this.cmb_KitapTuru.Size = new System.Drawing.Size(160, 23);
            this.cmb_KitapTuru.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Sil);
            this.groupBox1.Controls.Add(this.btn_Guncelle);
            this.groupBox1.Controls.Add(this.btn_Ekle);
            this.groupBox1.Controls.Add(this.txt_StokSayisi);
            this.groupBox1.Controls.Add(this.cmb_KitapTuru);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_YayinEvi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_BasimYili);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_SayfaSayisi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_KitapYazari);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_KitapAdi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Barkod);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 167);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgileri";
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sil.FlatAppearance.BorderSize = 0;
            this.btn_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sil.Font = new System.Drawing.Font("Open Sans Extrabold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sil.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sil.Image")));
            this.btn_Sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sil.Location = new System.Drawing.Point(632, 77);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(84, 40);
            this.btn_Sil.TabIndex = 21;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.Transparent;
            this.btn_Guncelle.FlatAppearance.BorderSize = 0;
            this.btn_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guncelle.Font = new System.Drawing.Font("Open Sans Extrabold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guncelle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Guncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guncelle.Image")));
            this.btn_Guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guncelle.Location = new System.Drawing.Point(632, 120);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(160, 40);
            this.btn_Guncelle.TabIndex = 20;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ekle.FlatAppearance.BorderSize = 0;
            this.btn_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ekle.Font = new System.Drawing.Font("Open Sans Extrabold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ekle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Ekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.Image")));
            this.btn_Ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ekle.Location = new System.Drawing.Point(632, 31);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(104, 40);
            this.btn_Ekle.TabIndex = 19;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dt_KitapListe);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(852, 325);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Listesi";
            // 
            // dt_KitapListe
            // 
            this.dt_KitapListe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dt_KitapListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_KitapListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapId,
            this.kitapBarkod,
            this.kitapAdi,
            this.kitapYazari,
            this.kitapYayinEvi,
            this.kitapStok,
            this.kitapSayfa,
            this.kitapTuru,
            this.kitapBasimYili,
            this.kitapDurum});
            this.dt_KitapListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_KitapListe.Location = new System.Drawing.Point(3, 17);
            this.dt_KitapListe.Name = "dt_KitapListe";
            this.dt_KitapListe.ReadOnly = true;
            this.dt_KitapListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_KitapListe.Size = new System.Drawing.Size(846, 305);
            this.dt_KitapListe.TabIndex = 1;
            this.dt_KitapListe.DoubleClick += new System.EventHandler(this.dt_UyeListe_DoubleClick);
            // 
            // kitapId
            // 
            this.kitapId.DataPropertyName = "kitapId";
            this.kitapId.HeaderText = "ID";
            this.kitapId.Name = "kitapId";
            this.kitapId.ReadOnly = true;
            this.kitapId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // kitapBarkod
            // 
            this.kitapBarkod.DataPropertyName = "kitapBarkod";
            this.kitapBarkod.HeaderText = "Barkod";
            this.kitapBarkod.Name = "kitapBarkod";
            this.kitapBarkod.ReadOnly = true;
            // 
            // kitapAdi
            // 
            this.kitapAdi.DataPropertyName = "kitapAdi";
            this.kitapAdi.HeaderText = "Kitap Adı";
            this.kitapAdi.Name = "kitapAdi";
            this.kitapAdi.ReadOnly = true;
            // 
            // kitapYazari
            // 
            this.kitapYazari.DataPropertyName = "kitapYazari";
            this.kitapYazari.HeaderText = "Kitabın Yazarı";
            this.kitapYazari.Name = "kitapYazari";
            this.kitapYazari.ReadOnly = true;
            // 
            // kitapYayinEvi
            // 
            this.kitapYayinEvi.DataPropertyName = "kitapYayinEvi";
            this.kitapYayinEvi.HeaderText = "Yayın Evi";
            this.kitapYayinEvi.Name = "kitapYayinEvi";
            this.kitapYayinEvi.ReadOnly = true;
            // 
            // kitapStok
            // 
            this.kitapStok.DataPropertyName = "kitapStok";
            this.kitapStok.HeaderText = "Kitap Stok";
            this.kitapStok.Name = "kitapStok";
            this.kitapStok.ReadOnly = true;
            // 
            // kitapSayfa
            // 
            this.kitapSayfa.DataPropertyName = "kitapSayfa";
            this.kitapSayfa.HeaderText = "Kitap Sayfa";
            this.kitapSayfa.Name = "kitapSayfa";
            this.kitapSayfa.ReadOnly = true;
            // 
            // kitapTuru
            // 
            this.kitapTuru.DataPropertyName = "kitapTuru";
            this.kitapTuru.HeaderText = "Kitap Türü";
            this.kitapTuru.Name = "kitapTuru";
            this.kitapTuru.ReadOnly = true;
            // 
            // kitapBasimYili
            // 
            this.kitapBasimYili.DataPropertyName = "kitapBasimYili";
            this.kitapBasimYili.HeaderText = "Basım Yılı";
            this.kitapBasimYili.Name = "kitapBasimYili";
            this.kitapBasimYili.ReadOnly = true;
            this.kitapBasimYili.Visible = false;
            // 
            // kitapDurum
            // 
            this.kitapDurum.DataPropertyName = "kitapDurum";
            this.kitapDurum.HeaderText = "Kitap Durum";
            this.kitapDurum.Name = "kitapDurum";
            this.kitapDurum.ReadOnly = true;
            this.kitapDurum.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.cmb_Arama);
            this.groupBox3.Controls.Add(this.btn_Ara);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(0, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(852, 56);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitap Ara";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans Extrabold", 18F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(248, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 33);
            this.label9.TabIndex = 1;
            this.label9.Text = ":";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(276, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 21);
            this.textBox1.TabIndex = 24;
            // 
            // cmb_Arama
            // 
            this.cmb_Arama.FormattingEnabled = true;
            this.cmb_Arama.Items.AddRange(new object[] {
            "Barkod No",
            "Kitap Adı",
            "Kitap Yazarı",
            "Yayın Evi",
            "Sayfa Sayısı",
            "Kitap Türü"});
            this.cmb_Arama.Location = new System.Drawing.Point(35, 20);
            this.cmb_Arama.Name = "cmb_Arama";
            this.cmb_Arama.Size = new System.Drawing.Size(204, 23);
            this.cmb_Arama.TabIndex = 23;
            this.cmb_Arama.Text = "Arama Kriterini Seçiniz";
            // 
            // btn_Ara
            // 
            this.btn_Ara.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ara.FlatAppearance.BorderSize = 0;
            this.btn_Ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ara.Font = new System.Drawing.Font("Open Sans Extrabold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ara.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Ara.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ara.Image")));
            this.btn_Ara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ara.Location = new System.Drawing.Point(541, 10);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(108, 40);
            this.btn_Ara.TabIndex = 22;
            this.btn_Ara.Text = "Ara";
            this.btn_Ara.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Ara.UseVisualStyleBackColor = false;
            this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click);
            // 
            // FormKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(852, 554);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormKitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap İşlemleri";
            this.Load += new System.EventHandler(this.FormKitap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_KitapListe)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Barkod;
        private System.Windows.Forms.TextBox txt_KitapAdi;
        private System.Windows.Forms.TextBox txt_KitapYazari;
        private System.Windows.Forms.TextBox txt_BasimYili;
        private System.Windows.Forms.TextBox txt_SayfaSayisi;
        private System.Windows.Forms.TextBox txt_StokSayisi;
        private System.Windows.Forms.ComboBox cmb_YayinEvi;
        private System.Windows.Forms.ComboBox cmb_KitapTuru;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Ara;
        private System.Windows.Forms.ComboBox cmb_Arama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dt_KitapListe;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapId;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazari;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYayinEvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapSayfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapBasimYili;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapDurum;
    }
}