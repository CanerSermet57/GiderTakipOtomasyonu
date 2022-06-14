using GiderTakipOtomasyonu.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiderTakipOtomasyonu.SayfaButtonlari
{
    class Ayarlar
    {
        Panel panelRight;
        GroupBox groupBox;

        public Ayarlar(Panel panelRight)
        {
            this.panelRight = panelRight;
            baslangic();
        }

        public void baslangic()
        {
            panelRight.Controls.Clear();
            groupBoxCreate();
            checkBoxsOlustur();
            panelRight.Controls.Add(groupBox);
            buttonVeriSilCreate();
            buttonKaydetCreate();
            temaCreate();
        }

        static CheckBox checkBoxBanka;
        static CheckBox checkBoxCuzdan;
        static CheckBox checkBoxDurum;
        static CheckBox checkBoxFiyatlar;
        static CheckBox checkBoxGelirler;
        static CheckBox checkBoxGider;
        static CheckBox checkBoxUrunler;
        static CheckBox checkBoxKarZarar;
        static CheckBox checkBoxKisiler;
        static CheckBox checkBoxPersonel;
        static CheckBox checkBoxTakvim;

        public void checkBoxsOlustur()
        {
            gtoDbContext gtoDb = new gtoDbContext();
            var ayarlar = gtoDb.Ayarlar.ToList();
            checkBoxFiyatlar = new CheckBox();
            bool result;
            // 
            // checkBoxFiyatlar
            // 
            checkBoxFiyatlar = new CheckBox();
            checkBoxFiyatlar.AutoSize = true;
            checkBoxFiyatlar.BackColor = System.Drawing.Color.LightGreen;
            checkBoxFiyatlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBoxFiyatlar.Location = new System.Drawing.Point(535, 220);
            checkBoxFiyatlar.Name = "checkBoxFiyatlar";
            checkBoxFiyatlar.Size = new System.Drawing.Size(218, 35);
            checkBoxFiyatlar.TabIndex = 0;
            checkBoxFiyatlar.Text = "Fiyatlar Modülü";
            result = ayarlar[0].boolFiyatlar == true ? true : false;
            checkBoxFiyatlar.Checked = result;
            checkBoxFiyatlar.UseVisualStyleBackColor = false;
            checkBoxFiyatlar.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBoxFiyatlar);
            if (checkBoxFiyatlar.Checked == false)
            {
                checkBoxFiyatlar.BackColor = Color.DarkRed;
            }
            else
            {
                checkBoxFiyatlar.BackColor = Color.LightGreen;
            }
            // 
            // checkBoxKisiler
            // 
            checkBoxKisiler = new CheckBox();
            checkBoxKisiler.AutoSize = true;
            checkBoxKisiler.BackColor = System.Drawing.Color.LightGreen;
            checkBoxKisiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBoxKisiler.Location = new System.Drawing.Point(285, 220);
            checkBoxKisiler.Name = "checkBoxKisiler";
            checkBoxKisiler.Size = new System.Drawing.Size(202, 35);
            checkBoxKisiler.TabIndex = 0;
            checkBoxKisiler.Text = "Kişiler Modülü";
            result = ayarlar[0].boolKisiler == true ? true : false;
            checkBoxKisiler.Checked = result;
            checkBoxKisiler.UseVisualStyleBackColor = false;
            checkBoxKisiler.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBoxKisiler);
            if (checkBoxKisiler.Checked == false)
            {
                checkBoxKisiler.BackColor = Color.DarkRed;
            }
            else
            {
                checkBoxKisiler.BackColor = Color.LightGreen;
            }
            // 
            // checkBoxBanka
            // 
            checkBoxBanka = new CheckBox();
            checkBoxBanka.AutoSize = true;
            checkBoxBanka.BackColor = System.Drawing.Color.LightGreen;
            checkBoxBanka.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBoxBanka.Location = new System.Drawing.Point(35, 220);
            checkBoxBanka.Name = "checkBoxBanka";
            checkBoxBanka.Size = new System.Drawing.Size(205, 35);
            checkBoxBanka.TabIndex = 0;
            checkBoxBanka.Text = "Banka Modülü";
            result = ayarlar[0].boolBanka == true ? true : false;
            checkBoxBanka.Checked = result;
            checkBoxBanka.UseVisualStyleBackColor = false;
            checkBoxBanka.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBoxBanka);
            if (checkBoxBanka.Checked == false)
            {
                checkBoxBanka.BackColor = Color.DarkRed;
            }
            else
            {
                checkBoxBanka.BackColor = Color.LightGreen;
            }
            // 
            // checkBoxUrunler
            // 
            checkBoxUrunler = new CheckBox();
            checkBoxUrunler.AutoSize = true;
            checkBoxUrunler.BackColor = System.Drawing.Color.LightGreen;
            checkBoxUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBoxUrunler.Location = new System.Drawing.Point(785, 140);
            checkBoxUrunler.Name = "checkBoxUrunler";
            checkBoxUrunler.Size = new System.Drawing.Size(217, 35);
            checkBoxUrunler.TabIndex = 0;
            checkBoxUrunler.Text = "Ürünler Modülü";
            result = ayarlar[0].boolHammadde == true ? true : false;
            checkBoxUrunler.Checked = result;
            checkBoxUrunler.UseVisualStyleBackColor = false;
            checkBoxUrunler.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBoxUrunler);
            if (checkBoxUrunler.Checked == false)
            {
                checkBoxUrunler.BackColor = Color.DarkRed;
            }
            else
            {
                checkBoxUrunler.BackColor = Color.LightGreen;
            }
            // 
            // checkBoxPersonel
            // 
            checkBoxPersonel = new CheckBox();
            checkBoxPersonel.AutoSize = true;
            checkBoxPersonel.BackColor = System.Drawing.Color.LightGreen;
            checkBoxPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBoxPersonel.Location = new System.Drawing.Point(535, 140);
            checkBoxPersonel.Name = "checkBoxPersonel";
            checkBoxPersonel.Size = new System.Drawing.Size(235, 35);
            checkBoxPersonel.TabIndex = 0;
            checkBoxPersonel.Text = "Personel Modülü";
            result = ayarlar[0].boolPersonel == true ? true : false;
            checkBoxPersonel.Checked = result;
            checkBoxPersonel.UseVisualStyleBackColor = false;
            checkBoxPersonel.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBoxPersonel);
            if (checkBoxPersonel.Checked == false)
            {
                checkBoxPersonel.BackColor = Color.DarkRed;
            }
            else
            {
                checkBoxPersonel.BackColor = Color.LightGreen;
            }
            // 
            // checkBoxGelirler
            // 
            checkBoxGelirler = new CheckBox();
            checkBoxGelirler.AutoSize = true;
            checkBoxGelirler.BackColor = System.Drawing.Color.LightGreen;
            checkBoxGelirler.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBoxGelirler.Location = new System.Drawing.Point(285, 140);
            checkBoxGelirler.Name = "checkBoxGelirler";
            checkBoxGelirler.Size = new System.Drawing.Size(215, 35);
            checkBoxGelirler.TabIndex = 0;
            checkBoxGelirler.Text = "Gelirler Modülü";
            result = ayarlar[0].boolGelir == true ? true : false;
            checkBoxGelirler.Checked = result;
            checkBoxGelirler.UseVisualStyleBackColor = false;
            checkBoxGelirler.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBoxGelirler);
            if (checkBoxGelirler.Checked == false)
            {
                checkBoxGelirler.BackColor = Color.DarkRed;
            }
            else
            {
                checkBoxGelirler.BackColor = Color.LightGreen;
            }
            // 
            // checkBoxCuzdan
            // 
            checkBoxCuzdan = new CheckBox();
            checkBoxCuzdan.AutoSize = true;
            checkBoxCuzdan.BackColor = System.Drawing.Color.LightGreen;
            checkBoxCuzdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBoxCuzdan.Location = new System.Drawing.Point(35, 140);
            checkBoxCuzdan.Name = "checkBoxCuzdan";
            checkBoxCuzdan.Size = new System.Drawing.Size(222, 35);
            checkBoxCuzdan.TabIndex = 0;
            checkBoxCuzdan.Text = "Cüzdan Modülü";
            result = ayarlar[0].boolCuzdan == true ? true : false;
            checkBoxCuzdan.Checked = result;
            checkBoxCuzdan.UseVisualStyleBackColor = false;
            checkBoxCuzdan.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBoxCuzdan);
            if (checkBoxCuzdan.Checked == false)
            {
                checkBoxCuzdan.BackColor = Color.DarkRed;
            }
            else
            {
                checkBoxCuzdan.BackColor = Color.LightGreen;
            }
            // 
            // checkBoxKarZarar
            // 
            checkBoxKarZarar = new CheckBox();
            checkBoxKarZarar.AutoSize = true;
            checkBoxKarZarar.BackColor = System.Drawing.Color.LightGreen;
            checkBoxKarZarar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBoxKarZarar.Location = new System.Drawing.Point(785, 60);
            checkBoxKarZarar.Name = "checkBoxKarZarar";
            checkBoxKarZarar.Size = new System.Drawing.Size(244, 35);
            checkBoxKarZarar.TabIndex = 0;
            checkBoxKarZarar.Text = "Kar-Zarar Modülü";
            result = ayarlar[0].boolKarZarar == true ? true : false;
            checkBoxKarZarar.Checked = result;
            checkBoxKarZarar.UseVisualStyleBackColor = false;
            checkBoxKarZarar.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBoxKarZarar);
            if (checkBoxKarZarar.Checked == false)
            {
                checkBoxKarZarar.BackColor = Color.DarkRed;
            }
            else
            {
                checkBoxKarZarar.BackColor = Color.LightGreen;
            }
            // 
            // checkBoxTakvim
            // 
            checkBoxTakvim = new CheckBox();
            checkBoxTakvim.AutoSize = true;
            checkBoxTakvim.BackColor = System.Drawing.Color.LightGreen;
            checkBoxTakvim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBoxTakvim.Location = new System.Drawing.Point(535, 60);
            checkBoxTakvim.Name = "checkBoxTakvim";
            checkBoxTakvim.Size = new System.Drawing.Size(216, 35);
            checkBoxTakvim.TabIndex = 0;
            checkBoxTakvim.Text = "Takvim Modülü";
            result = ayarlar[0].boolTakvim == true ? true : false;
            checkBoxTakvim.Checked = result;
            checkBoxTakvim.UseVisualStyleBackColor = false;
            checkBoxTakvim.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBoxTakvim);
            if (checkBoxTakvim.Checked == false)
            {
                checkBoxTakvim.BackColor = Color.DarkRed;
            }
            else
            {
                checkBoxTakvim.BackColor = Color.LightGreen;
            }
            // 
            // checkBoxGider
            // 
            checkBoxGider = new CheckBox();
            checkBoxGider.AutoSize = true;
            checkBoxGider.BackColor = System.Drawing.Color.LightGreen;
            checkBoxGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBoxGider.Location = new System.Drawing.Point(285, 60);
            checkBoxGider.Name = "checkBoxGider";
            checkBoxGider.Size = new System.Drawing.Size(224, 35);
            checkBoxGider.TabIndex = 0;
            checkBoxGider.Text = "Giderler Modülü";
            result = ayarlar[0].boolGider == true ? true : false;
            checkBoxGider.Checked = result;
            checkBoxGider.UseVisualStyleBackColor = false;
            checkBoxGider.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBoxGider);
            if (checkBoxGider.Checked == false)
            {
                checkBoxGider.BackColor = Color.DarkRed;
            }
            else
            {
                checkBoxGider.BackColor = Color.LightGreen;
            }
            // 
            // checkBoxDurum
            // 
            checkBoxDurum = new CheckBox();
            checkBoxDurum.BackColor = System.Drawing.Color.LightGreen;
            checkBoxDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBoxDurum.Location = new System.Drawing.Point(35, 60);
            checkBoxDurum.Name = "checkBoxDurum";
            checkBoxDurum.Size = new System.Drawing.Size(209, 35);
            checkBoxDurum.TabIndex = 0;
            checkBoxDurum.Text = "Durum Modülü";
            result = ayarlar[0].boolDurum == true ? true : false;
            checkBoxDurum.Checked = result;
            checkBoxDurum.UseVisualStyleBackColor = false;
            checkBoxDurum.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBoxDurum);
            if (checkBoxDurum.Checked == false)
            {
                checkBoxDurum.BackColor = Color.DarkRed;
            }
            else
            {
                checkBoxDurum.BackColor = Color.LightGreen;
            }
        }

        public void checkBoxChanged(object sender, EventArgs e)
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

        public void groupBoxCreate()
        {
            groupBox = new GroupBox();
            groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox.Location = new System.Drawing.Point(6, 200);
            groupBox.Name = "groupBox1";
            groupBox.Size = new System.Drawing.Size(1040, 289);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Modüller";
            gtoDbContext gtoDb = new gtoDbContext();
            var tema = gtoDb.Ayarlar.ToList();
            if (tema[0].tema == "Koyu")
            {
                groupBox.BackColor = Color.DarkGray;
            }
            else if (true)
            {
                groupBox.BackColor = Color.Khaki;
            }
        }

        public void buttonVeriSilCreate()
        {
            Button buttonVeriSil = new Button();
            buttonVeriSil.BackColor = System.Drawing.Color.Firebrick;
            buttonVeriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonVeriSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonVeriSil.ForeColor = System.Drawing.SystemColors.HighlightText;
            buttonVeriSil.Location = new System.Drawing.Point(20, 510);
            buttonVeriSil.Name = "button1";
            buttonVeriSil.Size = new System.Drawing.Size(231, 58);
            buttonVeriSil.TabIndex = 2;
            buttonVeriSil.Text = "TÜM VERİLERİ SİL!";
            buttonVeriSil.Click += veriyiSil;
            buttonVeriSil.UseVisualStyleBackColor = false;
            panelRight.Controls.Add(buttonVeriSil);
        }
        public void buttonKaydetCreate()
        {
            Button buttonKaydet = new Button();
            buttonKaydet.BackColor = System.Drawing.SystemColors.InfoText;
            buttonKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonKaydet.ForeColor = System.Drawing.SystemColors.HighlightText;
            buttonKaydet.Location = new System.Drawing.Point(800, 510);
            buttonKaydet.Name = "button14";
            buttonKaydet.Size = new System.Drawing.Size(231, 58);
            buttonKaydet.TabIndex = 2;
            buttonKaydet.Text = "Değişiklikleri Kaydet";
            buttonKaydet.Click += kaydet;
            buttonKaydet.UseVisualStyleBackColor = false;
            panelRight.Controls.Add(buttonKaydet);
        }
        static ComboBox comboBoxTema = null;
        public void temaCreate()
        {
             comboBoxTema = new ComboBox();
            
            comboBoxTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBoxTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboBoxTema.FormattingEnabled = true;
            
            comboBoxTema.Items.AddRange(new object[] {"Koyu","Acik"});
            comboBoxTema.Location = new System.Drawing.Point(116, 38);
            comboBoxTema.Name = "comboBox1";
            comboBoxTema.Size = new System.Drawing.Size(175, 32);
            comboBoxTema.TabIndex = 3;
            gtoDbContext gtoDb = new gtoDbContext();
            var tema = gtoDb.Ayarlar.ToList();
            if (tema[0].tema == "Koyu")
            {
                comboBoxTema.BackColor = Color.DarkGray;
                comboBoxTema.SelectedIndex = 0;
            }
            else if (true)
            {
                comboBoxTema.BackColor = Color.Khaki;
                comboBoxTema.SelectedIndex = 1;
            }
            panelRight.Controls.Add(comboBoxTema);


            Label labelTema = new Label();
            labelTema.AutoSize = true;
            labelTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelTema.Location = new System.Drawing.Point(36, 40);
            labelTema.Name = "label1";
            labelTema.Size = new System.Drawing.Size(74, 25);
            labelTema.TabIndex = 4;
            labelTema.Text = "Tema: ";
            panelRight.Controls.Add(labelTema);
        }

        public static void veriyiSil(object sender, EventArgs e)
        {
            MessageBox.Show("hi");
            gtoDbContext gtoDb = new gtoDbContext();
            gtoDb.Database.EnsureDeleted();
            gtoDb.Database.EnsureCreated();
        }

        

        public static void kaydet(object sender, EventArgs e)
        {
            gtoDbContext gtoDb = new gtoDbContext();
            AyarlarDbClass ayarlarDB = new AyarlarDbClass()
            {
                id = 1,
                alarm = false,
                bildirim = false,
                tema = comboBoxTema.Text,
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
            {
                MessageBox.Show("Ayarlar Kaydedildi");
                Application.Restart();
            }
            else
                MessageBox.Show("HATA");
        }
    }
}
