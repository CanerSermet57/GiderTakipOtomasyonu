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
    public partial class KartDuzenle : Form
    {
        gtoDbContext dbContext = new gtoDbContext();
        RegexUretici kontrol = new RegexUretici();
        Classes.FormTextController keykontrol = Classes.FormTextController.giveInstance();


        //regex kontrol için değişkenler
        public bool kartAdiKontrol = true;
        public bool kartNoKontrol = true;
        public bool tarihKontrol = true;
        public bool cvcKontrol = true;
        public bool islemSiniriKontrol = true;


        public string kartAdi, kartNo, sonKullanmaTarihi, cvcKodu;

        public int islemSiniri,id;

        private void textBoxKartNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            keykontrol.vergiDaireNoKontrol(e);
        }

        private void textBoxCvcKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            keykontrol.vergiDaireNoKontrol(e);
        }

        private void KartDuzenle_Load(object sender, EventArgs e)
        {
            textBoxKartAdi.Text = kartAdi;
            textBoxKartNo.Text = kartNo;
            textBoxTarih.Text = sonKullanmaTarihi;
            textBoxCvcKodu.Text = cvcKodu;
            numericUpDownIslemSiniri.Value = (decimal)islemSiniri;
        }

        

        public KartDuzenle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            regex();

            if (kartAdiKontrol == true && kartNoKontrol == true && cvcKontrol == true && islemSiniriKontrol == true && tarihKontrol == true)
            {
                KartlarımDbClass kartlarim = new KartlarımDbClass()
                {
                    id = this.id,
                    kartAdi = textBoxKartAdi.Text,
                    kartNo = textBoxKartNo.Text,
                    sonKullanmaTarihi = textBoxTarih.Text,
                    CVCKodu = textBoxCvcKodu.Text,
                    islemSınırı = Convert.ToInt32(numericUpDownIslemSiniri.Value.ToString())

                };

                dbContext.Kartlarım.Update(kartlarim);

                int resultKullaniciDb = dbContext.SaveChanges();


                if (resultKullaniciDb > 0)
                {
                    MessageBox.Show("Kart Düzenleme başarılı");
                }
                else
                {
                    MessageBox.Show("Kart Düzenleme başarısız");
                }
            }

            
        }

        public void regex()
        {


            //kart adı kısmı kontrol
            if (kontrol.regexDuzenle.IsMatch(textBoxKartAdi.Text))
            {
                kartAdiKontrol = true;
            }
            else
            {
                kartAdiKontrol = false;
                MessageBox.Show("Kart adı kısmının lütfen en az 3 karakter olmasına ve bir harfle başlamasına dikkat edin");
                return;
            }

            //kart no kısmı kontrol
            if (kontrol.regexKartNo.IsMatch(textBoxKartNo.Text))
            {
                kartNoKontrol = true;
            }
            else
            {
                kartNoKontrol = false;
                MessageBox.Show("Kart no kısmının lütfen en az 16 karakter olmasına dikkat edin");
                return;
            }

            //tarih kısmı kontrol
            if (textBoxTarih.Text != "")
            {
                tarihKontrol = true;
            }
            else
            {
                tarihKontrol = false;
                MessageBox.Show("Tarih kısmı boş kalamaz");
                return;
            }

            //cvc kontrol
            if (kontrol.regexCvc.IsMatch(textBoxCvcKodu.Text))
            {
                cvcKontrol = true;
            }
            else
            {
                cvcKontrol = false;
                MessageBox.Show("CVC kısmının lütfen en az 3 karakter olmasına ve bir harfle başlamasına dikkat edin");
                return;
            }

            //işlem sınırı kontrol
            if (numericUpDownIslemSiniri.Value >= 0 && numericUpDownIslemSiniri.Value < 30000)
            {
                islemSiniriKontrol = true;
            }
            else
            {
                islemSiniriKontrol = false;
                MessageBox.Show("İşlem sınırı 30.000 den büyük veya 0 dan küçük olamaz");
                return;
            }
        }


    }
}
