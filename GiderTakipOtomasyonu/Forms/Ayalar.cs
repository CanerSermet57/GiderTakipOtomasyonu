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
    public partial class Ayalar : Form
    {
        public Ayalar()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked == false)
            {
                (sender as CheckBox).BackColor = Color.DarkRed;
            }
            else
            {
                (sender as CheckBox).BackColor = Color.LightGreen;
            }
            
        }

        private void Ayalar_Load(object sender, EventArgs e)
        {
            gtoDbContext gtoDb = new gtoDbContext();
            var ayarlar = gtoDb.Ayarlar.ToList();

            comboBox1.Text = ayarlar[0].tema;


            bool result;
            result = ayarlar[0].boolBanka == true ? true : false;
            checkBoxBanka.Checked = result;

            result = ayarlar[0].boolCuzdan == true ? true : false;
            checkBoxCuzdan.Checked = result;

            result = ayarlar[0].boolDurum == true ? true : false;
            checkBoxDurum.Checked = result;

            result = ayarlar[0].boolFiyatlar == true ? true : false;
            checkBoxFiyatlar.Checked = result;

            result = ayarlar[0].boolGelir == true ? true : false;
            checkBoxGelirler.Checked = result;

            result = ayarlar[0].boolGider == true ? true : false;
            checkBoxGider.Checked = result;

            result = ayarlar[0].boolHammadde == true ? true : false;
            checkBoxUrunler.Checked = result;

            result = ayarlar[0].boolKarZarar == true ? true : false;
            checkBoxKarZarar.Checked = result;

            result = ayarlar[0].boolKisiler == true ? true : false;
            checkBoxKisiler.Checked = result;

            result = ayarlar[0].boolPersonel == true ? true : false;
            checkBoxBanka.Checked = result;

            result = ayarlar[0].boolTakvim == true ? true : false;
            checkBoxTakvim.Checked = result;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            gtoDbContext gtoDb = new gtoDbContext();
            AyarlarDbClass ayarlarDB = new AyarlarDbClass()
            {
                id = 1,
                alarm = false,
                bildirim = false,
                tema = comboBox1.Text,
                boolBanka = checkBoxBanka.Checked,
                boolCuzdan = checkBoxCuzdan.Checked,
                boolDurum = checkBoxDurum.Checked,
                boolFiyatlar = checkBoxFiyatlar.Checked,
                boolGelir = checkBoxGelirler.Checked,
                boolGider = checkBoxGider.Checked,
                boolHammadde = checkBoxUrunler.Checked,
                boolKarZarar = checkBoxKarZarar.Checked,
                boolKisiler = checkBoxKisiler.Checked,
                boolPersonel = checkBoxPersonel.Checked,
                boolTakvim = checkBoxTakvim.Checked,
                
            };
            gtoDb.Ayarlar.Update(ayarlarDB);
            int result = gtoDb.SaveChanges();
            if (result > 0)
                MessageBox.Show("Ayarlar Kaydedildi");
            else
                MessageBox.Show("HATA");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gtoDbContext gtoDb = new gtoDbContext();
            gtoDb.Database.EnsureDeleted();
            gtoDb.Database.EnsureCreated();
        }
    }
}
