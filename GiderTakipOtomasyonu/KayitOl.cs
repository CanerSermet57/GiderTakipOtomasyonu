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

namespace GiderTakipOtomasyonu
{
    public partial class KayitOl : Form
    {
        RegexUretici kontrol = new RegexUretici();

        bool kullaniciKontrol = true;
        bool sirketAdiKontrol = true;
        bool sifreKontrol = true;
        bool vergiDaireKontrol = true;
        bool vergiDaireNoKontrol = true;
        bool ePostaKontrol = true;
        



        public KayitOl()
        {
            InitializeComponent();
        }
        gtoDbContext dbContext = new gtoDbContext();
        KullaniciDbContext kullaniciDbContext = new KullaniciDbContext();
        //
        //textbox keypress functions
        //

        Classes.FormTextController formTextController = Classes.FormTextController.giveInstance();

        private void textBoxKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            formTextController.kullaniciAdiKontrol(e);
        }

        private void textBoxSirketAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            formTextController.sirketAdiKontrol(e);
        }

        private void textBoxVergiDaireNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            formTextController.vergiDaireNoKontrol(e);
        }

        private void textBoxEpostaAdresi_KeyPress(object sender, KeyPressEventArgs e)
        {
            formTextController.ePostaKontrol(e);
        }

        private void textBoxSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            formTextController.sifreKontrol(e);
        }

        private void textBoxSifreTekrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            formTextController.sifreKontrol(e);
        }        
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SifreSıfırlama form = new SifreSıfırlama();
            form.Show();
            form.FormClosing += FormClossing;
        }
        */
        private void FormClossing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            
        }

        

        private void buttonKayitOl_Click(object sender, EventArgs e)
        {

            regex();

            //eğer hepsi tamamsa kayıt yapıyor
            if (kullaniciKontrol == true && sifreKontrol==true && ePostaKontrol == true && vergiDaireKontrol == true && vergiDaireNoKontrol == true && sirketAdiKontrol == true && textBoxSifre.Text ==textBoxSifreTekrar.Text )
            {
                KullaniciDbClass kullanici = new KullaniciDbClass()
                {
                    adi = textBoxKullaniciAdi.Text,
                    mail = textBoxEpostaAdresi.Text,
                    sifre = textBoxSifre.Text
                };
                kullaniciDbContext.Kullanicilar.Add(kullanici);
                int resultKullaniciDb = kullaniciDbContext.SaveChanges();
                
                gtoDbContext.staticdbname = kullanici.id.ToString();
                dbContext.Database.EnsureCreated();
                KullaniciDetayDbClass kullaniciDetay = new KullaniciDetayDbClass()
                {
                    adi = textBoxSirketAdi.Text,
                    vergiDairesi = textBoxVergiDairesi.Text,
                    vergiDairesiNo = textBoxVergiDaireNo.Text
                };

                
                dbContext.KullaniciDetay.Add(kullaniciDetay);

                int resultKullaniciDetayDb = dbContext.SaveChanges();
               


                if (resultKullaniciDb > 0 && resultKullaniciDetayDb > 0)
                {
                    MessageBox.Show("Kayıt başarılı");
                }
                else
                {
                    MessageBox.Show("Kayıt ol başarısız");
                }
                this.Close();                
            }

            
        }

        public void regex()
        {
            //kullanıcı adı uygunluğu kontrol
            if (kontrol.regexsadeceyazi.IsMatch(textBoxKullaniciAdi.Text))
            {
                kullaniciKontrol = true;
            }
            else
            {
                kullaniciKontrol = false;
                MessageBox.Show("Kullanıcı adının lütfen en az 6 karakter olmasına ve bir harfle başlamasına dikkat edin");
                return;
            }

            //şirket kontrol
            if (kontrol.regexsadeceyazi.IsMatch(textBoxSirketAdi.Text))
            {
                sirketAdiKontrol = true;
            }
            else
            {
                sirketAdiKontrol = false;
                MessageBox.Show("Şirket adının en az 6 karakter olmasına ve bir harfle başlamasına dikkat edin");
                return;

            }

            //şifre uygunluğunu kontrol ediyor
            if (kontrol.regexsifre.IsMatch(textBoxSifre.Text))
            {
                sifreKontrol = true;
            }
            else
            {
                sifreKontrol = false;
                MessageBox.Show("Şifre hatalı. Şifreniz en az bir büyük karakter, bir küçük karakter, bir sembol ve rakam içerdiğinden emmin olun");
                return;
            }

            //e posta kontrollü için
            if (kontrol.regexEposta.IsMatch(textBoxEpostaAdresi.Text))
            {
                ePostaKontrol = true;
            }
            else
            {
                ePostaKontrol = false;
                MessageBox.Show("E-posta hatalı lütfen yeniden girin");
                return;
            }

            //vergi dairesi kontrolü
            if (kontrol.regexsadeceyazi.IsMatch(textBoxVergiDairesi.Text))
            {
                vergiDaireKontrol = true;
            }
            else
            {
                vergiDaireKontrol = false;
                MessageBox.Show("Vergi dairesi en 6 karakter içermeli");
                return;
            }

            //vergi daire no kontrol
            if (textBoxVergiDaireNo.Text != "")
            {
                vergiDaireNoKontrol = true;
            }
            else
            {
                vergiDaireNoKontrol = false;
                MessageBox.Show("Vergi dairesi no boş olamaz");
                return;
            }


            if (textBoxSifre.Text != textBoxSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler aynı değil");
            }
        }
    }


}
