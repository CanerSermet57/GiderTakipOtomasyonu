using GiderTakipOtomasyonu.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiderTakipOtomasyonu.SayfaButtonlari
{
    class Kisiler
    {
        Panel panelRight;

        public Kisiler(Panel panelRight)
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
            Forms.KisiEkle kisiEkleForm = new Forms.KisiEkle();
            kisiEkleForm.ShowDialog();
            refreshdatagridview();
        }
        public void buttonduzenle_Click(object sender, EventArgs e)
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
        public void buttonsil_Click(object sender, EventArgs e)
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


        
        public void refreshdatagridview()
        {
            dbContext = new gtoDbContext();
            DGV.DataSource = null;
            var kisilerListesi = dbContext.Kisiler.ToList();
            DGV.DataSource = kisilerListesi;
        }
    }
}
