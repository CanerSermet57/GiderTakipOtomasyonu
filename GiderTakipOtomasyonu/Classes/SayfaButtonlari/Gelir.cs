using GiderTakipOtomasyonu.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiderTakipOtomasyonu.SayfaButtonlari
{
    class Gelir
    {
        Panel panelRight;

        public Gelir(Panel panelRight)
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
            Button buttonekle = new Button();
            buttonekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonekle.Location = new System.Drawing.Point(100, 10);
            buttonekle.Name = "buttonekle";
            buttonekle.Size = new System.Drawing.Size(200, 40);
            buttonekle.TabIndex = 0;
            buttonekle.Text = "EKLE";
            buttonekle.UseVisualStyleBackColor = true;
            buttonekle.Click += buttonekle_Click;
            panelRight.Controls.Add(buttonekle);
        }

        public void buttonduzenle()
        {
            Button buttonduzenle = new Button();
            buttonduzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonduzenle.Location = new System.Drawing.Point(400, 10);
            buttonduzenle.Name = "buttonduzenle";
            buttonduzenle.Size = new System.Drawing.Size(200, 40);
            buttonduzenle.TabIndex = 0;
            buttonduzenle.Text = "DUZENLE";
            buttonduzenle.UseVisualStyleBackColor = true;
            buttonduzenle.Click += new System.EventHandler(buttonduzenle_Click);
            panelRight.Controls.Add(buttonduzenle);
        }

        public void buttonsil()
        {
            Button buttonsil = new Button();
            buttonsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonsil.Location = new System.Drawing.Point(700, 10);
            buttonsil.Name = "buttonsil";
            buttonsil.Size = new System.Drawing.Size(200, 40);
            buttonsil.TabIndex = 0;
            buttonsil.Text = "SIL";
            buttonsil.UseVisualStyleBackColor = true;
            buttonsil.Click += new System.EventHandler(buttonsil_Click);
            panelRight.Controls.Add(buttonsil);
        }

        public void buttonekle_Click(object sender, EventArgs e)
        {
            Forms.GelirEkle form = new Forms.GelirEkle();
            form.ShowDialog();
            refreshdatagridview();
        }
        public void buttonduzenle_Click(object sender, EventArgs e)
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
        public void buttonsil_Click(object sender, EventArgs e)
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



        public void refreshdatagridview()
        {
            dbContext = new gtoDbContext();
            DGV.DataSource = null;
            var dblistesi = dbContext.Gelirler.ToList();
            DGV.DataSource = dblistesi;
        }
    }
}
