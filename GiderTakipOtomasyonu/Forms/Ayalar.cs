using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiderTakipOtomasyonu.Forms
{
    public partial class Ayalar : Form
    {
        public Ayalar()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked == false)
            {
                (sender as CheckBox).BackColor = Color.DarkRed;
            }
            else
            {
                (sender as CheckBox).BackColor = Color.LightGreen;
            }
            
        }
    }
}
