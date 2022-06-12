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
    public partial class PersonelEkle : Form
    {
        gtoDbContext dbContext = new gtoDbContext();
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var yeniPersonel = new PersonelDbClass()
            {
                adi = textBoxAdi.Text,
                soyAdi = textBoxSoyadi.Text,
                görevi = textBoxGorevi.Text,
                maasi = float.Parse(numericMaas.Value.ToString()),
                iseBaslamaTarihi = dateIseBaslama.Value,
                tatilGunu = comboboxTatilGunu.Text
            };
            dbContext.Personeller.Add(yeniPersonel);
            int result = dbContext.SaveChanges();
            string message = result > 0 ? "Personel Eklendi" : "Başarısız";
            MessageBox.Show(message);
        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
