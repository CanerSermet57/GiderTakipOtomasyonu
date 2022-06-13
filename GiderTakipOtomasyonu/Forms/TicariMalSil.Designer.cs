
namespace GiderTakipOtomasyonu.Forms
{
    partial class TicariMalSil
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
            this.numericFiyat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericStokSayisi = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStokSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // numericFiyat
            // 
            this.numericFiyat.Enabled = false;
            this.numericFiyat.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numericFiyat.Location = new System.Drawing.Point(127, 183);
            this.numericFiyat.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericFiyat.Name = "numericFiyat";
            this.numericFiyat.Size = new System.Drawing.Size(286, 32);
            this.numericFiyat.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(66, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 86;
            this.label2.Text = "Fiyat:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericStokSayisi
            // 
            this.numericStokSayisi.Enabled = false;
            this.numericStokSayisi.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numericStokSayisi.Location = new System.Drawing.Point(127, 143);
            this.numericStokSayisi.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericStokSayisi.Name = "numericStokSayisi";
            this.numericStokSayisi.Size = new System.Drawing.Size(286, 32);
            this.numericStokSayisi.TabIndex = 79;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.button1.Location = new System.Drawing.Point(127, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 48);
            this.button1.TabIndex = 84;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.Location = new System.Drawing.Point(18, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 80;
            this.label4.Text = "Stok Sayısı:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(454, 44);
            this.label8.TabIndex = 83;
            this.label8.Text = "Ticari Mal Sil";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.Location = new System.Drawing.Point(40, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(30, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 82;
            this.label1.Text = "Ürün Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Enabled = false;
            this.textBoxAdi.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxAdi.Location = new System.Drawing.Point(127, 105);
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(286, 32);
            this.textBoxAdi.TabIndex = 78;
            // 
            // TicariMalSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 321);
            this.Controls.Add(this.numericFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericStokSayisi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdi);
            this.Name = "TicariMalSil";
            this.Text = "TicariMalSil";
            ((System.ComponentModel.ISupportInitialize)(this.numericFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStokSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericStokSayisi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdi;
    }
}