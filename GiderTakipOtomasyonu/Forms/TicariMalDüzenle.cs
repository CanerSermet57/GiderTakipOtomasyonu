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
    public partial class TicariMalDüzenle : Form
    {
        gtoDbContext dbContext = new gtoDbContext();
        public int id;
        public string urunAdi;
        public float stokSayisi;
        public float fiyat;
        public TicariMalDüzenle()
        {
            InitializeComponent();
        }

        private void TicariMalDüzenle_Load(object sender, EventArgs e)
        {
            textBoxAdi.Text = urunAdi;
            numericStokSayisi.Value = (decimal)stokSayisi;
            numericFiyat.Value = (decimal)fiyat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var updateTicariMal = new TicariMallarDbClass()
            {
                id = this.id,
                urunAdi = textBoxAdi.Text,
                stokSayisi = float.Parse(numericStokSayisi.Value.ToString()),
                fiyat = float.Parse(numericFiyat.Value.ToString()),
            };
            dbContext.TicariMallar.Update(updateTicariMal);
            int result = dbContext.SaveChanges();
            string message = result > 0 ? "Ticari Mal Düzenlendi" : "Başarısız";
            MessageBox.Show(message);
        }
    }
}
