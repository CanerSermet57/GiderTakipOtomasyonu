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
    public partial class GiderDuzenle : Form
    {
        gtoDbContext dbContext = new gtoDbContext();


        public string aciklama, kime;
        public DateTime tarih;
        public float tutar;
        public int odemeTuru, kategoriId, id;

        private void GiderDuzenle_Load(object sender, EventArgs e)
        {
            textBoxAciklama.Text = aciklama;
            textBoxKime.Text = kime;
            dateTimePicker1.Value = tarih;
            numericUpDownTutar.Value = (decimal)tutar;
            numericUpDownOdemeTuru.Value = (decimal)odemeTuru;
            numericUpDownKategori.Value = (decimal)kategoriId;
        }


        public GiderDuzenle()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            GiderlerDbClass gider = new GiderlerDbClass()
            {
                id = this.id,
                aciklamasi = textBoxAciklama.Text,
                kime = textBoxKime.Text,
                tutar = float.Parse(numericUpDownTutar.Value.ToString()),
                odemeTuruId = Convert.ToInt32(numericUpDownOdemeTuru.Value.ToString()),
                kategoriId = Convert.ToInt32(numericUpDownKategori.Value.ToString()),
                tarih = dateTimePicker1.Value

            };



            dbContext.Giderler.Update(gider);

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
}
