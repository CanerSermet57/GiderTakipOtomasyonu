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
    public partial class GiderEkle : Form
    {
        gtoDbContext dbContext = new gtoDbContext();
        public GiderEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GiderlerDbClass gider = new GiderlerDbClass()
            {
                aciklamasi=textBoxAciklama.Text,
                kime=textBoxKime.Text,
                tutar=float.Parse(numericUpDownTutar.Value.ToString()),
                odemeTuruId = Convert.ToInt32(numericUpDownOdemeTuru.Value.ToString()),
                kategoriId = Convert.ToInt32(numericUpDownKategori.Value.ToString()),
                tarih=dateTimePicker1.Value
                
            };

            

            dbContext.Giderler.Add(gider);

            int resultKullaniciDb = dbContext.SaveChanges();


            if (resultKullaniciDb > 0)
            {
                MessageBox.Show("Kayıt başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt ol başarısız");
            }
        }
    }
}
