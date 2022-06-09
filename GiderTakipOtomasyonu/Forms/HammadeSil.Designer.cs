namespace GiderTakipOtomasyonu.Forms
{
    partial class HammadeSil
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
            this.numericUpDownStok = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFiyat = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAgirlik = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgirlik)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownStok
            // 
            this.numericUpDownStok.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numericUpDownStok.Location = new System.Drawing.Point(123, 210);
            this.numericUpDownStok.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownStok.Name = "numericUpDownStok";
            this.numericUpDownStok.ReadOnly = true;
            this.numericUpDownStok.Size = new System.Drawing.Size(286, 32);
            this.numericUpDownStok.TabIndex = 38;
            // 
            // numericUpDownFiyat
            // 
            this.numericUpDownFiyat.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numericUpDownFiyat.Location = new System.Drawing.Point(123, 172);
            this.numericUpDownFiyat.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownFiyat.Name = "numericUpDownFiyat";
            this.numericUpDownFiyat.ReadOnly = true;
            this.numericUpDownFiyat.Size = new System.Drawing.Size(286, 32);
            this.numericUpDownFiyat.TabIndex = 39;
            // 
            // numericUpDownAgirlik
            // 
            this.numericUpDownAgirlik.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numericUpDownAgirlik.Location = new System.Drawing.Point(123, 134);
            this.numericUpDownAgirlik.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownAgirlik.Name = "numericUpDownAgirlik";
            this.numericUpDownAgirlik.ReadOnly = true;
            this.numericUpDownAgirlik.Size = new System.Drawing.Size(286, 32);
            this.numericUpDownAgirlik.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.button1.Location = new System.Drawing.Point(123, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 48);
            this.button1.TabIndex = 45;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.Location = new System.Drawing.Point(14, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Stok Sayisi:";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(434, 44);
            this.label8.TabIndex = 44;
            this.label8.Text = "Ürün Sil";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.Location = new System.Drawing.Point(62, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Fiyat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(47, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Agirlik:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(73, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Adi:";
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxAdi.Location = new System.Drawing.Point(123, 96);
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.ReadOnly = true;
            this.textBoxAdi.Size = new System.Drawing.Size(286, 32);
            this.textBoxAdi.TabIndex = 36;
            // 
            // HammadeSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.numericUpDownStok);
            this.Controls.Add(this.numericUpDownFiyat);
            this.Controls.Add(this.numericUpDownAgirlik);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdi);
            this.Name = "HammadeSil";
            this.Text = "HammadeSil";
            this.Load += new System.EventHandler(this.HammadeSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgirlik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownStok;
        private System.Windows.Forms.NumericUpDown numericUpDownFiyat;
        private System.Windows.Forms.NumericUpDown numericUpDownAgirlik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdi;
    }
}