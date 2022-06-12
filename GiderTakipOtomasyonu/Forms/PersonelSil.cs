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
    public partial class PersonelSil : Form
    {
        gtoDbContext dbContext = new gtoDbContext();
        public int id;
        public string adi;
        public string soyAdi;
        public string görevi;
        public float maas;
        public DateTime iseGirisTarihi;
        public string tatilGunu;
        public PersonelSil()
        {
            InitializeComponent();
        }

        private void PersonelSil_Load(object sender, EventArgs e)
        {
            textBoxAdi.Text = adi;
            textBoxSoyadi.Text = soyAdi;
            textBoxGorevi.Text = görevi;
            numericMaas.Value = (decimal)maas;
            dateIseBaslama.Value = iseGirisTarihi;
            comboboxTatilGunu.Text = tatilGunu;
        }
    }
}
