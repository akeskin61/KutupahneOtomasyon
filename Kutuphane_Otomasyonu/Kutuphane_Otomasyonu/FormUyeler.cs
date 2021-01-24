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
    public partial class FormUyeler : Form
    {
        public FormUyeler()
        {
            InitializeComponent();
        }
        int SecimID = -1;
        KutuphaneEntities db = new KutuphaneEntities();
        Mesajlar mesajlar = new Mesajlar();

        private void FormUyeler_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Temizle()
        {
            txt_TcNo.Text = "";
            txt_UyeIsim.Text = "";
            txt_SoyIsim.Text = "";
            txt_TelNo.Text = "";
            txt_TelNo.Text = "";
            txt_Email.Text = "";
            txt_Adres.Text = "";

        }
        void Listele()
        {
            var sorgu = from tb1 in db.Uyeler
                        select new
                        {
                            tb1.uyeId,
                            tb1.uyeTc,
                            tb1.uyeIsim,
                            tb1.uyeSoyisim,
                            tb1.uyeTel,
                            tb1.uyeKayitTarihi,
                            tb1.uyeEmail,
                            tb1.uyeAdres
                        };
            dt_UyeListe.DataSource = sorgu.ToList();
        }
        void Ekle()
        {
            try
            {
                Uyeler uyeler = new Uyeler();
                uyeler.uyeTc = Convert.ToInt32(txt_TcNo.Text);
                uyeler.uyeIsim = txt_UyeIsim.Text;
                uyeler.uyeSoyisim = txt_SoyIsim.Text;
                uyeler.uyeTel = txt_TelNo.Text;
                uyeler.uyeKayitTarihi = dtp_KayitTarihi.Value;
                uyeler.uyeEmail = txt_Email.Text;
                uyeler.uyeAdres = txt_Adres.Text;
                db.Uyeler.Add(uyeler);
                db.SaveChanges();
                Listele();
                Temizle();
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt Ekleme Sırasında Hata Oluştu");
            }
        }
        void Sec()
        {
            try
            {
                SecimID = int.Parse(dt_UyeListe.CurrentRow.Cells["uyeId"].Value.ToString());
                txt_TcNo.Text = dt_UyeListe.CurrentRow.Cells["uyeTc"].Value.ToString();
                txt_UyeIsim.Text = dt_UyeListe.CurrentRow.Cells["uyeIsim"].Value.ToString();
                txt_SoyIsim.Text = dt_UyeListe.CurrentRow.Cells["uyeSoyisim"].Value.ToString();
                txt_TelNo.Text = dt_UyeListe.CurrentRow.Cells["uyeTel"].Value.ToString();
                dtp_KayitTarihi.Value = Convert.ToDateTime(dt_UyeListe.CurrentRow.Cells["uyeKayitTarihi"].Value.ToString());
                txt_Email.Text = dt_UyeListe.CurrentRow.Cells["uyeEmail"].Value.ToString();
                txt_Adres.Text = dt_UyeListe.CurrentRow.Cells["uyeAdres"].Value.ToString();
            }
            catch (Exception)
            {

                mesajlar.Hata("Secme Sırasında Hata Oluştu", "Seçme Hatası");
            }
        }
        void Guncelle()
        {
            try
            {
                var uyeler = db.Uyeler.Find(SecimID);
                uyeler.uyeTc = Convert.ToInt32(txt_TcNo.Text);
                uyeler.uyeIsim = txt_UyeIsim.Text;
                uyeler.uyeSoyisim = txt_SoyIsim.Text;
                uyeler.uyeTel = txt_TelNo.Text;
                uyeler.uyeKayitTarihi = dtp_KayitTarihi.Value;
                uyeler.uyeEmail = txt_Email.Text;
                uyeler.uyeAdres = txt_Adres.Text;
                db.SaveChanges();
                Listele();
                Temizle();
            }
            catch (Exception)
            {
                mesajlar.Hata("Guncelleme Sırasında Hata Oluştu", "Guncelleme Hatası");
            }
        }
        void Sil()
        {
            try
            {
                var sil = db.Uyeler.Find(SecimID);
                db.Uyeler.Remove(sil);
                db.SaveChanges();
                Temizle();
                Listele();
            }
            catch (Exception)
            {
                mesajlar.Hata("Silme Sırasında Hata Oluştu", "Silme Hatası");
            }
        }
        private void dt_UyeListe_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Ekle();
        }
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (mesajlar.Onaylama("Seçilen üyeyi silmek istediğinize eminmisiniz?", "Üye Sil") == DialogResult.Yes)
            {
                Sil();
            }   
        }
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (mesajlar.Onaylama("Seçilen üyeyi güncellemek istediğinize eminmisiniz?", "Uye Güncelle") == DialogResult.Yes)
            {
                Guncelle();
            }
        }
    }
}
