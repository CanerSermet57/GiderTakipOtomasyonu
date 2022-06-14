
namespace GiderTakipOtomasyonu.Forms
{
    partial class KartEkle
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKartNo = new System.Windows.Forms.TextBox();
            this.numericUpDownIslemSiniri = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKartAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCvcKodu = new System.Windows.Forms.TextBox();
            this.textBoxTarih = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIslemSiniri)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(37, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 75;
            this.label2.Text = "Kart No:";
            // 
            // textBoxKartNo
            // 
            this.textBoxKartNo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxKartNo.Location = new System.Drawing.Point(123, 119);
            this.textBoxKartNo.Name = "textBoxKartNo";
            this.textBoxKartNo.Size = new System.Drawing.Size(286, 32);
            this.textBoxKartNo.TabIndex = 74;
            this.textBoxKartNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKartNo_KeyPress);
            // 
            // numericUpDownIslemSiniri
            // 
            this.numericUpDownIslemSiniri.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numericUpDownIslemSiniri.Location = new System.Drawing.Point(123, 230);
            this.numericUpDownIslemSiniri.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownIslemSiniri.Name = "numericUpDownIslemSiniri";
            this.numericUpDownIslemSiniri.Size = new System.Drawing.Size(286, 32);
            this.numericUpDownIslemSiniri.TabIndex = 69;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.button1.Location = new System.Drawing.Point(123, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 48);
            this.button1.TabIndex = 73;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.Location = new System.Drawing.Point(9, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 70;
            this.label4.Text = "İşlem Sınırı:";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(514, 44);
            this.label8.TabIndex = 72;
            this.label8.Text = "Kart Ekle";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(34, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "Kart Adı:";
            // 
            // textBoxKartAdi
            // 
            this.textBoxKartAdi.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxKartAdi.Location = new System.Drawing.Point(123, 81);
            this.textBoxKartAdi.Name = "textBoxKartAdi";
            this.textBoxKartAdi.Size = new System.Drawing.Size(286, 32);
            this.textBoxKartAdi.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label5.Location = new System.Drawing.Point(60, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 83;
            this.label5.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.Location = new System.Drawing.Point(16, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 85;
            this.label3.Text = "CVC Kodu:";
            // 
            // textBoxCvcKodu
            // 
            this.textBoxCvcKodu.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxCvcKodu.Location = new System.Drawing.Point(123, 192);
            this.textBoxCvcKodu.Name = "textBoxCvcKodu";
            this.textBoxCvcKodu.Size = new System.Drawing.Size(286, 32);
            this.textBoxCvcKodu.TabIndex = 84;
            this.textBoxCvcKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCvcKodu_KeyPress);
            // 
            // textBoxTarih
            // 
            this.textBoxTarih.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxTarih.Location = new System.Drawing.Point(123, 154);
            this.textBoxTarih.Name = "textBoxTarih";
            this.textBoxTarih.Size = new System.Drawing.Size(286, 32);
            this.textBoxTarih.TabIndex = 86;
            // 
            // KartEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 361);
            this.Controls.Add(this.textBoxTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCvcKodu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKartNo);
            this.Controls.Add(this.numericUpDownIslemSiniri);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKartAdi);
            this.Name = "KartEkle";
            this.Text = "KartEkle";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIslemSiniri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKartNo;
        private System.Windows.Forms.NumericUpDown numericUpDownIslemSiniri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKartAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCvcKodu;
        private System.Windows.Forms.TextBox textBoxTarih;
    }
}