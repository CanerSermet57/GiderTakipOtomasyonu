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
            PageDesign.buttonLeftPanelList[0].Click += CreateDurumPage;
            PageDesign.buttonLeftPanelList[1].Click += CreateCuzdanPage;
            PageDesign.buttonLeftPanelList[2].Click += CreateBankaPage;
            PageDesign.buttonLeftPanelList[3].Click += CreateGiderlerPage;
            PageDesign.buttonLeftPanelList[4].Click += CreateGelirlerPage;
            PageDesign.buttonLeftPanelList[5].Click += CreateKisilerPage;
            PageDesign.buttonLeftPanelList[6].Click += CreateTakvimPage;
            PageDesign.buttonLeftPanelList[7].Click += CreatePersonelPage;
            PageDesign.buttonLeftPanelList[8].Click += CreateFiyatlarPage;
            PageDesign.buttonLeftPanelList[9].Click += CreateKarZararPage;
            PageDesign.buttonLeftPanelList[10].Click += CreateUrunlerPage;
            PageDesign.buttonLeftPanelList[11].Click += CreateAyarlarPage;
        }

        public void CreateDurumPage(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }
        public void CreateCuzdanPage(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }
        public void CreateBankaPage(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
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
            MessageBox.Show(sender.ToString());
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
            MessageBox.Show(sender.ToString());
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
