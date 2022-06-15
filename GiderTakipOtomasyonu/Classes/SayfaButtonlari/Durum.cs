using GiderTakipOtomasyonu.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiderTakipOtomasyonu.SayfaButtonlari
{
    class Durum
    {
        Panel panelRight;

        public Durum(Panel panelRight)
        {
            this.panelRight = panelRight;
            baslangic();
        }

        private gtoDbContext dbContext;

        public void baslangic()
        {
            panelRight.Controls.Clear();
            labelsCreate();
        }

        public void labelsCreate()
        {

            gtoDbContext gtoDb = new gtoDbContext();
            KullaniciDbContext kullanicidb = new KullaniciDbContext();
            var kullaniciDetay = gtoDb.KullaniciDetay.ToList();
            var kullanici = kullanicidb.Kullanicilar.ToList();

            Label label;
            // 
            // label3
            // 
            label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(546, 89);
            label.Name = "label3";
            label.Size = new System.Drawing.Size(147, 63);
            label.TabIndex = 17;
            label.Text = "100€";
            panelRight.Controls.Add(label);
            // 
            // label
            // 
            label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(249, 89);
            label.Name = "label";
            label.Size = new System.Drawing.Size(147, 63);
            label.TabIndex = 16;
            label.Text = "100$";
            panelRight.Controls.Add(label);
            // 
            // label4
            // 
            label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(322, 9);
            label.Name = "label4";
            label.Size = new System.Drawing.Size(335, 63);
            label.TabIndex = 18;
            label.Text = "Döviz Kurları";
            panelRight.Controls.Add(label);
            // 
            // label
            // 
            label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(24, 311);
            label.Name = "label";
            label.Size = new System.Drawing.Size(267, 39);
            label.TabIndex = 19;
            label.Text = "Kullanıcı Bilgileri";
            panelRight.Controls.Add(label);
            // 
            // label5
            // 
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(182, 364);
            label.Name = "label5";
            label.Size = new System.Drawing.Size(61, 31);
            label.TabIndex = 20;
            label.Text = "Adı:";
            panelRight.Controls.Add(label);
            // 
            // label6
            // 
            label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(145, 410);
            label.Name = "label6";
            label.Size = new System.Drawing.Size(98, 31);
            label.TabIndex = 21;
            label.Text = "E-mail:";
            panelRight.Controls.Add(label);
            // 
            // label7
            // 
            label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(66, 452);
            label.Name = "label7";
            label.Size = new System.Drawing.Size(177, 31);
            label.TabIndex = 21;
            label.Text = "Vergi Dairesi:";
            panelRight.Controls.Add(label);
            // 
            // label8
            // 
            label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(24, 497);
            label.Name = "label8";
            label.Size = new System.Drawing.Size(219, 31);
            label.TabIndex = 22;
            label.Text = "Vergi Dairesi No:";
            panelRight.Controls.Add(label);
            // 
            // label9
            // 
            label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(249, 498);
            label.Name = "label9";
            label.Size = new System.Drawing.Size(211, 31);
            label.TabIndex = 26;
            label.ForeColor = System.Drawing.Color.LightGray;
            label.Text = kullaniciDetay[0].vergiDairesiNo;
            panelRight.Controls.Add(label);
            // 
            // label0
            // 
            label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(249, 453);
            label.Name = "label0";
            label.Size = new System.Drawing.Size(169, 31);
            label.TabIndex = 24;
            label.ForeColor = System.Drawing.Color.LightGray;
            label.Text = kullaniciDetay[0].vergiDairesi;
            panelRight.Controls.Add(label);
            // 
            // label1
            // 
            label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(249, 412);
            label.Name = "label1";
            label.Size = new System.Drawing.Size(90, 31);
            label.TabIndex = 25;
            label.ForeColor = System.Drawing.Color.LightGray;
            label.Text =  kullanici[0].mail;
            panelRight.Controls.Add(label);
            // 
            // label
            // 
            label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(249, 364);
            label.Name = "label";
            label.Size = new System.Drawing.Size(53, 31);
            label.ForeColor = System.Drawing.Color.LightGray;
            label.TabIndex = 23;
            label.Text = kullanici[0].adi;
            panelRight.Controls.Add(label);
        }
    }
}
