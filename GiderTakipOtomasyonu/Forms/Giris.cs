using GiderTakipOtomasyonu.Classes;
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
        Classes.FormTextController formTextController = Classes.FormTextController.giveInstance();
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


            /*if (girisKontrol())
            {

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
            */
        }

        //kontrol için yazılacak temel at demiştiniz
        private bool girisKontrol(int kullaniciadi, int sifre)
        {
            bool k = true;
            return k;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayitOl form = new KayitOl();
            form.ShowDialog();
        }

        private void textBoxKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            formTextController.kullaniciAdiKontrol(e);
        }

        private void textBoxSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            formTextController.sifreKontrol(e);
        }
    }
}
