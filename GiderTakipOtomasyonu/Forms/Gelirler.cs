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

            
            dbContext = new gtoDbContext();
            DGV.DataSource = null;
            var gelirler = dbContext.Gelirler.ToList();
            DGV.DataSource = gelirler;

            
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            Forms.GelirEkle form = new Forms.GelirEkle();
            form.ShowDialog();
            refreshdatagridview();
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            Forms.GelirSil form = new Forms.GelirSil();
            form.id = Convert.ToInt32(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[0].Value.ToString());
            form.aciklama = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[1].Value.ToString();
            form.kimden = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[2].Value.ToString();
            form.tarih = (DateTime)DGV.Rows[DGV.CurrentCell.RowIndex].Cells[4].Value;
            form.tutar = float.Parse(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[3].Value.ToString());
            form.odemeTuruId = Convert.ToInt32(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[6].Value.ToString());
            form.kategoriId = Convert.ToInt32(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[8].Value.ToString());
            form.ShowDialog();
            refreshdatagridview();
        }

        private void buttonduzenle_Click(object sender, EventArgs e)
        {
            Forms.GelirDuzenle form = new Forms.GelirDuzenle();
            form.id = Convert.ToInt32(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[0].Value.ToString());
            form.aciklama = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[1].Value.ToString();
            form.kimden = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[2].Value.ToString();
            form.tarih = (DateTime)DGV.Rows[DGV.CurrentCell.RowIndex].Cells[4].Value;
            form.tutar = float.Parse(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[3].Value.ToString());
            form.odemeTuruId = Convert.ToInt32(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[6].Value.ToString());
            form.kategoriId = Convert.ToInt32(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[8].Value.ToString());
            form.ShowDialog();
            refreshdatagridview();
        }
    }
}
