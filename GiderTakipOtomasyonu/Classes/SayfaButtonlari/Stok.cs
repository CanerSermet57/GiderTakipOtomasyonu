using GiderTakipOtomasyonu.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiderTakipOtomasyonu.SayfaButtonlari
{
    class Stok
    {
        Panel panelRight;

        public Stok(Panel panelRight)
        {
            this.panelRight = panelRight;
            baslangic();
        }

        private gtoDbContext dbContext;
        DataGridView DGV;

        public void baslangic()
        {
            panelRight.Controls.Clear();
            buttonekle();
            buttonduzenle();
            buttonsil();
            DGVOlustur.DGVMake();
            DGV = DGVOlustur.DGV;
            panelRight.Controls.Add(DGV);
            refreshdatagridview();
        }

        public void buttonekle()
        {
            Button buttonekle = PageDesign.buttonekle();
            buttonekle.Click += buttonekle_Click;
            panelRight.Controls.Add(buttonekle);
        }

        public void buttonduzenle()
        {
            Button buttonduzenle = PageDesign.buttonduzenle();
            buttonduzenle.Click += new System.EventHandler(buttonduzenle_Click);
            panelRight.Controls.Add(buttonduzenle);
        }

        public void buttonsil()
        {
            Button buttonsil = PageDesign.buttonsil();
            buttonsil.Click += new System.EventHandler(buttonsil_Click);
            panelRight.Controls.Add(buttonsil);
        }

        public void buttonekle_Click(object sender, EventArgs e)
        {
            Forms.TicariMalEkle form = new Forms.TicariMalEkle();
            form.ShowDialog();
            refreshdatagridview();
        }
        public void buttonduzenle_Click(object sender, EventArgs e)
        {
            Forms.TicariMalDüzenle form = new Forms.TicariMalDüzenle();
            form.id = Convert.ToInt32(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[0].Value.ToString());
            form.urunAdi = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[1].Value.ToString();
            form.stokSayisi = float.Parse(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[2].Value.ToString());
            form.fiyat = float.Parse(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[3].Value.ToString());
            form.ShowDialog();
            refreshdatagridview();
        }
        public void buttonsil_Click(object sender, EventArgs e)
        {
            Forms.TicariMalSil form = new Forms.TicariMalSil();
            form.id = Convert.ToInt32(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[0].Value.ToString());
            form.urunAdi = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[1].Value.ToString();
            form.stokSayisi = float.Parse(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[2].Value.ToString());
            form.fiyat = float.Parse(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[3].Value.ToString());
            form.ShowDialog();
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
