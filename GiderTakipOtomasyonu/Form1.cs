using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            examplePictureBoxCreate();
            exampleNumericUpDownCreate();
        }

        public void exampleLabelCreate()
        {
            FormLabel formnesne = FormLabel.giveInstance(panel1);
            Label nesne = (Label)formnesne.create("test", new Size(50, 50), new Point(200, 200), "TEST");
        }
        public void exampleTextBoxCreate()
        {
            FormTextbox formnesne = FormTextbox.giveInstance(panel1);
            TextBox nesne = (TextBox)formnesne.create("test", new Size(50, 50), new Point(400, 200), "TEST");
        }
        public void exampleButtonCreate()
        {
            FormButton formnesne = FormButton.giveInstance(panel1);
            Button nesne = (Button)formnesne.create("test", new Size(50, 50), new Point(600, 200), "TEST");
        }
        public void examplePictureBoxCreate()
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri("https://i0.wp.com/shindekudasai.com/wp-content/uploads/2022/02/portada_yofukashi-no-uta-3.jpg"), System.IO.Path.GetTempPath() + "image.png");
            }
            FormPictureBox formnesne = FormPictureBox.giveInstance(panel1);
            PictureBox nesne = (PictureBox)formnesne.create("test", new Size(400, 250), new Point(700, 50),Image.FromFile(System.IO.Path.GetTempPath() + "image.png"),PictureBoxSizeMode.StretchImage);
        }
        public void exampleNumericUpDownCreate()
        {
            FormNumericUpDown formnesne = FormNumericUpDown.giveInstance(panel1);
            NumericUpDown nesne = (NumericUpDown)formnesne.create("test", new Size(50, 50), new Point(600, 400), 55);
        }



        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
