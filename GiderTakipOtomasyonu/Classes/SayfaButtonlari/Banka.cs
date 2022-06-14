using GiderTakipOtomasyonu.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiderTakipOtomasyonu.SayfaButtonlari
{
    class Banka
    {
        Panel panelRight;

        public Banka(Panel panelRight)
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
            Forms.KartEkle form = new Forms.KartEkle();
            form.ShowDialog();
            refreshdatagridview();
        }
        public void buttonduzenle_Click(object sender, EventArgs e)
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
        public void buttonsil_Click(object sender, EventArgs e)
        {
            Forms.KartSil form = new Forms.KartSil();
            form.id = Convert.ToInt32(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[0].Value.ToString());
            form.kartAdi = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[1].Value.ToString();
            form.kartNo = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[2].Value.ToString();
            form.sonKullanmaTarihi = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[3].Value.ToString();
            form.cvcKodu = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[4].Value.ToString();
            form.islemSiniri = Convert.ToInt32(DGV.Rows[DGV.CurrentCell.RowIndex].Cells[5].Value.ToString());
            form.ShowDialog();
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
