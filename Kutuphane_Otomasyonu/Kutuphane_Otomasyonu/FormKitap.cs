using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu
{
    public partial class FormKitap : Form
    {
        string yol = @"Data Source=DESKTOP-93ROJCH\IBRAHIM;Initial Catalog=Kutuphane;Integrated Security=True";
        public SqlDataAdapter adaptor;
        public SqlDataReader okuyucu;
        public DataTable tablo;
        public SqlCommand komut;
        public SqlConnection baglanti;
        public FormKitap()
        {
            InitializeComponent();
        }
        int SecimID = -1;
        KutuphaneEntities db = new KutuphaneEntities();
        Mesajlar mesajlar = new Mesajlar();
        private void FormKitap_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Ekle();
        }
        void Listele()
        {
            var sorgu = from tb1 in db.Kitaplar
                        select new
                        {
                            tb1.kitapId,
                            tb1.kitapBarkod,
                            tb1.kitapAdi,
                            tb1.kitapYazari,
                            tb1.kitapYayinEvi,
                            tb1.kitapStok,
                            tb1.kitapSayfa,
                            tb1.kitapTuru,
                            tb1.kitapBasimYili
                        };
            dt_KitapListe.DataSource = sorgu.ToList();
        }
        void Ekle()
        {
            try
            {
                Kitaplar kitaplar = new Kitaplar();
                kitaplar.kitapBarkod = txt_Barkod.Text;
                kitaplar.kitapAdi = txt_KitapAdi.Text;
                kitaplar.kitapYazari = txt_KitapYazari.Text;
                kitaplar.kitapYayinEvi = cmb_YayinEvi.Text;
                kitaplar.kitapStok = Convert.ToInt32(txt_StokSayisi.Text);
                kitaplar.kitapSayfa = Convert.ToInt32(txt_SayfaSayisi.Text);
                kitaplar.kitapTuru = cmb_KitapTuru.Text;
                kitaplar.kitapBasimYili = Convert.ToInt32(txt_BasimYili.Text);
                kitaplar.kitapDurum = "Uygun";
                db.Kitaplar.Add(kitaplar);
                db.SaveChanges();
                Listele();
                Temizle();
            }
            catch (Exception)
            {

                MessageBox.Show("Ekleme işlemi sırasında hata oluştu");
            }

        }
        void Sec()
        {
            try
            {
                SecimID = int.Parse(dt_KitapListe.CurrentRow.Cells["kitapId"].Value.ToString());
                txt_Barkod.Text = dt_KitapListe.CurrentRow.Cells["kitapBarkod"].Value.ToString();
                txt_KitapAdi.Text = dt_KitapListe.CurrentRow.Cells["kitapAdi"].Value.ToString();
                txt_KitapYazari.Text = dt_KitapListe.CurrentRow.Cells["kitapYazari"].Value.ToString();
                cmb_YayinEvi.Text = dt_KitapListe.CurrentRow.Cells["kitapYayinEvi"].Value.ToString();
                txt_StokSayisi.Text = dt_KitapListe.CurrentRow.Cells["kitapStok"].Value.ToString();
                txt_SayfaSayisi.Text = dt_KitapListe.CurrentRow.Cells["kitapSayfa"].Value.ToString();
                cmb_KitapTuru.Text = dt_KitapListe.CurrentRow.Cells["kitapTuru"].Value.ToString();
                txt_BasimYili.Text = dt_KitapListe.CurrentRow.Cells["kitapBasimYili"].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Seçim Sırasında Hata Oluştu", "Seçim Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Guncelle()
        {
            try
            {
                var kitaplar = db.Kitaplar.Find(SecimID);
                kitaplar.kitapBarkod = txt_Barkod.Text;
                kitaplar.kitapAdi = txt_KitapAdi.Text;
                kitaplar.kitapYazari = txt_KitapYazari.Text;
                kitaplar.kitapYayinEvi = cmb_YayinEvi.Text;
                kitaplar.kitapStok = Convert.ToInt32(txt_StokSayisi.Text);
                kitaplar.kitapSayfa = Convert.ToInt32(txt_SayfaSayisi.Text);
                kitaplar.kitapTuru = cmb_KitapTuru.Text;
                kitaplar.kitapBasimYili = Convert.ToInt32(txt_BasimYili.Text);
                db.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme yapılırken hata oluştu.");
            }
        }
        void Temizle()
        {
            txt_Barkod.Text = "";
            txt_KitapAdi.Text = "";
            txt_KitapYazari.Text = "";
            cmb_YayinEvi.Text = "";
            txt_StokSayisi.Text = "";
            txt_SayfaSayisi.Text = "";
            cmb_KitapTuru.Text = "";
            txt_BasimYili.Text = "";
        }
        void Sil()
        {
            try
            {
                var x = db.Kitaplar.Find(SecimID);
                db.Kitaplar.Remove(x);
                db.SaveChanges();
                Temizle();
                Listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Silme işlemi yapılırken hata oluştu");
            }
        }
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (mesajlar.Onaylama("Seçilen kartı güncellemek istediğinize eminmisiniz?", "Kart Güncelle") == DialogResult.Yes)
            {
                Guncelle();
                Listele();
                Temizle();
            }
        }
        private void dt_UyeListe_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (mesajlar.Onaylama("Kitabı silmek istediğinize eminmisiniz?", "Kitap Sil!") == DialogResult.Yes)
            {
                Sil();
            }
            else
            {
                Temizle();
            }
        }
        public void Baglan()
        {
            baglanti = new SqlConnection(yol);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        //string sorgu = "Select * From Kitaplar Where'" + kriter + "'='" + b + "'";
        private void btn_Ara_Click(object sender, EventArgs e)
        {
            string kitapAdi = "kitapAdi";
            string b = "dsa";
            Baglan();
            string sorgu = "Select * From Kitaplar Where '" + kitapAdi + "'= '" + b + "'";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            tablo = new DataTable();
            adaptor = new SqlDataAdapter(komut);
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            dt_KitapListe.DataSource = tablo;

        }
}
}
