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
    public partial class TicariMalDüzenle : Form
    {
        RegexUretici kontrol = new RegexUretici();

        //regex kontrol için değişkenler
        public bool urunAdiKontrol = true;
        public bool fiyatKontrol = true;

        gtoDbContext dbContext = new gtoDbContext();
        public int id;
        public string urunAdi;
        public float stokSayisi;
        public float fiyat;
        public TicariMalDüzenle()
        {
            InitializeComponent();
        }

        private void TicariMalDüzenle_Load(object sender, EventArgs e)
        {
            textBoxAdi.Text = urunAdi;
            numericStokSayisi.Value = (decimal)stokSayisi;
            numericFiyat.Value = (decimal)fiyat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            regex();

            if (urunAdiKontrol == true && fiyatKontrol == true)
            {
                var updateTicariMal = new TicariMallarDbClass()
                {
                    id = this.id,
                    urunAdi = textBoxAdi.Text,
                    stokSayisi = float.Parse(numericStokSayisi.Value.ToString()),
                    fiyat = float.Parse(numericFiyat.Value.ToString()),
                };
                dbContext.TicariMallar.Update(updateTicariMal);
                int result = dbContext.SaveChanges();
                string message = result > 0 ? "Ticari Mal Düzenlendi" : "Başarısız";
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
            if (numericFiyat.Value!=0)
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
