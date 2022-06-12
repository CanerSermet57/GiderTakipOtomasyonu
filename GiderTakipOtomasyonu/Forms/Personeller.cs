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
    public partial class Personeller : Form
    {
        private gtoDbContext dbContext;
        public Personeller()
        {
            InitializeComponent();
        }

        

        private void Personeller_Load(object sender, EventArgs e)
        {
            refreshdatagridview();
        }
        public void refreshdatagridview()
        {
            dbContext = new gtoDbContext();
            DGV.DataSource = null;
            var personelListesi = dbContext.Personeller.ToList();
            DGV.DataSource = personelListesi;
        }


        private void buttonekle_Click(object sender, EventArgs e)
        {
            Forms.PersonelEkle form = new Forms.PersonelEkle();
            form.ShowDialog();
            refreshdatagridview();
        }
        private void buttonduzenle_Click(object sender, EventArgs e)
        {
            Forms.PersonelDuzenle form = new Forms.PersonelDuzenle();
            form.id = Convert.ToInt32(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[0].Value.ToString());
            form.adi = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[1].Value.ToString();
            form.soyAdi = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[2].Value.ToString();
            form.görevi = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[3].Value.ToString();
            form.maas = float.Parse(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[4].Value.ToString());
            form.iseGirisTarihi = (DateTime)DGV.Rows[DGV.CurrentCell.RowIndex].Cells[5].Value;
            form.tatilGunu = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[6].Value.ToString();
            form.ShowDialog();
            refreshdatagridview();

        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            Forms.PersonelSil form = new Forms.PersonelSil();
            form.id = Convert.ToInt32(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[0].Value.ToString());
            form.adi = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[1].Value.ToString();
            form.soyAdi = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[2].Value.ToString();
            form.görevi = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[3].Value.ToString();
            form.maas = float.Parse(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[4].Value.ToString());
            form.iseGirisTarihi = (DateTime)DGV.Rows[DGV.CurrentCell.RowIndex].Cells[5].Value;
            form.tatilGunu = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[6].Value.ToString();
            form.ShowDialog();
        }
    }
}
