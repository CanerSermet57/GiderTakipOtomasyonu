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
    public partial class Giderler : Form
    {
        private gtoDbContext dbContext;

        public Giderler()
        {
            InitializeComponent();
        }

        private void Giderler_Load(object sender, EventArgs e)
        {
            refreshdatagridview();
        }

        public void refreshdatagridview()
        {

            
            dbContext = new gtoDbContext();
            DGV.DataSource = null;
            var giderler = dbContext.Giderler.ToList();
            DGV.DataSource = giderler;

           
        }
    }
}
