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
    public partial class KartEkle : Form
    {
        gtoDbContext dbContext = new gtoDbContext();

        public KartEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KartlarımDbClass kartlarım = new KartlarımDbClass()
            {
                kartAdı = textBoxKartAdi.Text,
                kartNo = textBoxKartNo.Text,
                sonKullanmaTarihi = textBoxTarih.Text,
                CVCKodu = textBoxCvcKodu.Text,
                islemSınırı = Convert.ToInt32(numericUpDownIslemSiniri.Value.ToString()),
                
            };

            dbContext.Kartlarım.Add(kartlarım);

            int resultKullaniciDb = dbContext.SaveChanges();


            if (resultKullaniciDb > 0)
            {
                MessageBox.Show("Kart ekleme başarılı");
            }
            else
            {
                MessageBox.Show("Kart ekleme başarısız");
            }
        }
    }
}
