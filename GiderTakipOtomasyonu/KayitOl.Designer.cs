
namespace GiderTakipOtomasyonu
{
    partial class KayitOl
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
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxSirketAdi = new System.Windows.Forms.TextBox();
            this.textBoxVergiDaireNo = new System.Windows.Forms.TextBox();
            this.textBoxEpostaAdresi = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxSifreTekrar = new System.Windows.Forms.TextBox();
            this.buttonKayitOl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(192, 105);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(187, 20);
            this.textBoxKullaniciAdi.TabIndex = 0;
            this.textBoxKullaniciAdi.Text = "Kullanici Adi";
            this.textBoxKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKullaniciAdi_KeyPress);
            // 
            // textBoxSirketAdi
            // 
            this.textBoxSirketAdi.Location = new System.Drawing.Point(192, 144);
            this.textBoxSirketAdi.Name = "textBoxSirketAdi";
            this.textBoxSirketAdi.Size = new System.Drawing.Size(187, 20);
            this.textBoxSirketAdi.TabIndex = 1;
            this.textBoxSirketAdi.Text = "Sirket Adi";
            this.textBoxSirketAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSirketAdi_KeyPress);
            // 
            // textBoxVergiDaireNo
            // 
            this.textBoxVergiDaireNo.Location = new System.Drawing.Point(192, 183);
            this.textBoxVergiDaireNo.Name = "textBoxVergiDaireNo";
            this.textBoxVergiDaireNo.Size = new System.Drawing.Size(187, 20);
            this.textBoxVergiDaireNo.TabIndex = 2;
            this.textBoxVergiDaireNo.Text = "Vergi Daire No";
            this.textBoxVergiDaireNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVergiDaireNo_KeyPress);
            // 
            // textBoxEpostaAdresi
            // 
            this.textBoxEpostaAdresi.Location = new System.Drawing.Point(192, 225);
            this.textBoxEpostaAdresi.Name = "textBoxEpostaAdresi";
            this.textBoxEpostaAdresi.Size = new System.Drawing.Size(187, 20);
            this.textBoxEpostaAdresi.TabIndex = 3;
            this.textBoxEpostaAdresi.Text = "E-posta Adresi";
            this.textBoxEpostaAdresi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEpostaAdresi_KeyPress);
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(192, 267);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(187, 20);
            this.textBoxSifre.TabIndex = 4;
            this.textBoxSifre.Text = "Sifre";
            this.textBoxSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSifre_KeyPress);
            // 
            // textBoxSifreTekrar
            // 
            this.textBoxSifreTekrar.Location = new System.Drawing.Point(192, 311);
            this.textBoxSifreTekrar.Name = "textBoxSifreTekrar";
            this.textBoxSifreTekrar.Size = new System.Drawing.Size(187, 20);
            this.textBoxSifreTekrar.TabIndex = 5;
            this.textBoxSifreTekrar.Text = "Sifre Tekrar";
            this.textBoxSifreTekrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSifreTekrar_KeyPress);
            // 
            // buttonKayitOl
            // 
            this.buttonKayitOl.Location = new System.Drawing.Point(192, 337);
            this.buttonKayitOl.Name = "buttonKayitOl";
            this.buttonKayitOl.Size = new System.Drawing.Size(75, 23);
            this.buttonKayitOl.TabIndex = 6;
            this.buttonKayitOl.Text = "Kayit Ol";
            this.buttonKayitOl.UseVisualStyleBackColor = true;
            this.buttonKayitOl.Click += new System.EventHandler(this.buttonKayitOl_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sifre Sıfırla";
            this.button1.UseVisualStyleBackColor = true;
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KayitOl
            // 
            this.ClientSize = new System.Drawing.Size(584, 565);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonKayitOl);
            this.Controls.Add(this.textBoxSifreTekrar);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxEpostaAdresi);
            this.Controls.Add(this.textBoxVergiDaireNo);
            this.Controls.Add(this.textBoxSirketAdi);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Name = "KayitOl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxSirketAdi;
        private System.Windows.Forms.TextBox textBoxVergiDaireNo;
        private System.Windows.Forms.TextBox textBoxEpostaAdresi;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxSifreTekrar;
        private System.Windows.Forms.Button buttonKayitOl;
        private System.Windows.Forms.Button button1;
    }
}