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

namespace GiderTakipOtomasyonu
{
    public partial class Kisiler : Form
    {
        public Kisiler()
        {
            InitializeComponent();
        }

        gtoDbContext dbContext = new gtoDbContext();

        private void Kisiler_Load(object sender, EventArgs e)
        {
            refreshdatagridview();
        }

        public void refreshdatagridview()
        {
            dbContext = new gtoDbContext();
            DGV.DataSource = null;            
            var kisilerListesi = dbContext.Kisiler.ToList();
            DGV.DataSource = kisilerListesi;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Forms.KisiEkle kisiEkleForm = new Forms.KisiEkle();
            kisiEkleForm.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Forms.KisiDuzenle kisiDuzenleForm = new Forms.KisiDuzenle();
            kisiDuzenleForm.id = Convert.ToInt32(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[0].Value.ToString());
            kisiDuzenleForm.adi = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[1].Value.ToString();
            kisiDuzenleForm.bilgi = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[2].Value.ToString();
            kisiDuzenleForm.adress = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[3].Value.ToString();
            kisiDuzenleForm.faks = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[4].Value.ToString();
            kisiDuzenleForm.telefon = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[5].Value.ToString();
            kisiDuzenleForm.borc = float.Parse(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[6].Value.ToString());
            kisiDuzenleForm.alacak = float.Parse(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[7].Value.ToString());
            kisiDuzenleForm.ShowDialog();
            refreshdatagridview();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Forms.KisiSil kisiSilForm = new Forms.KisiSil();
            kisiSilForm.id = Convert.ToInt32(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[0].Value.ToString());
            kisiSilForm.adi = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[1].Value.ToString();
            kisiSilForm.bilgi = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[2].Value.ToString();
            kisiSilForm.adress = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[3].Value.ToString();
            kisiSilForm.faks = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[4].Value.ToString();
            kisiSilForm.telefon = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[5].Value.ToString();
            kisiSilForm.borc = float.Parse(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[6].Value.ToString());
            kisiSilForm.alacak = float.Parse(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[7].Value.ToString());
            kisiSilForm.ShowDialog();
            refreshdatagridview();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
