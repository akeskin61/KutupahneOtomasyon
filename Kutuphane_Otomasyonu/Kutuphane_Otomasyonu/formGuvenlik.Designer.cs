namespace Kutuphane_Otomasyonu
{
    partial class formGuvenlik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGuvenlik));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_SifreTekrar = new System.Windows.Forms.TextBox();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Unvan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dt_Yoneticiler = new System.Windows.Forms.DataGridView();
            this.yoneticiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiKullaniciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiSifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiUnvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Yoneticiler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_SifreTekrar);
            this.groupBox1.Controls.Add(this.btn_Sil);
            this.groupBox1.Controls.Add(this.btn_Guncelle);
            this.groupBox1.Controls.Add(this.btn_Ekle);
            this.groupBox1.Controls.Add(this.txt_KullaniciAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Sifre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Unvan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Soyad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Ad);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 147);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yönetici Bilgileri";
            // 
            // txt_SifreTekrar
            // 
            this.txt_SifreTekrar.Location = new System.Drawing.Point(362, 103);
            this.txt_SifreTekrar.Name = "txt_SifreTekrar";
            this.txt_SifreTekrar.Size = new System.Drawing.Size(161, 20);
            this.txt_SifreTekrar.TabIndex = 22;
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
            this.btn_Sil.Location = new System.Drawing.Point(532, 58);
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
            this.btn_Guncelle.Location = new System.Drawing.Point(532, 99);
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
            this.btn_Ekle.Location = new System.Drawing.Point(532, 14);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(104, 40);
            this.btn_Ekle.TabIndex = 19;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(363, 31);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(161, 20);
            this.txt_KullaniciAdi.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetici Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yönetici Ünvan :";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(362, 67);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(161, 20);
            this.txt_Sifre.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yönetici Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre Tekrar :";
            // 
            // txt_Unvan
            // 
            this.txt_Unvan.Location = new System.Drawing.Point(108, 102);
            this.txt_Unvan.Name = "txt_Unvan";
            this.txt_Unvan.Size = new System.Drawing.Size(160, 20);
            this.txt_Unvan.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kullanıcı Adı :";
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(108, 67);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(160, 20);
            this.txt_Soyad.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Şifre :";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(108, 31);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(160, 20);
            this.txt_Ad.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dt_Yoneticiler);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 297);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Listesi";
            // 
            // dt_Yoneticiler
            // 
            this.dt_Yoneticiler.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dt_Yoneticiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Yoneticiler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yoneticiId,
            this.yoneticiKullaniciAdi,
            this.yoneticiSifre,
            this.yoneticiAdi,
            this.yoneticiSoyadi,
            this.yoneticiUnvan});
            this.dt_Yoneticiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_Yoneticiler.Location = new System.Drawing.Point(3, 16);
            this.dt_Yoneticiler.Name = "dt_Yoneticiler";
            this.dt_Yoneticiler.ReadOnly = true;
            this.dt_Yoneticiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_Yoneticiler.Size = new System.Drawing.Size(687, 278);
            this.dt_Yoneticiler.TabIndex = 1;
            this.dt_Yoneticiler.DoubleClick += new System.EventHandler(this.dt_Yoneticiler_DoubleClick);
            // 
            // yoneticiId
            // 
            this.yoneticiId.DataPropertyName = "yoneticiId";
            this.yoneticiId.HeaderText = "Yönetici ID";
            this.yoneticiId.Name = "yoneticiId";
            this.yoneticiId.ReadOnly = true;
            // 
            // yoneticiKullaniciAdi
            // 
            this.yoneticiKullaniciAdi.DataPropertyName = "yoneticiKullaniciAdi";
            this.yoneticiKullaniciAdi.HeaderText = "Kullanıcı Adı";
            this.yoneticiKullaniciAdi.Name = "yoneticiKullaniciAdi";
            this.yoneticiKullaniciAdi.ReadOnly = true;
            // 
            // yoneticiSifre
            // 
            this.yoneticiSifre.DataPropertyName = "yoneticiSifre";
            this.yoneticiSifre.HeaderText = "Şifre";
            this.yoneticiSifre.Name = "yoneticiSifre";
            this.yoneticiSifre.ReadOnly = true;
            // 
            // yoneticiAdi
            // 
            this.yoneticiAdi.DataPropertyName = "yoneticiAdi";
            this.yoneticiAdi.HeaderText = "Adı";
            this.yoneticiAdi.Name = "yoneticiAdi";
            this.yoneticiAdi.ReadOnly = true;
            // 
            // yoneticiSoyadi
            // 
            this.yoneticiSoyadi.DataPropertyName = "yoneticiSoyadi";
            this.yoneticiSoyadi.HeaderText = "Soyadi";
            this.yoneticiSoyadi.Name = "yoneticiSoyadi";
            this.yoneticiSoyadi.ReadOnly = true;
            // 
            // yoneticiUnvan
            // 
            this.yoneticiUnvan.DataPropertyName = "yoneticiUnvan";
            this.yoneticiUnvan.HeaderText = "Ünvan";
            this.yoneticiUnvan.Name = "yoneticiUnvan";
            this.yoneticiUnvan.ReadOnly = true;
            // 
            // formGuvenlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "formGuvenlik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güvenlik İşlemleri";
            this.Load += new System.EventHandler(this.formGuvenlik_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_Yoneticiler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TextBox txt_KullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Unvan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dt_Yoneticiler;
        private System.Windows.Forms.TextBox txt_SifreTekrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiKullaniciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiSifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiUnvan;
    }
}