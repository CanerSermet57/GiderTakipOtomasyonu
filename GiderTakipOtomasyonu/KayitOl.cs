using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiderTakipOtomasyonu
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        //
        //textbox keypress functions
        //
        
        Classes.FormTextController formTextController = Classes.FormTextController.giveInstance();

        private void textBoxKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            formTextController.kullaniciAdiKontrol(e);
        }

        private void textBoxSirketAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            formTextController.sirketAdiKontrol(e);
        }

        private void textBoxVergiDaireNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            formTextController.vergiDaireNoKontrol(e);
        }

        private void textBoxEpostaAdresi_KeyPress(object sender, KeyPressEventArgs e)
        {
            formTextController.ePostaKontrol(e);
        }

        private void textBoxSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            formTextController.sifreKontrol(e);
        }

        private void textBoxSifreTekrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            formTextController.sifreKontrol(e);
        }        

        private void buttonKayitOl_Click(object sender, EventArgs e)
        {






        }


    }
}
