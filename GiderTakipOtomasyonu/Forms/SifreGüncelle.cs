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
    public partial class SifreGüncelle : Form
    {
        public SifreGüncelle()
        {
            InitializeComponent();
        }

        public string mail = "";

        private void SifreGüncelle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                KullaniciDbContext kullaniciDbContext = new KullaniciDbContext();
                var kullanicilar = kullaniciDbContext.Kullanicilar.ToList();
                for (int i = 0; i < kullanicilar.Count; i++)
                {
                    if (kullanicilar[i].mail == mail)
                    {
                        KullaniciDbClass Kullanici = new KullaniciDbClass
                        {
                            adi = kullanicilar[i].adi,
                            mail = mail,
                            sifre = textBox1.Text,
                            id = kullanicilar[i].id
                        };
                        kullaniciDbContext.Update(Kullanici);
                        int result = kullaniciDbContext.SaveChanges();
                        if (result > 0)
                            MessageBox.Show("Sifre Değiştirme Başarılı");
                        else
                            MessageBox.Show("Sifre Değiştirme Başarısız");
                    }
                }
            }            
        }
    }
}
