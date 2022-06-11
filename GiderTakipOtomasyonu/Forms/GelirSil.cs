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
    public partial class GelirSil : Form
    {
        gtoDbContext dbContext = new gtoDbContext();


        public string aciklama, kimden;
        public DateTime tarih;
        public float tutar;
        public int odemeTuruId, kategoriId, id;

        private void GelirSil_Load(object sender, EventArgs e)
        {
            textBoxAciklama.Text = aciklama;
            textBoxKime.Text = kimden;
            dateTimePicker1.Value = tarih;
            numericUpDownTutar.Value = (decimal)tutar;
            numericUpDownOdemeTuru.Value = (decimal)odemeTuruId;
            numericUpDownKategori.Value = (decimal)kategoriId;
        }

        public GelirSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GelirlerDbClass gelir = new GelirlerDbClass()
            {
                id = this.id,
                aciklamasi = textBoxAciklama.Text,
                kimden = textBoxKime.Text,
                tutar = float.Parse(numericUpDownTutar.Value.ToString()),
                tarih = dateTimePicker1.Value,
                odemeTuruId = Convert.ToInt32(numericUpDownOdemeTuru.Value.ToString()),
                kategoriId = Convert.ToInt32(numericUpDownKategori.Value.ToString())
                

            };



            dbContext.Gelirler.Remove(gelir);

            int resultKullaniciDb = dbContext.SaveChanges();


            if (resultKullaniciDb > 0)
            {
                MessageBox.Show("Gider Silme başarılı");
            }
            else
            {
                MessageBox.Show("Gider silme başarısız");
            }
        }
    }
}
