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
    public partial class GelirEkle : Form
    {

        gtoDbContext dbContext = new gtoDbContext();

        public GelirEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GelirlerDbClass gelir = new GelirlerDbClass()
            {
                aciklamasi = textBoxAciklama.Text,
                kimden = textBoxKime.Text,
                tutar = float.Parse(numericUpDownTutar.Value.ToString()),
                tarih = dateTimePicker1.Value,
                odemeTuruId = Convert.ToInt32(numericUpDownOdemeTuru.Value.ToString()),
                kategoriId = Convert.ToInt32(numericUpDownKategori.Value.ToString())
            };



            dbContext.Gelirler.Add(gelir);

            int resultKullaniciDb = dbContext.SaveChanges();


            if (resultKullaniciDb > 0)
            {
                MessageBox.Show("Gelir ekleme başarılı");
            }
            else
            {
                MessageBox.Show("Gelir ekleme başarısız");
            }
        }
    }
}
