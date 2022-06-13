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

        private gtoDbContext dbContext;

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


        public void checkBoxsOlustur()
        {
            CheckBox checkBox = new CheckBox();
            // 
            // checkBoxFiyatlar
            // 
            checkBox = new CheckBox();
            checkBox.AutoSize = true;
            checkBox.BackColor = System.Drawing.Color.LightGreen;
            checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBox.Location = new System.Drawing.Point(535, 220);
            checkBox.Name = "checkBoxFiyatlar";
            checkBox.Size = new System.Drawing.Size(218, 35);
            checkBox.TabIndex = 0;
            checkBox.Text = "Fiyatlar Modülü";
            checkBox.UseVisualStyleBackColor = false;
            checkBox.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBox);
            // 
            // checkBoxKisiler
            // 
            checkBox = new CheckBox();
            checkBox.AutoSize = true;
            checkBox.BackColor = System.Drawing.Color.LightGreen;
            checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBox.Location = new System.Drawing.Point(285, 220);
            checkBox.Name = "checkBoxKisiler";
            checkBox.Size = new System.Drawing.Size(202, 35);
            checkBox.TabIndex = 0;
            checkBox.Text = "Kişiler Modülü";
            checkBox.UseVisualStyleBackColor = false;
            checkBox.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBox);
            // 
            // checkBoxBanka
            // 
            checkBox = new CheckBox();
            checkBox.AutoSize = true;
            checkBox.BackColor = System.Drawing.Color.LightGreen;
            checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBox.Location = new System.Drawing.Point(35, 220);
            checkBox.Name = "checkBoxBanka";
            checkBox.Size = new System.Drawing.Size(205, 35);
            checkBox.TabIndex = 0;
            checkBox.Text = "Banka Modülü";
            checkBox.UseVisualStyleBackColor = false;
            checkBox.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBox);
            // 
            // checkBoxUrunler
            // 
            checkBox = new CheckBox();
            checkBox.AutoSize = true;
            checkBox.BackColor = System.Drawing.Color.LightGreen;
            checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBox.Location = new System.Drawing.Point(785, 140);
            checkBox.Name = "checkBoxUrunler";
            checkBox.Size = new System.Drawing.Size(217, 35);
            checkBox.TabIndex = 0;
            checkBox.Text = "Ürünler Modülü";
            checkBox.UseVisualStyleBackColor = false;
            checkBox.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBox);
            // 
            // checkBoxPersonel
            // 
            checkBox = new CheckBox();
            checkBox.AutoSize = true;
            checkBox.BackColor = System.Drawing.Color.LightGreen;
            checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBox.Location = new System.Drawing.Point(535, 140);
            checkBox.Name = "checkBoxPersonel";
            checkBox.Size = new System.Drawing.Size(235, 35);
            checkBox.TabIndex = 0;
            checkBox.Text = "Personel Modülü";
            checkBox.UseVisualStyleBackColor = false;
            checkBox.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBox);
            // 
            // checkBoxGelirler
            // 
            checkBox = new CheckBox();
            checkBox.AutoSize = true;
            checkBox.BackColor = System.Drawing.Color.LightGreen;
            checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBox.Location = new System.Drawing.Point(285, 140);
            checkBox.Name = "checkBoxGelirler";
            checkBox.Size = new System.Drawing.Size(215, 35);
            checkBox.TabIndex = 0;
            checkBox.Text = "Gelirler Modülü";
            checkBox.UseVisualStyleBackColor = false;
            checkBox.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBox);
            // 
            // checkBoxCuzdan
            // 
            checkBox = new CheckBox();
            checkBox.AutoSize = true;
            checkBox.BackColor = System.Drawing.Color.LightGreen;
            checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBox.Location = new System.Drawing.Point(35, 140);
            checkBox.Name = "checkBoxCuzdan";
            checkBox.Size = new System.Drawing.Size(222, 35);
            checkBox.TabIndex = 0;
            checkBox.Text = "Cüzdan Modülü";
            checkBox.UseVisualStyleBackColor = false;
            checkBox.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBox);
            // 
            // checkBoxKarZarar
            // 
            checkBox = new CheckBox();
            checkBox.AutoSize = true;
            checkBox.BackColor = System.Drawing.Color.LightGreen;
            checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBox.Location = new System.Drawing.Point(785, 60);
            checkBox.Name = "checkBoxKarZarar";
            checkBox.Size = new System.Drawing.Size(244, 35);
            checkBox.TabIndex = 0;
            checkBox.Text = "Kar-Zarar Modülü";
            checkBox.UseVisualStyleBackColor = false;
            checkBox.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBox);
            // 
            // checkBoxTakvim
            // 
            checkBox = new CheckBox();
            checkBox.AutoSize = true;
            checkBox.BackColor = System.Drawing.Color.LightGreen;
            checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBox.Location = new System.Drawing.Point(535, 60);
            checkBox.Name = "checkBoxTakvim";
            checkBox.Size = new System.Drawing.Size(216, 35);
            checkBox.TabIndex = 0;
            checkBox.Text = "Takvim Modülü";
            checkBox.UseVisualStyleBackColor = false;
            checkBox.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBox);
            // 
            // checkBoxGider
            // 
            checkBox = new CheckBox();
            checkBox.AutoSize = true;
            checkBox.BackColor = System.Drawing.Color.LightGreen;
            checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBox.Location = new System.Drawing.Point(285, 60);
            checkBox.Name = "checkBoxGider";
            checkBox.Size = new System.Drawing.Size(224, 35);
            checkBox.TabIndex = 0;
            checkBox.Text = "Giderler Modülü";
            checkBox.UseVisualStyleBackColor = false;
            checkBox.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBox);
            // 
            // checkBoxDurum
            // 
            checkBox = new CheckBox();
            checkBox.BackColor = System.Drawing.Color.LightGreen;
            checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBox.Location = new System.Drawing.Point(35, 60);
            checkBox.Name = "checkBoxDurum";
            checkBox.Size = new System.Drawing.Size(209, 35);
            checkBox.TabIndex = 0;
            checkBox.Text = "Durum Modülü";
            checkBox.UseVisualStyleBackColor = false;
            checkBox.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            groupBox.Controls.Add(checkBox);
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
            groupBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox.Location = new System.Drawing.Point(6, 200);
            groupBox.Name = "groupBox1";
            groupBox.Size = new System.Drawing.Size(1040, 289);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Modüller";
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
            buttonKaydet.UseVisualStyleBackColor = false;
            panelRight.Controls.Add(buttonKaydet);
        }
        public void temaCreate()
        {
            ComboBox comboBoxTema = new ComboBox();
            comboBoxTema.BackColor = System.Drawing.Color.LightBlue;
            comboBoxTema.Cursor = System.Windows.Forms.Cursors.Arrow;
            comboBoxTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBoxTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboBoxTema.FormattingEnabled = true;
            comboBoxTema.Items.AddRange(new object[] {
            "Koyu Tema",
            "Standart Tema"});
            comboBoxTema.Location = new System.Drawing.Point(116, 38);
            comboBoxTema.Name = "comboBox1";
            comboBoxTema.Size = new System.Drawing.Size(175, 32);
            comboBoxTema.TabIndex = 3;
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
    }
}
