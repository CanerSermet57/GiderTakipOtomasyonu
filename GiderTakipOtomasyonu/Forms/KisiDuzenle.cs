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
    public partial class KisiDuzenle : Form
    {
        public KisiDuzenle()
        {
            InitializeComponent();
        }
        gtoDbContext dbContext = new gtoDbContext();
        public string
            adi = "",
            adress = "",
            telefon = "",
            faks = "",
            bilgi = "";

        private void textBoxAdres_TextChanged(object sender, EventArgs e)
        {

        }

        public float
            borc = 0,
            alacak = 0;
        public int id = 0;

        private void KisiDuzenle_Load(object sender, EventArgs e)
        {
            textBoxAdi.Text = adi;
            textBoxAdres.Text = adress;
            textBoxTelefon.Text = telefon;
            textBoxFaks.Text = faks;
            textBoxBilgi.Text = bilgi;            
            numericUpDownAlacak.Value = Convert.ToDecimal(alacak);
            numericUpDownBorc.Value = Convert.ToDecimal(borc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var duzenlenecekkisi = new KisiDbClass()
            {
                id = this.id,
                adi = textBoxAdi.Text,
                adres = textBoxAdres.Text,
                alacak = float.Parse(numericUpDownAlacak.Value.ToString()),
                borc = float.Parse(numericUpDownBorc.Value.ToString()),
                bilgi = textBoxBilgi.Text,
                faksNo = textBoxFaks.Text,
                telNo = textBoxTelefon.Text,
            };
            dbContext.Kisiler.Update(duzenlenecekkisi);
            int result = dbContext.SaveChanges();
            string message = result > 0 ? "Başarılı" : "Başarısız";

            MessageBox.Show(message);
        }
    }
}
