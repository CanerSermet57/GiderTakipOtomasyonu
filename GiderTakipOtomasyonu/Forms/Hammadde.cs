using GiderTakipOtomasyonu.Data;
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
    public partial class Hammadde : Form
    {
        private gtoDbContext dbContext;

        public Hammadde()
        {
            InitializeComponent();
        }

        private void Hammadde_Load(object sender, EventArgs e)
        {
            refreshdatagridview();
        }

        public void refreshdatagridview()
        {
            dbContext = new gtoDbContext();
            DGV.DataSource = null;
            var kisilerListesi = dbContext.Hammaddeler.ToList();
            DGV.DataSource = kisilerListesi;
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {

        }
    }
}
