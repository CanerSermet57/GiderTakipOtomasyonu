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
    public partial class GelirDuzenle : Form
    {
        gtoDbContext dbContext = new gtoDbContext();
        RegexUretici kontrol = new RegexUretici();

        public string aciklama, kimden;
        public DateTime tarih;
        public float tutar;
        public int odemeTuruId, kategoriId, id;


        //regex kontrol için değişkenler
        public bool aciklamaKontrol = true;
        public bool kimdenKontrol = true;
        public bool tutarKontrol = true;
        public bool odemeTuruIdKontrol = true;
        public bool kategoriIdKontrol = true;
        

        private void GelirDuzenle_Load(object sender, EventArgs e)
        {
            textBoxAciklama.Text = aciklama;
            textBoxKime.Text = kimden;
            numericUpDownTutar.Value = (decimal)tutar;
            dateTimePicker1.Value = tarih;
            numericUpDownOdemeTuru.Value = (decimal)odemeTuruId;
            numericUpDownKategori.Value = (decimal)kategoriId;
        }

        public GelirDuzenle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            regex();


            if (aciklamaKontrol == true && kimdenKontrol == true && tutarKontrol == true && odemeTuruIdKontrol == true && kategoriIdKontrol == true )
            {

                GelirlerDbClass gelir = new GelirlerDbClass()
                {
                    id = this.id,
                    aciklamasi = textBoxAciklama.Text,
                    kimden = textBoxKime.Text,
                    tutar = float.Parse(numericUpDownTutar.Value.ToString()),
                    tarih = dateTimePicker1.Value,
                    odemeTuruId = Convert.ToInt32(numericUpDownOdemeTuru.Value.ToString()),
                    kategoriId = Convert.ToInt32(numericUpDownKategori.Value.ToString())


                };



                dbContext.Gelirler.Update(gelir);

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
            //aciklama uygunluğu kontrol
            if (kontrol.regexDuzenle.IsMatch(textBoxAciklama.Text))
            {
                aciklamaKontrol = true;
            }
            else
            {
                aciklamaKontrol = false;
                MessageBox.Show("Açıklama kısmının lütfen en az 6 karakter olmasına ve bir harfle başlamasına dikkat edin");
                return;
            }

            //kimden kısmı kontrol
            if (kontrol.regexDuzenle.IsMatch(textBoxKime.Text))
            {
                kimdenKontrol = true;
            }
            else
            {
                kimdenKontrol = false;
                MessageBox.Show("Kimden kısmının lütfen en az 6 karakter olmasına ve bir harfle başlamasına dikkat edin");
                return;
            }

            //tutar kısmı kontrol
            if (numericUpDownTutar.Value>0)
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
            if (numericUpDownOdemeTuru.Value > 0 || numericUpDownOdemeTuru.Value < 50)
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
            if (numericUpDownKategori.Value > 0 || numericUpDownKategori.Value < 50)
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
