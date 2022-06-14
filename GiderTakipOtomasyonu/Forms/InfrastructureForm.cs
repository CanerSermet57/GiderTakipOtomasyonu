using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiderTakipOtomasyonu;
using System.Net.Mail;
using System.Net;
using GiderTakipOtomasyonu.Data;

namespace GiderTakipOtomasyonu.Forms
{
    public partial class InfrastructureForm : Form
    {
        public InfrastructureForm()
        {
            InitializeComponent();
        }
        Panel panelLeft, panelRight;
        

        private void InfrastructureForm_Load(object sender, EventArgs e)
        {
            formInfrastructureStartCodes();
            panelLeft = PageDesign.panelLEFTStartCodes();
            panelRight = PageDesign.panelRIGHTStartCodes();
            PageDesign.buttonLeftCrate();
            
            this.Controls.Add(panelRight);
            this.Controls.Add(panelLeft);
            
            for (int i = 0; i < PageDesign.buttonLeftNumber; i++)
            {
                panelLeft.Controls.Add(PageDesign.buttonLeftPanelList[i]);
            }
            ButtonClickAssignment();
            SayfaButtonlari.Durum durum = new SayfaButtonlari.Durum(panelRight);
        }
    
        public void formInfrastructureStartCodes()
        {
            this.Size = new Size(1200, 620);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.Icon = Icon.ExtractAssociatedIcon()
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }


        public void ButtonClickAssignment()
        {
            for (int i = 0; i < PageDesign.buttonLeftPanelList.Count; i++)
            {
                switch (PageDesign.buttonLeftPanelList[i].Name)
                {
                    case "Durum":
                        PageDesign.buttonLeftPanelList[i].Click += CreateDurumPage;
                        break;

                    case "Cüzdan":
                        PageDesign.buttonLeftPanelList[i].Click += CreateCuzdanPage;
                        break;

                    case "Banka":
                        PageDesign.buttonLeftPanelList[i].Click += CreateBankaPage;
                        break;

                    case "Giderler":
                        PageDesign.buttonLeftPanelList[i].Click += CreateGiderlerPage;
                        break;

                    case "Gelirler":
                        PageDesign.buttonLeftPanelList[i].Click += CreateGelirlerPage;
                        break;

                    case "Kişiler":
                        PageDesign.buttonLeftPanelList[i].Click += CreateKisilerPage;
                        break;

                    case "Takvim":
                        PageDesign.buttonLeftPanelList[i].Click += CreateTakvimPage;
                        break;

                    case "Personel":
                        PageDesign.buttonLeftPanelList[i].Click += CreatePersonelPage;
                        break;

                    case "Fiyatlar":
                        PageDesign.buttonLeftPanelList[i].Click += CreateFiyatlarPage;
                        break;

                    case "Kar-Zarar":
                        PageDesign.buttonLeftPanelList[i].Click += CreateKarZararPage;
                        break;

                    case "Ürünler":
                        PageDesign.buttonLeftPanelList[i].Click += CreateUrunlerPage;
                        break;
                }
            }            
            PageDesign.buttonLeftPanelList[PageDesign.buttonLeftPanelList.Count-1].Click += CreateAyarlarPage;
        }

        public void CreateDurumPage(object sender, EventArgs e)
        {
            SayfaButtonlari.Durum durum = new SayfaButtonlari.Durum(panelRight);
        }
        public void CreateCuzdanPage(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }
        public void CreateBankaPage(object sender, EventArgs e)
        {
            SayfaButtonlari.Banka banka = new SayfaButtonlari.Banka(panelRight);
        }
        public void CreateGiderlerPage(object sender, EventArgs e)
        {
            SayfaButtonlari.Gider gider = new SayfaButtonlari.Gider(panelRight);
        }
        public void CreateGelirlerPage(object sender, EventArgs e)
        {
            SayfaButtonlari.Gelir gelir = new SayfaButtonlari.Gelir(panelRight);
        }
        public void CreateKisilerPage(object sender, EventArgs e)
        {
            SayfaButtonlari.Kisiler kisi = new SayfaButtonlari.Kisiler(panelRight);
        }
        public void CreateTakvimPage(object sender, EventArgs e)
        {
            MessageBox.Show("Takvim Yapım Aşamasındadır");
        }
        public void CreatePersonelPage(object sender, EventArgs e)
        {
            SayfaButtonlari.Personel personel = new SayfaButtonlari.Personel(panelRight);
        }
        public void CreateFiyatlarPage(object sender, EventArgs e)
        {
            SayfaButtonlari.Fiyatlar fiyatlar = new SayfaButtonlari.Fiyatlar(panelRight);
        }
        public void CreateKarZararPage(object sender, EventArgs e)
        {
            MessageBox.Show("Kar-Zarar Yapım Aşamasındadır");
        }
        public void CreateUrunlerPage(object sender, EventArgs e)
        {
            SayfaButtonlari.Urunler urun = new SayfaButtonlari.Urunler(panelRight);
        }
        public void CreateAyarlarPage(object sender, EventArgs e)
        {
            SayfaButtonlari.Ayarlar ayarlar = new SayfaButtonlari.Ayarlar(panelRight);
        }

        


    }   

}
