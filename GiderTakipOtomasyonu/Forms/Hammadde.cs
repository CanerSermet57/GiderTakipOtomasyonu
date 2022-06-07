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
            Forms.HammaddeEkle form = new Forms.HammaddeEkle();
            form.ShowDialog();
            refreshdatagridview();
        }

        private void buttonduzenle_Click(object sender, EventArgs e)
        {
            Forms.HammaddeDuzenle form = new Forms.HammaddeDuzenle();
            form.id = Convert.ToInt32(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[0].Value.ToString());
            form.adi = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[1].Value.ToString();
            form.fiyat = float.Parse(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[2].Value.ToString());
            form.agirlik = float.Parse(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[3].Value.ToString());
            form.stokSayisi = float.Parse(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[4].Value.ToString());
            form.ShowDialog();
            refreshdatagridview();
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            Forms.HammadeSil form = new Forms.HammadeSil();
            form.id = Convert.ToInt32(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[0].Value.ToString());
            form.adi = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[1].Value.ToString();
            form.fiyat = float.Parse(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[2].Value.ToString());
            form.agirlik = float.Parse(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[3].Value.ToString());
            form.stokSayisi = float.Parse(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[4].Value.ToString());
            form.ShowDialog();
            refreshdatagridview();
        }
    }
}
