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
    public partial class HammaddeEkle : Form
    {
        public HammaddeEkle()
        {
            InitializeComponent();
        }

        gtoDbContext dbContext = new gtoDbContext();

        private void button1_Click(object sender, EventArgs e)
        {            
            var yenihammadde = new HammaddeDbClass()
            {
                
                adi = textBoxAdi.Text,
                agirlik = float.Parse(numericUpDownAgirlik.Text),
                fiyat = float.Parse(numericUpDownFiyat.Text),
                stokSayisi = float.Parse(numericUpDownStok.Text)
            };
            dbContext.Hammaddeler.Add(yenihammadde);
            int result = dbContext.SaveChanges();
            string message = result > 0 ? "Urun Eklendi" : "Başarısız";
            MessageBox.Show(message);            
        }
    }
}
