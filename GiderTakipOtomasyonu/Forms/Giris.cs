using GiderTakipOtomasyonu.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiderTakipOtomasyonu.Forms
{
    public partial class Giris : Form
    {
        gtoDbContext dbContext = new gtoDbContext();
        KullaniciDbContext kullaniciDbContext = new KullaniciDbContext();

        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciDbClass Kullanici = new KullaniciDbClass
            {
                adi = textBoxKullaniciAdi.Text,
                sifre = textBoxSifre.Text
            };


        }

        private bool kontrol(int kullaniciadi, int sifre)
        {
            bool k = true;
            return k;
        }

    }
}
