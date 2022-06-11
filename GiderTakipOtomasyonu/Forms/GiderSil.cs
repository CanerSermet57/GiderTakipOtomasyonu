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
    public partial class GiderSil : Form
    {

        public string aciklama, kime;
        public DateTime tarih;
        public float tutar;
        public int odemeTuru, kategoriId, id;

        private void GiderSil_Load(object sender, EventArgs e)
        {
            textBoxAciklama.Text = aciklama;
            textBoxKime.Text = kime;
            dateTimePicker1.Value = tarih;
            numericUpDownTutar.Value = (decimal)tutar;
            numericUpDownOdemeTuru.Value = (decimal)odemeTuru;
            numericUpDownKategori.Value = (decimal)kategoriId;

        }

        public GiderSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
