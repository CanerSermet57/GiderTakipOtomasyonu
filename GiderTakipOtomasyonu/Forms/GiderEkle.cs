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
    public partial class GiderEkle : Form
    {
        gtoDbContext dbContext = new gtoDbContext();
        RegexUretici kontrol = new RegexUretici();

        //regex kontrol için değişkenler
        public bool aciklamaKontrol = true;
        public bool kimeKontrol = true;
        public bool tutarKontrol = true;
        public bool odemeTuruIdKontrol = true;
        public bool kategoriIdKontrol = true;


        public GiderEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            regex();

            if (kimeKontrol == true && tutarKontrol == true && odemeTuruIdKontrol == true && kategoriIdKontrol == true)
            {
                GiderlerDbClass gider = new GiderlerDbClass()
                {
                    aciklamasi = textBoxAciklama.Text,
                    kime = textBoxKime.Text,
                    tutar = float.Parse(numericUpDownTutar.Value.ToString()),
                    odemeTuruId = Convert.ToInt32(numericUpDownOdemeTuru.Value.ToString()),
                    kategoriId = Convert.ToInt32(numericUpDownKategori.Value.ToString()),
                    tarih = dateTimePicker1.Value

                };



                dbContext.Giderler.Add(gider);

                int resultKullaniciDb = dbContext.SaveChanges();


                if (resultKullaniciDb > 0)
                {
                    MessageBox.Show("Gider ekleme başarılı");
                }
                else
                {
                    MessageBox.Show("Gider ekleme başarısız");
                }
            }

            
        }



        public void regex()
        {


            //kimden kısmı kontrol
            if (kontrol.regexDuzenle.IsMatch(textBoxKime.Text))
            {
                kimeKontrol = true;
            }
            else
            {
                kimeKontrol = false;
                MessageBox.Show("Kimden kısmının lütfen en az 3 karakter olmasına ve bir harfle başlamasına dikkat edin");
                return;
            }

            //tutar kısmı kontrol
            if (numericUpDownTutar.Value > 0)
            {
                tutarKontrol = true;
            }
            else
            {
                tutarKontrol = false;
                MessageBox.Show("Tutar kısmı 1 den küçük olamaz");
                return;
            }

            //odeme turu id kontrol
            if (numericUpDownOdemeTuru.Value > 0 && numericUpDownOdemeTuru.Value < 50)
            {
                odemeTuruIdKontrol = true;
            }
            else
            {
                odemeTuruIdKontrol = false;
                MessageBox.Show("Odeme turu id kısmı 50 den büyük ya da 1 den küçük olamaz");
                return;
            }

            //kategori id kontroll
            if (numericUpDownKategori.Value > 0 && numericUpDownKategori.Value < 50)
            {
                kategoriIdKontrol = true;
            }
            else
            {
                kategoriIdKontrol = false;
                MessageBox.Show("Kategori id kısmı 50 den büyük ya da 1 den küçük olamaz");
                return;
            }

        }

    }
}
