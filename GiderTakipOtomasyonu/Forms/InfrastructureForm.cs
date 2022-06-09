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
            Panel panelLeft = PageDesign.panelLEFTStartCodes();
            Panel panelRight = PageDesign.panelRIGHTStartCodes();
            

            List<string> buttonNameList = PageDesign.buttonNameListCreate();
            PageDesign.buttonLeftCrate(buttonNameList);
            
            this.Controls.Add(panelRight);
            this.Controls.Add(panelLeft);
            
            for (int i = 0; i < PageDesign.buttonLeftNumber; i++)
            {
                panelLeft.Controls.Add(PageDesign.buttonLeftPanelList[i]);
            }
            //ButtonClickAssignment();
        }
    
        public void formInfrastructureStartCodes()
        {
            this.Size = new Size(1200, 620);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.Icon = Icon.ExtractAssociatedIcon()
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }      

        
    }   

}
