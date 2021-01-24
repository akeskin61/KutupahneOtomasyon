using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu
{
    public partial class formGuvenlik : Form
    {
        public formGuvenlik()
        {
            InitializeComponent();
        }
        int SecimID = -1;
        KutuphaneEntities db = new KutuphaneEntities();
        Mesajlar mesajlar = new Mesajlar();
        void Listele()
        {
            var sorgu = from tb1 in db.Yoneticiler
                        select new
                        {
                            tb1.yoneticiId,
                            tb1.yoneticiKullaniciAdi,
                            tb1.yoneticiSifre,
                            tb1.yoneticiAdi,
                            tb1.yoneticiSoyadi,
                            tb1.yoneticiUnvan
                        };
            dt_Yoneticiler.DataSource = sorgu.ToList();
        }
        void Temizle()
        {
            txt_Ad.Text = "";
            txt_KullaniciAdi.Text = "";
            txt_Sifre.Text = "";
            txt_SifreTekrar.Text = "";
            txt_Soyad.Text = "";
            txt_Unvan.Text = "";
        }
        void Ekle()
        {
            try
            {
                if (txt_Sifre.Text == txt_SifreTekrar.Text)
                {
                    Yoneticiler yoneticiler = new Yoneticiler();
                    yoneticiler.yoneticiAdi = txt_Ad.Text;
                    yoneticiler.yoneticiSoyadi = txt_Soyad.Text;
                    yoneticiler.yoneticiUnvan = txt_Unvan.Text;
                    yoneticiler.yoneticiKullaniciAdi = txt_KullaniciAdi.Text;
                    yoneticiler.yoneticiSifre = txt_Sifre.Text;
                    db.Yoneticiler.Add(yoneticiler);
                    db.SaveChanges();
                    Listele();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor!");
                }
            }
            catch (Exception)
            {
                mesajlar.Hata("Ekleme Sırasında Hata Oluştu", "Ekleme Hatası");         
            }
        }
        void Guncelle()
        {
            try
            {
                var yoneticiler = db.Yoneticiler.Find(SecimID);
                yoneticiler.yoneticiAdi = txt_Ad.Text;
                yoneticiler.yoneticiSoyadi = txt_Soyad.Text;
                yoneticiler.yoneticiUnvan = txt_Unvan.Text;
                yoneticiler.yoneticiKullaniciAdi = txt_KullaniciAdi.Text;
                yoneticiler.yoneticiSifre = txt_Sifre.Text;
                db.SaveChanges();
                Listele();
                Temizle();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }

        }
        void Sil()
        {
            try
            {
                var sil = db.Yoneticiler.Find(SecimID);
                db.Yoneticiler.Remove(sil);
                db.SaveChanges();
                Temizle();
                Listele();
            }
            catch (Exception)
            {
                mesajlar.Hata("Silme Sırasında Hata Oluştu", "Silme Hatası");
            }
        }
        void Sec()
        {
            try
            {
                SecimID = int.Parse(dt_Yoneticiler.CurrentRow.Cells["yoneticiId"].Value.ToString());
                txt_Ad.Text = dt_Yoneticiler.CurrentRow.Cells["yoneticiAdi"].Value.ToString();
                txt_Sifre.Text = dt_Yoneticiler.CurrentRow.Cells["yoneticiSifre"].Value.ToString();
                txt_Soyad.Text = dt_Yoneticiler.CurrentRow.Cells["yoneticiSoyadi"].Value.ToString();
                txt_KullaniciAdi.Text = dt_Yoneticiler.CurrentRow.Cells["yoneticiKullaniciAdi"].Value.ToString();
                txt_Unvan.Text = dt_Yoneticiler.CurrentRow.Cells["yoneticiUnvan"].Value.ToString();
            }
            catch (Exception)
            {

                mesajlar.Hata("Seçme Sırasında Hata Oluştu", "Seçme Hatası");
            }

        }
        private void formGuvenlik_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void dt_Yoneticiler_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }
    }
}
