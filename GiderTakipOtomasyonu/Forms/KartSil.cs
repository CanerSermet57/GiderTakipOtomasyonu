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
    public partial class KartSil : Form
    {

        gtoDbContext dbContext = new gtoDbContext();
        public string kartAdi, kartNo, sonKullanmaTarihi, cvcKodu;
        public int islemSiniri, id;

        private void KartSil_Load(object sender, EventArgs e)
        {
            textBoxKartAdi.Text = kartAdi;
            textBoxKartNo.Text = kartNo;
            textBoxTarih.Text = sonKullanmaTarihi;
            textBoxCvcKodu.Text = cvcKodu;
            numericUpDownIslemSiniri.Value = (decimal)islemSiniri;
        }

        

        public KartSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KartlarımDbClass kart = new KartlarımDbClass()
            {
                id = this.id,
                kartAdi = textBoxKartAdi.Text,
                kartNo = textBoxKartNo.Text,
                sonKullanmaTarihi = textBoxTarih.Text,
                CVCKodu = textBoxCvcKodu.Text,
                islemSınırı = Convert.ToInt32(numericUpDownIslemSiniri.Value.ToString())

            };

            dbContext.Kartlarım.Remove(kart);

            int resultKullaniciDb = dbContext.SaveChanges();


            if (resultKullaniciDb > 0)
            {
                MessageBox.Show("Kart Silme başarılı");
            }
            else
            {
                MessageBox.Show("Kart silme başarısız");
            }
        }
    }
}
