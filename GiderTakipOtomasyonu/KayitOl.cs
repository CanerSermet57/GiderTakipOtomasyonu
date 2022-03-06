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


        private void textBoxKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            kullaniciAdiKontrolFonksiyonu(e);

        }

        private void textBoxSirketAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            sirketAdiKontrolFonksiyonu(e);
        }

        private void textBoxVergiDaireNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            vergiDaireNoKontrolFonksiyonu(e);
        }

        private void textBoxEpostaAdresi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ePostaKontrolFonksiyonu(e);
        }

        private void textBoxSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            sifreKontrolFonksiyonu(e);
        }

        private void textBoxSifreTekrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            sifreKontrolFonksiyonu(e);
        }



        //
        //Sade kontrol functions
        //


        private bool numaraKontrolFonksiyonu(KeyPressEventArgs e)
        {


            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }

        }



        private bool harfKontrolFonksiyonu(KeyPressEventArgs e)
        {


            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                return true;

            }
            else
            {
                e.Handled = true;
                return false;
            }

        }



        private bool silmeKontrolFonksiyonu(KeyPressEventArgs e)
        {


            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }

        }



        private bool boslukKontrolFonksiyonu(KeyPressEventArgs e)
        {


            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }

        }


        private bool ozelKontrolFonksiyonu(KeyPressEventArgs e)
        {


            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }

        }

        //
        //Karma kontrol fonksiyonlar
        //

        private void kullaniciAdiKontrolFonksiyonu(KeyPressEventArgs e)
        {
            if (harfKontrolFonksiyonu(e))
            {
                harfKontrolFonksiyonu(e);
            }
            else if (numaraKontrolFonksiyonu(e))
            {
                numaraKontrolFonksiyonu(e);
            }
            else if (silmeKontrolFonksiyonu(e))
            {
                silmeKontrolFonksiyonu(e);
            }
        
        }


        private void sirketAdiKontrolFonksiyonu(KeyPressEventArgs e)
        {
            if (harfKontrolFonksiyonu(e))
            {
                harfKontrolFonksiyonu(e);
            }
            else if (boslukKontrolFonksiyonu(e))
            {
                boslukKontrolFonksiyonu(e);
            }
            else if (silmeKontrolFonksiyonu(e))
            {
                silmeKontrolFonksiyonu(e);
            }

        }


        private void vergiDaireNoKontrolFonksiyonu(KeyPressEventArgs e)
        {
            if (numaraKontrolFonksiyonu(e))
            {
                numaraKontrolFonksiyonu(e);
            }
            else if (silmeKontrolFonksiyonu(e))
            {
                silmeKontrolFonksiyonu(e);
            }

        }


        private void ePostaKontrolFonksiyonu(KeyPressEventArgs e)
        {
            if (harfKontrolFonksiyonu(e))
            {
                harfKontrolFonksiyonu(e);
            }
            else if (numaraKontrolFonksiyonu(e))
            {
                numaraKontrolFonksiyonu(e);
            }
            else if (silmeKontrolFonksiyonu(e))
            {
                silmeKontrolFonksiyonu(e);
            }
            else if (ozelKontrolFonksiyonu(e))
            {
                ozelKontrolFonksiyonu(e);
            }

        }


        private void sifreKontrolFonksiyonu(KeyPressEventArgs e)
        {
            if (harfKontrolFonksiyonu(e))
            {
                harfKontrolFonksiyonu(e);
            }
            else if (numaraKontrolFonksiyonu(e))
            {
                numaraKontrolFonksiyonu(e);
            }
            else if (silmeKontrolFonksiyonu(e))
            {
                silmeKontrolFonksiyonu(e);
            }
            else if (ozelKontrolFonksiyonu(e))
            {
                ozelKontrolFonksiyonu(e);
            }

        }

        
    }
}
