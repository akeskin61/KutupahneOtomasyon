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
    public partial class formGecikenler : Form
    {
        public formGecikenler()
        {
            InitializeComponent();
        }
        KutuphaneEntities db = new KutuphaneEntities();
        Mesajlar mesajlar = new Mesajlar();
        void Listele()
        {
            var sorgu = from tb1 in db.Oduncler
                        join tb2 in db.Uyeler on tb1.uyeId equals tb2.uyeId
                        join tb3 in db.Kitaplar on tb1.kitapId equals tb3.kitapId
                        where tb1.oduncVTarih <= DateTime.Now
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
        private void formGecikenler_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
