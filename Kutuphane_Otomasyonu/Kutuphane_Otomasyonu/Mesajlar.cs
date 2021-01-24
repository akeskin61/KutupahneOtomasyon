using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu
{
    class Mesajlar
    {
        public bool kontrol, eklekontrol, arackontrol, serviskontrol, nakliyekontrol = false;
        public void Hata(string hatametni,string hatabasligi)
        {
            MessageBox.Show(hatametni,hatabasligi, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Ekle(string ekle, string mesaj)
        {
            MessageBox.Show(ekle, mesaj, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult KartEkle()
        {
            return MessageBox.Show("Kart eklemek istediğinize eminmisiniz", "Kart Ekle!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public bool EkleKontrol(string ad, string soyad, string firma, string telefon, string sebep, string tc)
        {
            eklekontrol = false;
            if (ad != "")
            {
                if (soyad != "")
                {
                    if (firma != "")
                    {
                        if (telefon != "")
                        {
                            if (sebep != "")
                            {
                                if (tc != "")
                                {
                                    eklekontrol = true;
                                }
                            }
                        }
                    }
                }

            }
            return eklekontrol;
        }

        public DialogResult Onaylama(string mesaj, string bilgi)
        {
            return MessageBox.Show(mesaj, bilgi, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public bool ServisKontrol(string bolge, string plaka)
        {
            serviskontrol = false;
            if (bolge != "")
            {
                if (plaka != "")
                {
                    serviskontrol = true;
                }
            }
            return serviskontrol;
        }
        public bool NakliyeKontrol(string plaka, string nad)
        {
            nakliyekontrol = false;
            if (plaka != "")
            {
                if (nad != "")
                {
                    serviskontrol = true;
                }
            }
            return serviskontrol;
        }
    }
}

