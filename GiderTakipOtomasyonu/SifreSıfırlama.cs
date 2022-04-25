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
    public partial class SifreSıfırlama : Form
    {
        public SifreSıfırlama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            label1.Text = "Doğrulama Kodu";
            button1.Text = "Doğrula";
        }
    }
}
