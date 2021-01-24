namespace Kutuphane_Otomasyonu
{
    partial class formGecikenler
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_OduncListe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_OduncListe);
            this.groupBox1.Location = new System.Drawing.Point(39, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geciken Kitaplar";
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
            this.dt_OduncListe.Location = new System.Drawing.Point(3, 16);
            this.dt_OduncListe.Name = "dt_OduncListe";
            this.dt_OduncListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_OduncListe.Size = new System.Drawing.Size(1038, 191);
            this.dt_OduncListe.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "oduncId";
            this.id.HeaderText = "Odunc ID";
            this.id.Name = "id";
            this.id.Visible = false;
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
            // formGecikenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1141, 316);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "formGecikenler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geciken Kitaplar";
            this.Load += new System.EventHandler(this.formGecikenler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_OduncListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dt_OduncListe;
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
    }
}