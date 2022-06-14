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
    public partial class TicariMalEkle : Form
    {
        RegexUretici kontrol = new RegexUretici();
        gtoDbContext dbContext = new gtoDbContext();

        //regex kontrol için değişkenler
        public bool urunAdiKontrol = true;
        public bool fiyatKontrol = true;

        public TicariMalEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            regex();

            if (urunAdiKontrol == true && fiyatKontrol == true)
            {
                var yeniTicariMal = new TicariMallarDbClass()
                {
                    urunAdi = textBoxAdi.Text,
                    stokSayisi = float.Parse(numericStokSayisi.Value.ToString()),
                    fiyat = float.Parse(numericFiyat.Value.ToString())


                };
                dbContext.TicariMallar.Add(yeniTicariMal);
                int result = dbContext.SaveChanges();
                string message = result > 0 ? "Ticari Mal Eklendi" : "Başarısız";
                MessageBox.Show(message);
            }

            
        }

        public void regex()
        {


            //kart adı kısmı kontrol
            if (kontrol.regexBosKontrol.IsMatch(textBoxAdi.Text))
            {
                urunAdiKontrol = true;
            }
            else
            {
                urunAdiKontrol = false;
                MessageBox.Show("Ürün adı kısmının lütfen en az 1 karakter olmasına dikkat edin");
                return;
            }

            //kart no kısmı kontrol
            if (numericFiyat.Value != 0)
            {
                fiyatKontrol = true;
            }
            else
            {
                fiyatKontrol = false;
                MessageBox.Show("Fiyat 0 olamaz");
                return;
            }

        }

    }
}
