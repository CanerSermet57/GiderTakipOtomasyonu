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
    public partial class TicariMal : Form
    {
        public TicariMal()
        {
            InitializeComponent();
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            Forms.TicariMalEkle form = new Forms.TicariMalEkle();
            form.ShowDialog();
        }

        private void buttonduzenle_Click(object sender, EventArgs e)
        {
            Forms.TicariMalDüzenle form = new Forms.TicariMalDüzenle();            
            form.ShowDialog();
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            Forms.TicariMalSil form = new Forms.TicariMalSil();
            form.ShowDialog();
            
        }
    }
}
