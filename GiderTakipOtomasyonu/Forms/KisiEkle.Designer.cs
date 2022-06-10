namespace GiderTakipOtomasyonu.Forms
{
    partial class KisiEkle
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
            this.numericUpDownAlacak = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBorc = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBilgi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxFaks = new System.Windows.Forms.TextBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlacak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorc)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownAlacak
            // 
            this.numericUpDownAlacak.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numericUpDownAlacak.Location = new System.Drawing.Point(123, 147);
            this.numericUpDownAlacak.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownAlacak.Name = "numericUpDownAlacak";
            this.numericUpDownAlacak.Size = new System.Drawing.Size(286, 32);
            this.numericUpDownAlacak.TabIndex = 3;
            // 
            // numericUpDownBorc
            // 
            this.numericUpDownBorc.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numericUpDownBorc.Location = new System.Drawing.Point(123, 109);
            this.numericUpDownBorc.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownBorc.Name = "numericUpDownBorc";
            this.numericUpDownBorc.Size = new System.Drawing.Size(286, 32);
            this.numericUpDownBorc.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.button1.Location = new System.Drawing.Point(123, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(434, 44);
            this.label8.TabIndex = 18;
            this.label8.Text = "Kisi Ekleme";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxBilgi
            // 
            this.textBoxBilgi.Location = new System.Drawing.Point(123, 299);
            this.textBoxBilgi.Multiline = true;
            this.textBoxBilgi.Name = "textBoxBilgi";
            this.textBoxBilgi.Size = new System.Drawing.Size(286, 86);
            this.textBoxBilgi.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label6.Location = new System.Drawing.Point(64, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bilgi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label7.Location = new System.Drawing.Point(10, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telefon No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label5.Location = new System.Drawing.Point(36, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Faks No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.Location = new System.Drawing.Point(46, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Adress:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.Location = new System.Drawing.Point(46, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Alacak:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(63, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Borc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(73, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Adi:";
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxTelefon.Location = new System.Drawing.Point(123, 223);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(286, 32);
            this.textBoxTelefon.TabIndex = 5;
            // 
            // textBoxFaks
            // 
            this.textBoxFaks.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxFaks.Location = new System.Drawing.Point(123, 261);
            this.textBoxFaks.Name = "textBoxFaks";
            this.textBoxFaks.Size = new System.Drawing.Size(286, 32);
            this.textBoxFaks.TabIndex = 6;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxAdres.Location = new System.Drawing.Point(123, 185);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(286, 32);
            this.textBoxAdres.TabIndex = 4;
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxAdi.Location = new System.Drawing.Point(123, 71);
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(286, 32);
            this.textBoxAdi.TabIndex = 1;
            // 
            // KisiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.numericUpDownAlacak);
            this.Controls.Add(this.numericUpDownBorc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxBilgi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxFaks);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.textBoxAdi);
            this.Name = "KisiEkle";
            this.Text = "KisiEkle";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlacak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownAlacak;
        private System.Windows.Forms.NumericUpDown numericUpDownBorc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBilgi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxFaks;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxAdi;
    }
}