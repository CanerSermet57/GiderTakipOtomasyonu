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
            DGVOlustur();
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


        public void DGVOlustur()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            DGV = new DataGridView();
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray;
            DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            DGV.DefaultCellStyle = dataGridViewCellStyle9;
            DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            DGV.Location = new System.Drawing.Point(15, 60);
            DGV.MultiSelect = false;
            DGV.Name = "DGV";
            DGV.RowHeadersVisible = false;
            DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DGV.Size = new System.Drawing.Size(1020, 510);
            DGV.TabIndex = 11;
            panelRight.Controls.Add(DGV);
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
