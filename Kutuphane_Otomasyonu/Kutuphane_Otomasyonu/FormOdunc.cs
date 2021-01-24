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
    public partial class FormOdunc : Form
    {
        public FormOdunc()
        {
            InitializeComponent();
        }
        int KSecimID = -1;
        int USecimID = -1;
        int OduncSecim = -1;
        KutuphaneEntities db = new KutuphaneEntities();
        Mesajlar mesajlar = new Mesajlar();
        private void FormOdunc_Load(object sender, EventArgs e)
        {
            KitapListele();
            UyeListele();
            Listele();
        }
        void Listele()
        {
            var sorgu = from tb1 in db.Oduncler
                        join tb2 in db.Uyeler on tb1.uyeId equals tb2.uyeId
                        join tb3 in db.Kitaplar on tb1.kitapId equals tb3.kitapId
                        //where dsadas
                        select new
                        {
                            tb1.kitapId,
                            tb1.oduncId,
                            tb1.oduncATarih,
                            tb1.oduncVTarih,
                            tb1.oduncDurum,
                            tb1.oduncAciklama,
                            tb2.uyeTc,
                            tb2.uyeIsim,
                            tb2.uyeTel,
                            tb3.kitapAdi,
                            tb3.kitapYazari,
                            tb3.kitapBarkod
                        };
            dt_OduncListe.DataSource = sorgu.ToList();
        }
        void Temizle()
        {
            lbl_Kitap.Text = "";
            lbl_Uye.Text = "";
            USecimID = -1;
            KSecimID = -1;
        }
        void KitapListele()
        {
            var sorgu = from tb1 in db.Kitaplar
                        where tb1.kitapDurum != "Emanet"
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
        void UyeListele()
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
        void SecimTemizle()
        {
            lbl_Kitap.Text = "";
            lbl_Uye.Text = "";
            USecimID = -1;
            KSecimID = -1;
        }
        void SecKitap()
        {
            try
            {
                lbl_Kitap.Text = "";
                KSecimID = -1;
                KSecimID = int.Parse(dt_KitapListe.CurrentRow.Cells["kitapId"].Value.ToString());
                lbl_Kitap.Text += "Kitap Adı : "; lbl_Kitap.Text += dt_KitapListe.CurrentRow.Cells["kitapAdi"].Value.ToString() + "\n";
                lbl_Kitap.Text += "Kitap Yazarı : "; lbl_Kitap.Text += dt_KitapListe.CurrentRow.Cells["kitapYazari"].Value.ToString() + "\n";
                lbl_Kitap.Text += "Yayın Evi : "; lbl_Kitap.Text += dt_KitapListe.CurrentRow.Cells["kitapYayinEvi"].Value.ToString() + "\n";
                lbl_Kitap.Text += "Yayın Türü : "; lbl_Kitap.Text += dt_KitapListe.CurrentRow.Cells["kitapTuru"].Value.ToString();
            }
            catch (Exception)
            {

                mesajlar.Hata("Kitap Secilirken Hata Oluştu!", "Seçim Hatası");
            }

        }
        void SecUye()
        {
            try
            {
                lbl_Uye.Text = "";
                USecimID = -1;
                USecimID = int.Parse(dt_UyeListe.CurrentRow.Cells["uyeId"].Value.ToString());
                lbl_Uye.Text += "Tc No : "; lbl_Uye.Text += dt_UyeListe.CurrentRow.Cells["uyeTc"].Value.ToString() + "\n";
                lbl_Uye.Text += "İsim : "; lbl_Uye.Text += dt_UyeListe.CurrentRow.Cells["uyeIsim"].Value.ToString() + "\n";
                lbl_Uye.Text += "Soyisim : "; lbl_Uye.Text += dt_UyeListe.CurrentRow.Cells["uyeSoyisim"].Value.ToString() + "\n";
                lbl_Uye.Text += "Telefon : "; lbl_Uye.Text += dt_UyeListe.CurrentRow.Cells["uyeTel"].Value.ToString() + "\n";
                lbl_Uye.Text += "E-mail : "; lbl_Uye.Text += dt_UyeListe.CurrentRow.Cells["uyeEmail"].Value.ToString();
            }
            catch (Exception)
            {

                mesajlar.Hata("Uye Secilirken Hata Oluştu!", "Seçim Hatası");
            }
        }
        void OduncVer()
        {
            if (USecimID != -1 && KSecimID != -1)
            {
                Oduncler oduncler = new Oduncler();
                oduncler.kitapId = KSecimID;
                oduncler.uyeId = USecimID;
                oduncler.oduncATarih = dtp_VerisTarih.Value;
                oduncler.oduncVTarih = dtp_TeslimTarih.Value;
                oduncler.oduncDurum = "Emanet";
                oduncler.oduncAciklama = txt_Aciklama.Text;
                db.Oduncler.Add(oduncler);

                var kitaplar = db.Kitaplar.Find(KSecimID);
                kitaplar.kitapDurum = "Emanet";
                db.SaveChanges();
                Listele();
                KitapListele();


            }
            else
            {
                mesajlar.Hata("Seçim Yapılmadı", "Hata!");
            }
        }
        void TeslimAl()
        {
            try
            {
                if (OduncSecim > -1 && KSecimID > -1)
                {

                    var sil = db.Oduncler.Find(OduncSecim);
                    db.Oduncler.Remove(sil);
                    var kitaplar = db.Kitaplar.Find(KSecimID);
                    kitaplar.kitapDurum = "Uygun";
                    db.SaveChanges();
                    Temizle();
                    KitapListele();
                    Listele();
                    lbl_Tc.Text = "";
                    lbl_Barkod.Text = "";
                }
                else
                {
                    MessageBox.Show("Seçim İşlemi Yapılamadı!");
                }
            }
            catch (Exception)
            {

                mesajlar.Hata("Teslim Alınırken Hata Oluştu!", "Teslim Alma Hatası");
            }

        }


        private void dt_KitapListe_DoubleClick(object sender, EventArgs e)
        {
            SecKitap();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            SecimTemizle();
        }

        private void btn_KitapEkle_Click(object sender, EventArgs e)
        {
            FormKitap frm = new FormKitap();
            frm.Show();
        }
        private void dt_UyeListe_DoubleClick(object sender, EventArgs e)
        {
            SecUye();
        }

        private void btn_OduncVer_Click(object sender, EventArgs e)
        {
            OduncVer();
            Temizle();
        }

        private void btn_UyeEkle_Click(object sender, EventArgs e)
        {
            FormUyeler frm = new FormUyeler();
            frm.Show();
        }

        private void btn_KitapYenile_Click(object sender, EventArgs e)
        {
            KitapListele();
        }

        private void btn_UyeYenile_Click(object sender, EventArgs e)
        {
            UyeListele();
        }

        private void dt_OduncListe_DoubleClick(object sender, EventArgs e)
        {
            lbl_Tc.Text = "";
            lbl_Barkod.Text = "";
            KSecimID = int.Parse(dt_OduncListe.CurrentRow.Cells["KID"].Value.ToString());
            lbl_Tc.Text += "Üye Tc No : "; lbl_Tc.Text += dt_OduncListe.CurrentRow.Cells["tc"].Value.ToString();
            lbl_Barkod.Text += "Kitap Barkod : "; lbl_Barkod.Text += dt_OduncListe.CurrentRow.Cells["KitapB"].Value.ToString();

            OduncSecim = int.Parse(dt_OduncListe.CurrentRow.Cells["id"].Value.ToString());
        }

        private void btn_TeslimAl_Click(object sender, EventArgs e)
        {
            TeslimAl();
        }

        private void btn_SureyiUzat_Click(object sender, EventArgs e)
        {
            if (OduncSecim > 0)
            {
                var guncelle = db.Oduncler.Find(OduncSecim);
                guncelle.oduncVTarih = dtp_TeslimTarih.Value;
                db.SaveChanges();
                Listele();
                lbl_Barkod.Text = "";
                lbl_Tc.Text = "";
                MessageBox.Show("Süre uzatıldı");
            }
            else
            {
                MessageBox.Show("Seçim Yapılmadı!");
            }

        }

        private void txt_UyeAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var sorgu = from tb1 in db.Uyeler
                            where tb1.uyeTc == Convert.ToInt32(txt_UyeAra.Text)
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
            catch (Exception)
            {

                txt_UyeAra.Text = "";
            }
        }
        private void txt_KitapAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var sorgu = from tb1 in db.Kitaplar
                            where tb1.kitapAdi == txt_KitapAra.Text
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
            catch (Exception)
            {
                txt_KitapAra.Text = "";
            }
        }
    }
}
