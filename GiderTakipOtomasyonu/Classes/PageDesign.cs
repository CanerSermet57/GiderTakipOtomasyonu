using GiderTakipOtomasyonu.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiderTakipOtomasyonu
{
    class PageDesign
    {
        static public List<Button> buttonLeftPanelList = new List<Button>();
        static public List<Button> buttonRightPanelList = new List<Button>();
        static public int buttonLeftNumber = 12;
        
        

        static public Panel panelLEFTStartCodes()
        {
            gtoDbContext gtoDb = new gtoDbContext();
            var tema = gtoDb.Ayarlar.ToList();

            Panel panelLeft = new Panel();
            panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(136, 581);
            panelLeft.TabIndex = 2;

            if (tema[0].tema == "Koyu")
            {
                panelLeft.BackColor = SystemColors.HotTrack;
            }
            else if (true)
            {
                panelLeft.BackColor = Color.LightGreen;                
            }

            return panelLeft;
            
        }

        static public Panel panelRIGHTStartCodes()
        {           

            Panel panelRight = new Panel();            
            panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            panelRight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            panelRight.Location = new Point(136, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(1050, 581);
            panelRight.TabIndex = 1;

            gtoDbContext gtoDb = new gtoDbContext();
            var tema = gtoDb.Ayarlar.ToList();
            if (tema[0].tema == "Koyu")
            {
                panelRight.BackColor = SystemColors.ControlDarkDark;
            }
            else if (true)
            {
                panelRight.BackColor = Color.LightBlue;                
            }
            return panelRight;
        }

        static public List<string> buttonNameListCreate()
        {
            List<string> buttonNameList = new List<string>();

            gtoDbContext gtoDb = new gtoDbContext();
            var ayarlar = gtoDb.Ayarlar.ToList();
            bool result;
            if (ayarlar[0].boolDurum)
                buttonNameList.Add("Durum");
            if (ayarlar[0].boolCuzdan)
                buttonNameList.Add("Cüzdan");
            if (ayarlar[0].boolBanka)
                buttonNameList.Add("Banka");
            if (ayarlar[0].boolGider)
                buttonNameList.Add("Giderler");
            if (ayarlar[0].boolGelir)
                buttonNameList.Add("Gelirler");
            if (ayarlar[0].boolKisiler)
                buttonNameList.Add("Kişiler");
            if (ayarlar[0].boolTakvim)
                buttonNameList.Add("Takvim");
            if (ayarlar[0].boolPersonel)
                buttonNameList.Add("Personel");
            if (ayarlar[0].boolFiyatlar)
                buttonNameList.Add("Fiyatlar");
            if (ayarlar[0].boolKarZarar)
                buttonNameList.Add("Kar-Zarar");
            if (ayarlar[0].boolHammadde)
                buttonNameList.Add("Ürünler");
            buttonNameList.Add("Ayarlar");
            buttonLeftNumber = buttonNameList.Count;
            return buttonNameList;
        }

        static public void buttonLeftCrate()
        {
            gtoDbContext gtoDb = new gtoDbContext();
            var tema = gtoDb.Ayarlar.ToList();

            List<string> buttonNameList = buttonNameListCreate();
            Button buttonCode;
            for (int i = 0; i < buttonNameList.Count; i++)
            {
                buttonCode = new Button();
                
                buttonCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                buttonCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                buttonCode.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                buttonCode.ImageAlign = ContentAlignment.MiddleLeft;
                buttonCode.Image = global::GiderTakipOtomasyonu.Properties.Resources.cc301a34b3cd6eaf030f5714137f20ef_4Fk_icon;
                buttonCode.Location = new Point(5, 5 + i * 48);
                buttonCode.Name = buttonNameList[i];
                buttonCode.Size = new Size(170, 42);
                buttonCode.TabIndex = 0;
                buttonCode.Text = buttonNameList[i];
                buttonCode.UseVisualStyleBackColor = false;

                if (tema[0].tema == "Koyu")
                {
                    buttonCode.BackColor = Color.LightGray;
                }
                else if (true)
                {
                    buttonCode.BackColor = Color.LightSeaGreen;
                }


                buttonLeftPanelList.Add(buttonCode);
            }
        }


        public static Button buttonekle()
        {
            gtoDbContext gtoDb = new gtoDbContext();
            var tema = gtoDb.Ayarlar.ToList();
            Button buttonekle = new Button();
            buttonekle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            buttonekle.Location = new Point(100, 10);
            buttonekle.Name = "buttonekle";
            buttonekle.Size = new Size(200, 40);
            buttonekle.FlatStyle = FlatStyle.Flat;
            buttonekle.TabIndex = 0;
            buttonekle.Text = "EKLE";
            buttonekle.UseVisualStyleBackColor = true;

            if (tema[0].tema == "Koyu")
            {
                buttonekle.BackColor = Color.LightGray;
            }
            else if (true)
            {
                buttonekle.BackColor = Color.LightSeaGreen;
            }


            return buttonekle;
        }

        public static Button buttonduzenle()
        {
            gtoDbContext gtoDb = new gtoDbContext();
            var tema = gtoDb.Ayarlar.ToList();
            Button buttonduzenle = new Button();
            buttonduzenle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            buttonduzenle.Location = new Point(400, 10);
            buttonduzenle.Name = "buttonduzenle";
            buttonduzenle.Size = new Size(200, 40);
            buttonduzenle.FlatStyle = FlatStyle.Flat;
            buttonduzenle.TabIndex = 0;
            buttonduzenle.Text = "DUZENLE";
            buttonduzenle.UseVisualStyleBackColor = true;

            if (tema[0].tema == "Koyu")
            {
                buttonduzenle.BackColor = Color.LightGray;
            }
            else if (true)
            {
                buttonduzenle.BackColor = Color.LightSeaGreen;
            }


            return buttonduzenle;
        }

        public static Button buttonsil()
        {
            gtoDbContext gtoDb = new gtoDbContext();
            var tema = gtoDb.Ayarlar.ToList();
            Button buttonsil = new Button();
            buttonsil.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            buttonsil.Location = new Point(700, 10);
            buttonsil.Name = "buttonsil";
            buttonsil.Size = new Size(200, 40);
            buttonsil.TabIndex = 0;
            buttonsil.FlatStyle = FlatStyle.Flat;
            buttonsil.Text = "SIL";
            buttonsil.UseVisualStyleBackColor = true;

            if (tema[0].tema == "Koyu")
            {
                buttonsil.BackColor = Color.LightGray;
            }
            else if (true)
            {
                buttonsil.BackColor = Color.LightSeaGreen;
            }


            return buttonsil;
        }



    }
}
