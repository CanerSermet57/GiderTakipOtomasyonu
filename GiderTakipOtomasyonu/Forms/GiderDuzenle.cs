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
    public partial class GiderDuzenle : Form
    {
        gtoDbContext dbContext = new gtoDbContext();
        RegexUretici kontrol = new RegexUretici();

        public string aciklama, kime;
        public DateTime tarih;
        public float tutar;
        public int odemeTuru, kategoriId, id;

        //regex kontrol için değişkenler
        public bool aciklamaKontrol = true;
        public bool kimeKontrol = true;
        public bool tutarKontrol = true;
        public bool odemeTuruIdKontrol = true;
        public bool kategoriIdKontrol = true;


        private void GiderDuzenle_Load(object sender, EventArgs e)
        {
            textBoxAciklama.Text = aciklama;
            textBoxKime.Text = kime;
            dateTimePicker1.Value = tarih;
            numericUpDownTutar.Value = (decimal)tutar;
            numericUpDownOdemeTuru.Value = (decimal)odemeTuru;
            numericUpDownKategori.Value = (decimal)kategoriId;
        }


        public GiderDuzenle()
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
                    id = this.id,
                    aciklamasi = textBoxAciklama.Text,
                    kime = textBoxKime.Text,
                    tutar = float.Parse(numericUpDownTutar.Value.ToString()),
                    odemeTuruId = Convert.ToInt32(numericUpDownOdemeTuru.Value.ToString()),
                    kategoriId = Convert.ToInt32(numericUpDownKategori.Value.ToString()),
                    tarih = dateTimePicker1.Value

                };



                dbContext.Giderler.Update(gider);

                int resultKullaniciDb = dbContext.SaveChanges();


                if (resultKullaniciDb > 0)
                {
                    MessageBox.Show("Gider Düzenleme başarılı");
                }
                else
                {
                    MessageBox.Show("Gider Düzenleme başarısız");
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
