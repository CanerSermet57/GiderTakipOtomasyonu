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
    public partial class Gelirler : Form
    {
        public Gelirler()
        {
            InitializeComponent();
        }

        private gtoDbContext dbContext;

        private void Gelirler_Load(object sender, EventArgs e)
        {
            refreshdatagridview();
        }
        public void refreshdatagridview()
        {

            /*
            dbContext = new gtoDbContext();
            DGV.DataSource = null;
            var gelirler = dbContext.gelirler.ToList();
            DGV.DataSource = gelirler;

            */
        }
    }
}
