using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiderTakipOtomasyonu.Classes;

namespace GiderTakipOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            TempTest();
        }

        public void TempTest()
        {
            FormTextbox formButton = FormTextbox.giveInstance(panel1);
            TextBox bt = (TextBox)formButton.create("test", new Size(50, 50), new Point(200, 200), "TEST");
            try
            {
                TextBox bt2 = (TextBox)formButton.create("test", new Size(150, 50), new Point(300,100), "TEST2");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
