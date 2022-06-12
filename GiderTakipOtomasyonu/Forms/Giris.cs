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
            var kullanicilar = kullaniciDbContext.Kullanicilar.ToList();            

            KullaniciDbClass Kullanici = new KullaniciDbClass
            {
                adi = textBoxKullaniciAdi.Text,
                sifre = textBoxSifre.Text
            };

            for (int i = 0; i < kullanicilar.Count; i++)
            {
                if (kullanicilar[i].adi == Kullanici.adi && kullanicilar[i].sifre == Kullanici.sifre)
                {
                    Forms.InfrastructureForm form = new InfrastructureForm();
                    this.Hide();
                    form.FormClosed += formclosed;
                    form.Show();
                    return;
                }                
            }            
        }

        public void formclosed(object sender, EventArgs e)
        {
            this.Close();
        }

        //kontrol için yazılacak temel at demiştiniz
        private bool girisKontrol(int kullaniciadi, int sifre)
        {
            bool k = true;
            return k;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SifreSıfırlama form = new SifreSıfırlama();
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

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
