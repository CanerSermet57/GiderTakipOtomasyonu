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
    public partial class HammaddeEkle : Form
    {
        RegexUretici kontrol = new RegexUretici();


        //regex kontrol için değişkenler
        public bool adiKontrol = true;
        public bool agirlikKontrol = true;
        public bool fiyatKontrol = true;
        public bool stokSayisiKontrol = true;

        public HammaddeEkle()
        {
            InitializeComponent();
        }

        gtoDbContext dbContext = new gtoDbContext();

        private void button1_Click(object sender, EventArgs e)
        {

            regex();

            if (adiKontrol == true && agirlikKontrol == true && fiyatKontrol == true && stokSayisiKontrol == true)
            {
                var yenihammadde = new HammaddeDbClass()
                {

                    adi = textBoxAdi.Text,
                    agirlik = float.Parse(numericUpDownAgirlik.Text),
                    fiyat = float.Parse(numericUpDownFiyat.Text),
                    stokSayisi = float.Parse(numericUpDownStok.Text)
                };
                dbContext.Hammaddeler.Add(yenihammadde);
                int result = dbContext.SaveChanges();
                string message = result > 0 ? "Urun Eklendi" : "Başarısız";
                MessageBox.Show(message);
            }
            
             
        }

        public void regex()
        {


            //adı kısmı kontrol
            if (kontrol.regexDuzenle.IsMatch(textBoxAdi.Text))
            {
                adiKontrol = true;
            }
            else
            {
                adiKontrol = false;
                MessageBox.Show("Adı kısmının lütfen en az 3 karakter olmasına ve bir harfle başlamasına dikkat edin");
                return;
            }

            //agirlik kısmı kontrol
            if (numericUpDownAgirlik.Value > 0)
            {
                agirlikKontrol = true;
            }
            else
            {
                agirlikKontrol = false;
                MessageBox.Show("Agirlik kısmı 1 den küçük olamaz");
                return;
            }

            //fiyat kontrol
            if (numericUpDownFiyat.Value > 0 && numericUpDownFiyat.Value < 50)
            {
                fiyatKontrol = true;
            }
            else
            {
                fiyatKontrol = false;
                MessageBox.Show("Fiyat 30.000 den büyük ya da 1 den küçük olamaz");
                return;
            }

            //stok sayisi kontrol
            if (numericUpDownStok.Value > 0 && numericUpDownStok.Value < 30000)
            {
                stokSayisiKontrol = true;
            }
            else
            {
                stokSayisiKontrol = false;
                MessageBox.Show("Stok sayısı 30.000 den büyük ya da 1 den küçük olamaz");
                return;
            }
        }


    }
}
