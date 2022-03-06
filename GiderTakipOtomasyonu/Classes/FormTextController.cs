using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace GiderTakipOtomasyonu.Classes
{
    class FormTextController
    {

        private FormTextController()
        {
        }
        private static FormTextController instance;
        public static FormTextController giveInstance()
        {
            if (instance == null)
            {
                instance = new FormTextController();
            }
            return instance;
        }

        //
        //Karma kontrol fonksiyonlar
        //


        public void kullaniciAdiKontrol(KeyPressEventArgs e)
        {
            if (harfKontrol(e))
            {
                harfKontrol(e);
            }
            else if (numaraKontrol(e))
            {
                numaraKontrol(e);
            }
            else if (silmeKontrol(e))
            {
                silmeKontrol(e);
            }
        }


        public void sirketAdiKontrol(KeyPressEventArgs e)
        {
            if (harfKontrol(e))
            {
                harfKontrol(e);
            }
            else if (boslukKontrol(e))
            {
                boslukKontrol(e);
            }
            else if (silmeKontrol(e))
            {
                silmeKontrol(e);
            }
        }


        public void vergiDaireNoKontrol(KeyPressEventArgs e)
        {
            if (numaraKontrol(e))
            {
                numaraKontrol(e);
            }
            else if (silmeKontrol(e))
            {
                silmeKontrol(e);
            }
        }


        public void ePostaKontrol(KeyPressEventArgs e)
        {
            if (harfKontrol(e))
            {
                harfKontrol(e);
            }
            else if (numaraKontrol(e))
            {
                numaraKontrol(e);
            }
            else if (silmeKontrol(e))
            {
                silmeKontrol(e);
            }
            else if (ozelKontrol(e))
            {
                ozelKontrol(e);
            }
        }


        public void sifreKontrol(KeyPressEventArgs e)
        {
            if (harfKontrol(e))
            {
                harfKontrol(e);
            }
            else if (numaraKontrol(e))
            {
                numaraKontrol(e);
            }
            else if (silmeKontrol(e))
            {
                silmeKontrol(e);
            }
            else if (ozelKontrol(e))
            {
                ozelKontrol(e);
            }

        }

        public bool numaraKontrol(KeyPressEventArgs e)
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



        public bool harfKontrol(KeyPressEventArgs e)
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



        public bool silmeKontrol(KeyPressEventArgs e)
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



        public bool boslukKontrol(KeyPressEventArgs e)
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


        public bool ozelKontrol(KeyPressEventArgs e)
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

        
    }
}
