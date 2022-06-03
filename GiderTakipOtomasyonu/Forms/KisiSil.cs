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
    public partial class KisiSil : Form
    {
        public KisiSil()
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

        private void KisiSil_Load(object sender, EventArgs e)
        {
            textBoxAdi.Text = adi;
            textBoxAdres.Text = adress;
            textBoxTelefon.Text = telefon;
            textBoxFaks.Text = faks;
            textBoxBilgi.Text = bilgi;
            numericUpDownAlacak.Value = Convert.ToDecimal(alacak);
            numericUpDownBorc.Value = Convert.ToDecimal(borc);
        }

        public float
            borc = 0,
            alacak = 0;
        public int id = 0;

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
