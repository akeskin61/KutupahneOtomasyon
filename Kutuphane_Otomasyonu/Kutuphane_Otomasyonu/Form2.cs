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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Kitap_Click(object sender, EventArgs e)
        {
            FormKitap frm = new FormKitap();
            frm.Show();
        }

        private void btn_Uyeler_Click(object sender, EventArgs e)
        {
            FormUyeler frm = new FormUyeler();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOdunc frm = new FormOdunc();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formGecikenler frm = new formGecikenler();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formGuvenlik frm = new formGuvenlik();
            frm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
