
namespace GiderTakipOtomasyonu.Forms
{
    partial class GiderEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownTutar = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKime = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownOdemeTuru = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownKategori = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOdemeTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKategori)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownTutar
            // 
            this.numericUpDownTutar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numericUpDownTutar.Location = new System.Drawing.Point(141, 210);
            this.numericUpDownTutar.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownTutar.Name = "numericUpDownTutar";
            this.numericUpDownTutar.Size = new System.Drawing.Size(286, 32);
            this.numericUpDownTutar.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.button1.Location = new System.Drawing.Point(141, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 48);
            this.button1.TabIndex = 45;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.Location = new System.Drawing.Point(72, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Tutar:";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(484, 44);
            this.label8.TabIndex = 44;
            this.label8.Text = "Gider Ekle";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(43, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Açıklama:";
            // 
            // textBoxAciklama
            // 
            this.textBoxAciklama.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxAciklama.Location = new System.Drawing.Point(141, 96);
            this.textBoxAciklama.Name = "textBoxAciklama";
            this.textBoxAciklama.Size = new System.Drawing.Size(286, 32);
            this.textBoxAciklama.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(75, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "Kime:";
            // 
            // textBoxKime
            // 
            this.textBoxKime.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxKime.Location = new System.Drawing.Point(141, 134);
            this.textBoxKime.Name = "textBoxKime";
            this.textBoxKime.Size = new System.Drawing.Size(286, 32);
            this.textBoxKime.TabIndex = 46;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(286, 29);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.Location = new System.Drawing.Point(75, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Tarih:";
            // 
            // numericUpDownOdemeTuru
            // 
            this.numericUpDownOdemeTuru.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numericUpDownOdemeTuru.Location = new System.Drawing.Point(141, 248);
            this.numericUpDownOdemeTuru.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownOdemeTuru.Name = "numericUpDownOdemeTuru";
            this.numericUpDownOdemeTuru.Size = new System.Drawing.Size(286, 32);
            this.numericUpDownOdemeTuru.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label5.Location = new System.Drawing.Point(20, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "Ödemetürü:";
            // 
            // numericUpDownKategori
            // 
            this.numericUpDownKategori.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numericUpDownKategori.Location = new System.Drawing.Point(141, 286);
            this.numericUpDownKategori.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownKategori.Name = "numericUpDownKategori";
            this.numericUpDownKategori.Size = new System.Drawing.Size(286, 32);
            this.numericUpDownKategori.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label6.Location = new System.Drawing.Point(24, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 53;
            this.label6.Text = "Kategori id:";
            // 
            // GiderEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 432);
            this.Controls.Add(this.numericUpDownKategori);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownOdemeTuru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKime);
            this.Controls.Add(this.numericUpDownTutar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAciklama);
            this.Name = "GiderEkle";
            this.Text = "GiderEkle";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOdemeTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKategori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownTutar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownOdemeTuru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownKategori;
        private System.Windows.Forms.Label label6;
    }
}