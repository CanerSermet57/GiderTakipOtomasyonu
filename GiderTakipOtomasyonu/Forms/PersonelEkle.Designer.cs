
namespace GiderTakipOtomasyonu.Forms
{
    partial class PersonelEkle
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
            this.comboboxTatilGunu = new System.Windows.Forms.ComboBox();
            this.dateIseBaslama = new System.Windows.Forms.DateTimePicker();
            this.textBoxGorevi = new System.Windows.Forms.TextBox();
            this.textBoxSoyadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericMaas = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // comboboxTatilGunu
            // 
            this.comboboxTatilGunu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxTatilGunu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxTatilGunu.FormattingEnabled = true;
            this.comboboxTatilGunu.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe",
            "Cuma",
            "Cumartesi",
            "Pazar"});
            this.comboboxTatilGunu.Location = new System.Drawing.Point(186, 298);
            this.comboboxTatilGunu.Name = "comboboxTatilGunu";
            this.comboboxTatilGunu.Size = new System.Drawing.Size(286, 32);
            this.comboboxTatilGunu.TabIndex = 67;
            // 
            // dateIseBaslama
            // 
            this.dateIseBaslama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateIseBaslama.Location = new System.Drawing.Point(186, 262);
            this.dateIseBaslama.Name = "dateIseBaslama";
            this.dateIseBaslama.Size = new System.Drawing.Size(286, 29);
            this.dateIseBaslama.TabIndex = 66;
            // 
            // textBoxGorevi
            // 
            this.textBoxGorevi.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxGorevi.Location = new System.Drawing.Point(186, 180);
            this.textBoxGorevi.Name = "textBoxGorevi";
            this.textBoxGorevi.Size = new System.Drawing.Size(286, 32);
            this.textBoxGorevi.TabIndex = 65;
            // 
            // textBoxSoyadi
            // 
            this.textBoxSoyadi.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxSoyadi.Location = new System.Drawing.Point(186, 142);
            this.textBoxSoyadi.Name = "textBoxSoyadi";
            this.textBoxSoyadi.Size = new System.Drawing.Size(286, 32);
            this.textBoxSoyadi.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label7.Location = new System.Drawing.Point(76, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 63;
            this.label7.Text = "Tatil Günü:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label6.Location = new System.Drawing.Point(12, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 25);
            this.label6.TabIndex = 62;
            this.label6.Text = "İşe Başlama Tarihi:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label5.Location = new System.Drawing.Point(105, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 61;
            this.label5.Text = "Görevi:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericMaas
            // 
            this.numericMaas.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numericMaas.Location = new System.Drawing.Point(186, 219);
            this.numericMaas.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericMaas.Name = "numericMaas";
            this.numericMaas.Size = new System.Drawing.Size(286, 32);
            this.numericMaas.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.button1.Location = new System.Drawing.Point(186, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 48);
            this.button1.TabIndex = 60;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.Location = new System.Drawing.Point(110, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 55;
            this.label4.Text = "Maaşı:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(484, 44);
            this.label8.TabIndex = 59;
            this.label8.Text = "Personel Ekle";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.Location = new System.Drawing.Point(40, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(104, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 57;
            this.label2.Text = "Soyadi:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(132, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Adi:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxAdi.Location = new System.Drawing.Point(186, 105);
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(286, 32);
            this.textBoxAdi.TabIndex = 53;
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 431);
            this.Controls.Add(this.comboboxTatilGunu);
            this.Controls.Add(this.dateIseBaslama);
            this.Controls.Add(this.textBoxGorevi);
            this.Controls.Add(this.textBoxSoyadi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericMaas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdi);
            this.Name = "PersonelEkle";
            this.Text = "PersonelEkle";
            this.Load += new System.EventHandler(this.PersonelEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericMaas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboboxTatilGunu;
        private System.Windows.Forms.DateTimePicker dateIseBaslama;
        private System.Windows.Forms.TextBox textBoxGorevi;
        private System.Windows.Forms.TextBox textBoxSoyadi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericMaas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdi;
    }
}