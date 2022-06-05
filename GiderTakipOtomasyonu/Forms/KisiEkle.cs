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
    public partial class KisiEkle : Form
    {
        public KisiEkle()
        {
            InitializeComponent();
        }
        gtoDbContext dbContext = new gtoDbContext();

        private void button1_Click(object sender, EventArgs e)
        {
            var yenikisi = new KisiDbClass()
            {
                adi = textBoxAdi.Text,
                adres = textBoxAdres.Text,
                alacak = float.Parse(numericUpDownAlacak.Value.ToString()),
                borc = float.Parse(numericUpDownBorc.Value.ToString()),
                bilgi = textBoxBilgi.Text,
                faksNo = textBoxFaks.Text,
                telNo = textBoxTelefon.Text,
            };
            dbContext.Kisiler.Add(yenikisi);
            int result = dbContext.SaveChanges();
            string message = result > 0 ? "Kisi Eklendi" : "Başarısız";
            MessageBox.Show(message);
        }
    }
}
