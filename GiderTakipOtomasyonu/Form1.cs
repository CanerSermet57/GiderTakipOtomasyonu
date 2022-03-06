using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        Button b;
        private void button2_Click(object sender, EventArgs e)
        {
            Classes.DerivedClasses.FormButton formButton = Classes.DerivedClasses.FormButton.giveInstance(panel1);
            Button bt =(Button) formButton.create("test",new Size(50,50),new Point(200,200));
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
