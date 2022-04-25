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

namespace GiderTakipOtomasyonu.Forms
{
    public partial class InfrastructureForm : Form
    {
        public InfrastructureForm()
        {
            InitializeComponent();
        }
        

        private void InfrastructureForm_Load(object sender, EventArgs e)
        {
            formInfrastructureStartCodes();

            Panel panelRight = PageDesign.panelRIGHTStartCodes();
            Panel panelLeft = PageDesign.panelLEFTStartCodes();

            List<string> buttonNameList = PageDesign.buttonNameListCreate();
            PageDesign.buttonLeftCrate(buttonNameList);
            
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
            this.Size = new Size(1300, 700);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
            PageDesign.buttonLeftPanelList[10].Click += CreateTicariMalPage;
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
            MessageBox.Show(sender.ToString());
        }
        public void CreateGelirlerPage(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }
        public void CreateKisilerPage(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }
        public void CreateTakvimPage(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }
        public void CreatePersonelPage(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }
        public void CreateFiyatlarPage(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }
        public void CreateKarZararPage(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }
        public void CreateTicariMalPage(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }
        public void CreateAyarlarPage(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }
    }   

}
