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
            exampleLabelCreate();
            exampleTextBoxCreate();
            exampleButtonCreate();
        }

        public void exampleLabelCreate()
        {
            FormLabel formButton = FormLabel.giveInstance(panel1);
            Label bt = (Label)formButton.create("test", new Size(50, 50), new Point(200, 200), "TEST");
        }
        public void exampleTextBoxCreate()
        {
            FormTextbox formButton = FormTextbox.giveInstance(panel1);
            TextBox bt = (TextBox)formButton.create("test", new Size(50, 50), new Point(400, 200), "TEST");
        }
        public void exampleButtonCreate()
        {
            FormButton formButton = FormButton.giveInstance(panel1);
            Button bt = (Button)formButton.create("test", new Size(50, 50), new Point(600, 200), "TEST");
        }



        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
