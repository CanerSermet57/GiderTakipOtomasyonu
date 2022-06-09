using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiderTakipOtomasyonu
{
    class PageDesign
    {
        static public List<Button> buttonLeftPanelList = new List<Button>();
        static public int buttonLeftNumber = 12;

        static public Panel panelLEFTStartCodes()
        {
            Panel panelLeft = new Panel();
            panelLeft.BackColor = System.Drawing.SystemColors.HotTrack;
            panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            panelLeft.Location = new System.Drawing.Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new System.Drawing.Size(136, 581);
            panelLeft.TabIndex = 2;
            return panelLeft;
        }

        static public Panel panelRIGHTStartCodes()
        {
            Panel panelRight = new Panel();
            panelRight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            panelRight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            panelRight.Location = new System.Drawing.Point(136, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new System.Drawing.Size(1050, 581);
            panelRight.TabIndex = 1;
            return panelRight;
        }

        static public List<string> buttonNameListCreate()
        {
            List<string> buttonNameList = new List<string>();
            buttonNameList.Add("Durum");
            buttonNameList.Add("Cüzdan");
            buttonNameList.Add("Banka");
            buttonNameList.Add("Giderler");
            buttonNameList.Add("Gelirler");
            buttonNameList.Add("Kişiler");
            buttonNameList.Add("Takvim");
            buttonNameList.Add("Personel");
            buttonNameList.Add("Fiyatlar");
            buttonNameList.Add("Kar-Zarar");
            buttonNameList.Add("Ürünler");
            buttonNameList.Add("Ayarlar");
            return buttonNameList;
        }

        static public void buttonLeftCrate(List<string> buttonNameList)
        {
            Button buttontemp;
            for (int i = 0; i < buttonLeftNumber; i++)
            {
                buttontemp = new Button();
                buttontemp.BackColor = System.Drawing.SystemColors.ScrollBar;
                buttontemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                buttontemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                buttontemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                buttontemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                buttontemp.Image = global::GiderTakipOtomasyonu.Properties.Resources.cc301a34b3cd6eaf030f5714137f20ef_4Fk_icon;
                buttontemp.Location = new System.Drawing.Point(5, 5 + i * 48);
                buttontemp.Name = "buttonLeft" + (i + 1).ToString();
                buttontemp.Size = new System.Drawing.Size(170, 42);
                buttontemp.TabIndex = 0;
                buttontemp.Text = buttonNameList[i];
                buttontemp.UseVisualStyleBackColor = false;
                buttonLeftPanelList.Add(buttontemp);
            }
        }
    }
}
