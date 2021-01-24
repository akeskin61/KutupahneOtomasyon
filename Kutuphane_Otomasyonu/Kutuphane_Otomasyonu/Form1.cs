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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KutuphaneEntities db = new KutuphaneEntities();
        Mesajlar mesajlar = new Mesajlar();

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
            /*
            try
            {
                var x = db.Yoneticiler.Where(s => s.yoneticiKullaniciAdi == txt_KullaniciAdi.Text && s.yoneticiSifre == txt_Sifre.Text).SingleOrDefault();
                if (x != null)
                {
                    Form2 frm = new Form2();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    mesajlar.Hata("Kullanıcı adı yada şifre hatalı!", "Giris Hatası");
                }
            }
            catch (Exception)
            {

                mesajlar.Hata("hata", "hata");
                
            }
            */

        }
    }
}
