namespace Kutuphane_Otomasyonu
{
    partial class FormOdunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOdunc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_KitapYenile = new System.Windows.Forms.Button();
            this.btn_KitapEkle = new System.Windows.Forms.Button();
            this.dt_KitapListe = new System.Windows.Forms.DataGridView();
            this.kitapId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYayinEvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapStok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapSayfa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapBasimYili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_KitapAra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_UyeYenile = new System.Windows.Forms.Button();
            this.btn_UyeEkle = new System.Windows.Forms.Button();
            this.dt_UyeListe = new System.Windows.Forms.DataGridView();
            this.uyeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeTc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeIsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeSoyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeKayitTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_UyeAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.GroupBox();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.dtp_TeslimTarih = new System.Windows.Forms.DateTimePicker();
            this.dtp_VerisTarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SureyiUzat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TeslimAl = new System.Windows.Forms.Button();
            this.txt_Aciklama = new System.Windows.Forms.RichTextBox();
            this.btn_OduncVer = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dt_OduncListe = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oduncATarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oduncVTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oduncDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oduncAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Kitap = new System.Windows.Forms.Label();
            this.lbl_Uye = new System.Windows.Forms.Label();
            this.lbl_Tc = new System.Windows.Forms.Label();
            this.lbl_Barkod = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_KitapListe)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_UyeListe)).BeginInit();
            this.group.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_OduncListe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_KitapYenile);
            this.groupBox1.Controls.Add(this.btn_KitapEkle);
            this.groupBox1.Controls.Add(this.dt_KitapListe);
            this.groupBox1.Controls.Add(this.txt_KitapAra);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(5, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgileri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Kitap Adı :";
            // 
            // btn_KitapYenile
            // 
            this.btn_KitapYenile.FlatAppearance.BorderSize = 0;
            this.btn_KitapYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KitapYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KitapYenile.Image = ((System.Drawing.Image)(resources.GetObject("btn_KitapYenile.Image")));
            this.btn_KitapYenile.Location = new System.Drawing.Point(494, 10);
            this.btn_KitapYenile.Name = "btn_KitapYenile";
            this.btn_KitapYenile.Size = new System.Drawing.Size(43, 43);
            this.btn_KitapYenile.TabIndex = 39;
            this.btn_KitapYenile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_KitapYenile.UseVisualStyleBackColor = true;
            this.btn_KitapYenile.Click += new System.EventHandler(this.btn_KitapYenile_Click);
            // 
            // btn_KitapEkle
            // 
            this.btn_KitapEkle.FlatAppearance.BorderSize = 0;
            this.btn_KitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KitapEkle.Image = ((System.Drawing.Image)(resources.GetObject("btn_KitapEkle.Image")));
            this.btn_KitapEkle.Location = new System.Drawing.Point(448, 10);
            this.btn_KitapEkle.Name = "btn_KitapEkle";
            this.btn_KitapEkle.Size = new System.Drawing.Size(43, 43);
            this.btn_KitapEkle.TabIndex = 38;
            this.btn_KitapEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_KitapEkle.UseVisualStyleBackColor = true;
            this.btn_KitapEkle.Click += new System.EventHandler(this.btn_KitapEkle_Click);
            // 
            // dt_KitapListe
            // 
            this.dt_KitapListe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dt_KitapListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_KitapListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapId,
            this.kitapAdi,
            this.kitapYazari,
            this.kitapYayinEvi,
            this.kitapStok,
            this.kitapSayfa,
            this.kitapTuru,
            this.kitapBasimYili,
            this.kitapDurum,
            this.kitapBarkod});
            this.dt_KitapListe.Location = new System.Drawing.Point(0, 56);
            this.dt_KitapListe.Name = "dt_KitapListe";
            this.dt_KitapListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_KitapListe.Size = new System.Drawing.Size(543, 205);
            this.dt_KitapListe.TabIndex = 29;
            this.dt_KitapListe.DoubleClick += new System.EventHandler(this.dt_KitapListe_DoubleClick);
            // 
            // kitapId
            // 
            this.kitapId.DataPropertyName = "kitapId";
            this.kitapId.HeaderText = "Kitap Id";
            this.kitapId.Name = "kitapId";
            this.kitapId.Visible = false;
            // 
            // kitapAdi
            // 
            this.kitapAdi.DataPropertyName = "kitapAdi";
            this.kitapAdi.HeaderText = "Kitap Adı";
            this.kitapAdi.Name = "kitapAdi";
            // 
            // kitapYazari
            // 
            this.kitapYazari.DataPropertyName = "kitapYazari";
            this.kitapYazari.HeaderText = "Kitabın Yazarı";
            this.kitapYazari.Name = "kitapYazari";
            // 
            // kitapYayinEvi
            // 
            this.kitapYayinEvi.DataPropertyName = "kitapYayinEvi";
            this.kitapYayinEvi.HeaderText = "Yayın Evi";
            this.kitapYayinEvi.Name = "kitapYayinEvi";
            // 
            // kitapStok
            // 
            this.kitapStok.DataPropertyName = "kitapStok";
            this.kitapStok.HeaderText = "Kitap Stok";
            this.kitapStok.Name = "kitapStok";
            // 
            // kitapSayfa
            // 
            this.kitapSayfa.DataPropertyName = "kitapSayfa";
            this.kitapSayfa.HeaderText = "Kitap Sayfa";
            this.kitapSayfa.Name = "kitapSayfa";
            this.kitapSayfa.Visible = false;
            // 
            // kitapTuru
            // 
            this.kitapTuru.DataPropertyName = "kitapTuru";
            this.kitapTuru.HeaderText = "Kitap Türü";
            this.kitapTuru.Name = "kitapTuru";
            // 
            // kitapBasimYili
            // 
            this.kitapBasimYili.DataPropertyName = "kitapBasimYili";
            this.kitapBasimYili.HeaderText = "Basım Yılı";
            this.kitapBasimYili.Name = "kitapBasimYili";
            this.kitapBasimYili.Visible = false;
            // 
            // kitapDurum
            // 
            this.kitapDurum.DataPropertyName = "kitapDurum";
            this.kitapDurum.HeaderText = "Kitap Durum";
            this.kitapDurum.Name = "kitapDurum";
            this.kitapDurum.Visible = false;
            // 
            // kitapBarkod
            // 
            this.kitapBarkod.DataPropertyName = "kitapBarkod";
            this.kitapBarkod.HeaderText = "Barkod";
            this.kitapBarkod.Name = "kitapBarkod";
            this.kitapBarkod.Visible = false;
            // 
            // txt_KitapAra
            // 
            this.txt_KitapAra.Location = new System.Drawing.Point(247, 26);
            this.txt_KitapAra.Name = "txt_KitapAra";
            this.txt_KitapAra.Size = new System.Drawing.Size(195, 21);
            this.txt_KitapAra.TabIndex = 1;
            this.txt_KitapAra.TextChanged += new System.EventHandler(this.txt_KitapAra_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans Extrabold", 18F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(219, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 33);
            this.label8.TabIndex = 26;
            this.label8.Text = ":";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn_UyeYenile);
            this.groupBox2.Controls.Add(this.btn_UyeEkle);
            this.groupBox2.Controls.Add(this.dt_UyeListe);
            this.groupBox2.Controls.Add(this.txt_UyeAra);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(563, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 262);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Üye Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Üye Tc No :";
            // 
            // btn_UyeYenile
            // 
            this.btn_UyeYenile.FlatAppearance.BorderSize = 0;
            this.btn_UyeYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UyeYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_UyeYenile.Image = ((System.Drawing.Image)(resources.GetObject("btn_UyeYenile.Image")));
            this.btn_UyeYenile.Location = new System.Drawing.Point(494, 11);
            this.btn_UyeYenile.Name = "btn_UyeYenile";
            this.btn_UyeYenile.Size = new System.Drawing.Size(43, 43);
            this.btn_UyeYenile.TabIndex = 40;
            this.btn_UyeYenile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_UyeYenile.UseVisualStyleBackColor = true;
            this.btn_UyeYenile.Click += new System.EventHandler(this.btn_UyeYenile_Click);
            // 
            // btn_UyeEkle
            // 
            this.btn_UyeEkle.FlatAppearance.BorderSize = 0;
            this.btn_UyeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UyeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_UyeEkle.Image = ((System.Drawing.Image)(resources.GetObject("btn_UyeEkle.Image")));
            this.btn_UyeEkle.Location = new System.Drawing.Point(449, 11);
            this.btn_UyeEkle.Name = "btn_UyeEkle";
            this.btn_UyeEkle.Size = new System.Drawing.Size(43, 43);
            this.btn_UyeEkle.TabIndex = 39;
            this.btn_UyeEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_UyeEkle.UseVisualStyleBackColor = true;
            this.btn_UyeEkle.Click += new System.EventHandler(this.btn_UyeEkle_Click);
            // 
            // dt_UyeListe
            // 
            this.dt_UyeListe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dt_UyeListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_UyeListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uyeId,
            this.uyeTc,
            this.uyeIsim,
            this.uyeSoyisim,
            this.uyeTel,
            this.uyeKayitTarihi,
            this.uyeEmail,
            this.uyeAdres});
            this.dt_UyeListe.Location = new System.Drawing.Point(0, 57);
            this.dt_UyeListe.Name = "dt_UyeListe";
            this.dt_UyeListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_UyeListe.Size = new System.Drawing.Size(543, 205);
            this.dt_UyeListe.TabIndex = 29;
            this.dt_UyeListe.DoubleClick += new System.EventHandler(this.dt_UyeListe_DoubleClick);
            // 
            // uyeId
            // 
            this.uyeId.DataPropertyName = "uyeId";
            this.uyeId.HeaderText = "Uye İd";
            this.uyeId.Name = "uyeId";
            this.uyeId.Visible = false;
            // 
            // uyeTc
            // 
            this.uyeTc.DataPropertyName = "uyeTc";
            this.uyeTc.HeaderText = "Tc No";
            this.uyeTc.Name = "uyeTc";
            // 
            // uyeIsim
            // 
            this.uyeIsim.DataPropertyName = "uyeIsim";
            this.uyeIsim.HeaderText = "İsim";
            this.uyeIsim.Name = "uyeIsim";
            // 
            // uyeSoyisim
            // 
            this.uyeSoyisim.DataPropertyName = "uyeSoyisim";
            this.uyeSoyisim.HeaderText = "Soy İsim";
            this.uyeSoyisim.Name = "uyeSoyisim";
            // 
            // uyeTel
            // 
            this.uyeTel.DataPropertyName = "uyeTel";
            this.uyeTel.HeaderText = "Telefon";
            this.uyeTel.Name = "uyeTel";
            // 
            // uyeKayitTarihi
            // 
            this.uyeKayitTarihi.DataPropertyName = "uyeKayitTarihi";
            this.uyeKayitTarihi.HeaderText = "Kayıt Tarihi";
            this.uyeKayitTarihi.Name = "uyeKayitTarihi";
            this.uyeKayitTarihi.Visible = false;
            // 
            // uyeEmail
            // 
            this.uyeEmail.DataPropertyName = "uyeEmail";
            this.uyeEmail.HeaderText = "Email";
            this.uyeEmail.Name = "uyeEmail";
            // 
            // uyeAdres
            // 
            this.uyeAdres.DataPropertyName = "uyeAdres";
            this.uyeAdres.HeaderText = "Üye Adres";
            this.uyeAdres.Name = "uyeAdres";
            this.uyeAdres.Visible = false;
            // 
            // txt_UyeAra
            // 
            this.txt_UyeAra.Location = new System.Drawing.Point(247, 26);
            this.txt_UyeAra.Name = "txt_UyeAra";
            this.txt_UyeAra.Size = new System.Drawing.Size(195, 21);
            this.txt_UyeAra.TabIndex = 1;
            this.txt_UyeAra.TextChanged += new System.EventHandler(this.txt_UyeAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Extrabold", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(219, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 33);
            this.label1.TabIndex = 26;
            this.label1.Text = ":";
            // 
            // group
            // 
            this.group.Controls.Add(this.btn_Temizle);
            this.group.Controls.Add(this.dtp_TeslimTarih);
            this.group.Controls.Add(this.dtp_VerisTarih);
            this.group.Controls.Add(this.label4);
            this.group.Controls.Add(this.label3);
            this.group.Controls.Add(this.btn_SureyiUzat);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.btn_TeslimAl);
            this.group.Controls.Add(this.txt_Aciklama);
            this.group.Controls.Add(this.btn_OduncVer);
            this.group.Location = new System.Drawing.Point(6, 344);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(1099, 129);
            this.group.TabIndex = 29;
            this.group.TabStop = false;
            this.group.Text = "Yapılacak İşlemler";
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.FlatAppearance.BorderSize = 0;
            this.btn_Temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Temizle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Temizle.Image")));
            this.btn_Temizle.Location = new System.Drawing.Point(332, 19);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(117, 96);
            this.btn_Temizle.TabIndex = 37;
            this.btn_Temizle.Text = "Seçim Temizle";
            this.btn_Temizle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // dtp_TeslimTarih
            // 
            this.dtp_TeslimTarih.Location = new System.Drawing.Point(594, 76);
            this.dtp_TeslimTarih.Name = "dtp_TeslimTarih";
            this.dtp_TeslimTarih.Size = new System.Drawing.Size(200, 21);
            this.dtp_TeslimTarih.TabIndex = 36;
            // 
            // dtp_VerisTarih
            // 
            this.dtp_VerisTarih.Location = new System.Drawing.Point(594, 33);
            this.dtp_VerisTarih.Name = "dtp_VerisTarih";
            this.dtp_VerisTarih.Size = new System.Drawing.Size(200, 21);
            this.dtp_VerisTarih.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Kitap Teslim Tarih :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Kitap Veriş Tarih :";
            // 
            // btn_SureyiUzat
            // 
            this.btn_SureyiUzat.FlatAppearance.BorderSize = 0;
            this.btn_SureyiUzat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SureyiUzat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SureyiUzat.Image = ((System.Drawing.Image)(resources.GetObject("btn_SureyiUzat.Image")));
            this.btn_SureyiUzat.Location = new System.Drawing.Point(223, 20);
            this.btn_SureyiUzat.Name = "btn_SureyiUzat";
            this.btn_SureyiUzat.Size = new System.Drawing.Size(92, 96);
            this.btn_SureyiUzat.TabIndex = 32;
            this.btn_SureyiUzat.Text = "Süreyi Uzat";
            this.btn_SureyiUzat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_SureyiUzat.UseVisualStyleBackColor = true;
            this.btn_SureyiUzat.Click += new System.EventHandler(this.btn_SureyiUzat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(848, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Açıklama :";
            // 
            // btn_TeslimAl
            // 
            this.btn_TeslimAl.FlatAppearance.BorderSize = 0;
            this.btn_TeslimAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TeslimAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_TeslimAl.Image = ((System.Drawing.Image)(resources.GetObject("btn_TeslimAl.Image")));
            this.btn_TeslimAl.Location = new System.Drawing.Point(110, 20);
            this.btn_TeslimAl.Name = "btn_TeslimAl";
            this.btn_TeslimAl.Size = new System.Drawing.Size(92, 96);
            this.btn_TeslimAl.TabIndex = 31;
            this.btn_TeslimAl.Text = "Teslim Al";
            this.btn_TeslimAl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_TeslimAl.UseVisualStyleBackColor = true;
            this.btn_TeslimAl.Click += new System.EventHandler(this.btn_TeslimAl_Click);
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(821, 26);
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(272, 96);
            this.txt_Aciklama.TabIndex = 3;
            this.txt_Aciklama.Text = "";
            // 
            // btn_OduncVer
            // 
            this.btn_OduncVer.FlatAppearance.BorderSize = 0;
            this.btn_OduncVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OduncVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OduncVer.Image = ((System.Drawing.Image)(resources.GetObject("btn_OduncVer.Image")));
            this.btn_OduncVer.Location = new System.Drawing.Point(4, 20);
            this.btn_OduncVer.Name = "btn_OduncVer";
            this.btn_OduncVer.Size = new System.Drawing.Size(92, 96);
            this.btn_OduncVer.TabIndex = 1;
            this.btn_OduncVer.Text = "Ödünç Ver";
            this.btn_OduncVer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_OduncVer.UseVisualStyleBackColor = true;
            this.btn_OduncVer.Click += new System.EventHandler(this.btn_OduncVer_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dt_OduncListe);
            this.groupBox4.Location = new System.Drawing.Point(5, 506);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1140, 261);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ödünç Kitaplar Listesi";
            // 
            // dt_OduncListe
            // 
            this.dt_OduncListe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dt_OduncListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_OduncListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.KID,
            this.oduncATarih,
            this.oduncVTarih,
            this.tc,
            this.isim,
            this.tel,
            this.kitapad,
            this.yazar,
            this.oduncDurum,
            this.oduncAciklama,
            this.tur,
            this.kitapB});
            this.dt_OduncListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_OduncListe.Location = new System.Drawing.Point(3, 17);
            this.dt_OduncListe.Name = "dt_OduncListe";
            this.dt_OduncListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_OduncListe.Size = new System.Drawing.Size(1134, 241);
            this.dt_OduncListe.TabIndex = 0;
            this.dt_OduncListe.DoubleClick += new System.EventHandler(this.dt_OduncListe_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "oduncId";
            this.id.HeaderText = "Odunc ID";
            this.id.Name = "id";
            // 
            // KID
            // 
            this.KID.DataPropertyName = "kitapId";
            this.KID.HeaderText = "Kitap ID";
            this.KID.Name = "KID";
            this.KID.Visible = false;
            // 
            // oduncATarih
            // 
            this.oduncATarih.DataPropertyName = "oduncATarih";
            this.oduncATarih.HeaderText = "Alış Tarih";
            this.oduncATarih.Name = "oduncATarih";
            this.oduncATarih.Width = 150;
            // 
            // oduncVTarih
            // 
            this.oduncVTarih.DataPropertyName = "oduncVTarih";
            this.oduncVTarih.HeaderText = "Teslim Tarih";
            this.oduncVTarih.Name = "oduncVTarih";
            this.oduncVTarih.Width = 150;
            // 
            // tc
            // 
            this.tc.DataPropertyName = "uyeTc";
            this.tc.HeaderText = "Üye Tc";
            this.tc.Name = "tc";
            this.tc.Width = 130;
            // 
            // isim
            // 
            this.isim.DataPropertyName = "uyeIsim";
            this.isim.HeaderText = "Üye İsim";
            this.isim.Name = "isim";
            this.isim.Width = 120;
            // 
            // tel
            // 
            this.tel.DataPropertyName = "uyeTel";
            this.tel.HeaderText = "Uye Telefon";
            this.tel.Name = "tel";
            this.tel.Width = 110;
            // 
            // kitapad
            // 
            this.kitapad.DataPropertyName = "kitapAdi";
            this.kitapad.HeaderText = "Kitap Adı";
            this.kitapad.Name = "kitapad";
            this.kitapad.Width = 110;
            // 
            // yazar
            // 
            this.yazar.DataPropertyName = "kitapYazari";
            this.yazar.HeaderText = "Kitap Yazar";
            this.yazar.Name = "yazar";
            this.yazar.Width = 110;
            // 
            // oduncDurum
            // 
            this.oduncDurum.DataPropertyName = "oduncDurum";
            this.oduncDurum.HeaderText = "Emanet Durum";
            this.oduncDurum.Name = "oduncDurum";
            this.oduncDurum.Visible = false;
            this.oduncDurum.Width = 120;
            // 
            // oduncAciklama
            // 
            this.oduncAciklama.DataPropertyName = "oduncAciklama";
            this.oduncAciklama.HeaderText = "Acıklama";
            this.oduncAciklama.Name = "oduncAciklama";
            this.oduncAciklama.Visible = false;
            // 
            // tur
            // 
            this.tur.DataPropertyName = "kitaTuru";
            this.tur.HeaderText = "Kitap Türü";
            this.tur.Name = "tur";
            this.tur.Visible = false;
            this.tur.Width = 110;
            // 
            // kitapB
            // 
            this.kitapB.DataPropertyName = "kitapBarkod";
            this.kitapB.HeaderText = "Barkod";
            this.kitapB.Name = "kitapB";
            this.kitapB.Width = 110;
            // 
            // lbl_Kitap
            // 
            this.lbl_Kitap.AutoSize = true;
            this.lbl_Kitap.Location = new System.Drawing.Point(65, 274);
            this.lbl_Kitap.Name = "lbl_Kitap";
            this.lbl_Kitap.Size = new System.Drawing.Size(0, 15);
            this.lbl_Kitap.TabIndex = 31;
            // 
            // lbl_Uye
            // 
            this.lbl_Uye.AutoSize = true;
            this.lbl_Uye.Location = new System.Drawing.Point(620, 273);
            this.lbl_Uye.Name = "lbl_Uye";
            this.lbl_Uye.Size = new System.Drawing.Size(0, 15);
            this.lbl_Uye.TabIndex = 32;
            // 
            // lbl_Tc
            // 
            this.lbl_Tc.AutoSize = true;
            this.lbl_Tc.Location = new System.Drawing.Point(240, 487);
            this.lbl_Tc.Name = "lbl_Tc";
            this.lbl_Tc.Size = new System.Drawing.Size(0, 15);
            this.lbl_Tc.TabIndex = 33;
            // 
            // lbl_Barkod
            // 
            this.lbl_Barkod.AutoSize = true;
            this.lbl_Barkod.Location = new System.Drawing.Point(570, 488);
            this.lbl_Barkod.Name = "lbl_Barkod";
            this.lbl_Barkod.Size = new System.Drawing.Size(0, 15);
            this.lbl_Barkod.TabIndex = 34;
            // 
            // FormOdunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1146, 773);
            this.Controls.Add(this.lbl_Barkod);
            this.Controls.Add(this.lbl_Tc);
            this.Controls.Add(this.lbl_Uye);
            this.Controls.Add(this.lbl_Kitap);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.group);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormOdunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödünç Kitaplar";
            this.Load += new System.EventHandler(this.FormOdunc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_KitapListe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_UyeListe)).EndInit();
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_OduncListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_KitapAra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_UyeAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_Aciklama;
        private System.Windows.Forms.Button btn_OduncVer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dt_OduncListe;
        private System.Windows.Forms.DataGridView dt_KitapListe;
        private System.Windows.Forms.DataGridView dt_UyeListe;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeTc;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeIsim;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeSoyisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeKayitTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeAdres;
        private System.Windows.Forms.Button btn_SureyiUzat;
        private System.Windows.Forms.Button btn_TeslimAl;
        private System.Windows.Forms.DateTimePicker dtp_VerisTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_TeslimTarih;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Label lbl_Kitap;
        private System.Windows.Forms.Label lbl_Uye;
        private System.Windows.Forms.Button btn_KitapEkle;
        private System.Windows.Forms.Button btn_UyeEkle;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapId;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazari;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYayinEvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapSayfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapBasimYili;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapBarkod;
        private System.Windows.Forms.Button btn_KitapYenile;
        private System.Windows.Forms.Button btn_UyeYenile;
        private System.Windows.Forms.Label lbl_Tc;
        private System.Windows.Forms.Label lbl_Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn KID;
        private System.Windows.Forms.DataGridViewTextBoxColumn oduncATarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn oduncVTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapad;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn oduncDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn oduncAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}