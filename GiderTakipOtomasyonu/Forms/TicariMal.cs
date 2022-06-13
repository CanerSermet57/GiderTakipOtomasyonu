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
    public partial class TicariMal : Form
    {
        private gtoDbContext dbContext;
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
            form.id = Convert.ToInt32(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[0].Value.ToString());
            form.urunAdi = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[1].Value.ToString();
            form.stokSayisi = float.Parse(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[2].Value.ToString());
            form.fiyat = float.Parse(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[3].Value.ToString());

            form.ShowDialog();
            
        }

        private void TicariMal_Load(object sender, EventArgs e)
        {
            refreshdatagridview();
        }
        public void refreshdatagridview()
        {
            dbContext = new gtoDbContext();
            DGV.DataSource = null;
            var TicariMalListem = dbContext.TicariMallar.ToList();
            DGV.DataSource = TicariMalListem;
        }
    }
}
