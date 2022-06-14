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

        private void buttonekle_Click(object sender, EventArgs e)
        {
            Forms.KartEkle form = new Forms.KartEkle();
            form.ShowDialog();
            refreshdatagridview();
        }

        private void buttonduzenle_Click(object sender, EventArgs e)
        {
            Forms.KartDuzenle form = new Forms.KartDuzenle();
            form.id = Convert.ToInt32(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[0].Value.ToString());
            form.kartAdi = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[1].Value.ToString();
            form.kartNo = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[2].Value.ToString();
            form.sonKullanmaTarihi = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[3].Value.ToString();
            form.cvcKodu = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[4].Value.ToString();
            form.islemSiniri = Convert.ToInt32(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[5].Value.ToString());
            form.ShowDialog();
            refreshdatagridview();
        }
    }
}
