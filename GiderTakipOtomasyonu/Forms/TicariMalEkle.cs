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
    public partial class TicariMalEkle : Form
    {
        gtoDbContext dbContext = new gtoDbContext();
        public TicariMalEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var yeniTicariMal = new TicariMallarDbClass()
            {
                urunAdi = textBoxAdi.Text,
                stokSayisi = float.Parse(numericStokSayisi.Value.ToString()),
                fiyat = float.Parse(numericFiyat.Value.ToString())


            };
            dbContext.TicariMallar.Add(yeniTicariMal);
            int result = dbContext.SaveChanges();
            string message = result > 0 ? "Ticari Mal Eklendi" : "Başarısız";
            MessageBox.Show(message);
        }
    }
}
