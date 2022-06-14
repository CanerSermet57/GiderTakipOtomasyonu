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
    public partial class Kartlarım : Form
    {
        private gtoDbContext dbContext;

        public Kartlarım()
        {
            InitializeComponent();
        }

        private void Kartlarım_Load(object sender, EventArgs e)
        {
            refreshdatagridview();
        }

        public void refreshdatagridview()
        {


            dbContext = new gtoDbContext();
            DGV.DataSource = null;
            var kartlarim = dbContext.Kartlarım.ToList();
            DGV.DataSource = kartlarim;


        }
    }
}
