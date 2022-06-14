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
    public partial class KisiEkle : Form
    {
        RegexUretici kontrol = new RegexUretici();
        Classes.FormTextController keykontrol = Classes.FormTextController.giveInstance();

        //regex kontrol için değişkenler
        public bool adiKontrol = true;
        public bool telefonKontrol = true;
        


        public KisiEkle()
        {
            InitializeComponent();
        }
        gtoDbContext dbContext = new gtoDbContext();

        private void button1_Click(object sender, EventArgs e)
        {
            regex();

            if (adiKontrol == true && telefonKontrol == true)
            {

                var yenikisi = new KisiDbClass()
                {
                    adi = textBoxAdi.Text,
                    adres = textBoxAdres.Text,
                    alacak = float.Parse(numericUpDownAlacak.Value.ToString()),
                    borc = float.Parse(numericUpDownBorc.Value.ToString()),
                    bilgi = textBoxBilgi.Text,
                    faksNo = textBoxFaks.Text,
                    telNo = textBoxTelefon.Text,
                };
                dbContext.Kisiler.Add(yenikisi);
                int result = dbContext.SaveChanges();
                string message = result > 0 ? "Kisi Eklendi" : "Başarısız";
                MessageBox.Show(message);
            }

            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void regex()
        {


            //adı kısmı kontrol
            if (kontrol.regexAdi.IsMatch(textBoxAdi.Text))
            {
                adiKontrol = true;
            }
            else
            {
                adiKontrol = false;
                MessageBox.Show("Adı kısmının lütfen en az 3 karakter olmasına ve bir harfle başlamasına dikkat edin");
                return;
            }

            //kart no kısmı kontrol
            if (textBoxTelefon.Text!="")
            {
                telefonKontrol = true;
            }
            else
            {
                telefonKontrol = false;
                MessageBox.Show("Telefon kısmının boş bırakmayın");
                return;
            }

            
        }

        private void textBoxTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            keykontrol.vergiDaireNoKontrol(e);
        }

        private void textBoxFaks_KeyPress(object sender, KeyPressEventArgs e)
        {
            keykontrol.vergiDaireNoKontrol(e);
        }
    }
}
