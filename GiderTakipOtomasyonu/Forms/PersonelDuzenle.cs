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
    public partial class PersonelDuzenle : Form
    {
        RegexUretici kontrol = new RegexUretici();
        gtoDbContext dbContext = new gtoDbContext();

        //regex kontrol için değişkenler
        public bool adiKontrol = true;
        public bool soyAdiKontrol = true;
        public bool gorevKontrol = true;
        public bool tatilGunuKontrol = true;

        public int id;
        public string adi;
        public string soyAdi;
        public string görevi;
        public float maas;
        public DateTime iseGirisTarihi;
        public string tatilGunu;
        public PersonelDuzenle()
        {
            InitializeComponent();
        }

        private void PersonelDuzenle_Load(object sender, EventArgs e)
        {
            textBoxAdi.Text = adi;
            textBoxSoyadi.Text = soyAdi;
            textBoxGorevi.Text = görevi;
            numericMaas.Value = (decimal)maas;
            dateIseBaslama.Value = iseGirisTarihi;
            comboboxTatilGunu.Text = tatilGunu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            regex();

            if (adiKontrol == true && soyAdiKontrol == true && gorevKontrol == true && tatilGunuKontrol == true)
            {
                var UptadePersonel = new PersonelDbClass()
                {
                    id = this.id,
                    adi = textBoxAdi.Text,
                    soyAdi = textBoxSoyadi.Text,
                    görevi = textBoxGorevi.Text,
                    maasi = float.Parse(numericMaas.Value.ToString()),
                    iseBaslamaTarihi = dateIseBaslama.Value,
                    tatilGunu = comboboxTatilGunu.Text
                };
                dbContext.Personeller.Update(UptadePersonel);
                int result = dbContext.SaveChanges();
                string message = result > 0 ? "Personel Düzenlendi" : "Başarısız";
                MessageBox.Show(message);
            }

            
        }

        public void regex()
        {


            //Ad kısmı kontrol
            if (kontrol.regexBosKontrol.IsMatch(textBoxAdi.Text))
            {
                adiKontrol = true;
            }
            else
            {
                adiKontrol = false;
                MessageBox.Show("Adı kısmı boş bırakılamaz");
                return;
            }

            //soyadı kısmı kontrol
            if (kontrol.regexBosKontrol.IsMatch(textBoxSoyadi.Text))
            {
                soyAdiKontrol = true;
            }
            else
            {
                soyAdiKontrol = false;
                MessageBox.Show("Soyadı kısmı boş bırakılamaz");
                return;
            }

            //gorev kısmı kontrol
            if (kontrol.regexBosKontrol.IsMatch(textBoxGorevi.Text))
            {
                gorevKontrol = true;
            }
            else
            {
                gorevKontrol = false;
                MessageBox.Show("Görev kısmı boş kalamaz");
                return;
            }


            //tatil günü kontrol
            if (kontrol.regexBosKontrol.IsMatch(comboboxTatilGunu.Text))
            {
                tatilGunuKontrol = true;
            }
            else
            {
                tatilGunuKontrol = false;
                MessageBox.Show("Tatil günü boş bırakılamaz");
                return;
            }
        }

    }
}
