using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GiderTakipOtomasyonu.Classes
{
    class RegexUretici
    {

        //kayıt ol sayfası regex


        //sadece yazi
        public Regex regexsadeceyazi = new Regex(@"^[A-Za-z][A-Za-z0-9_]{5,29}$");

        //sifre için
        public Regex regexsifre = new Regex(@"(?=^.{5,10}$)(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).*$");

        //e posta için
        public Regex regexEposta = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");


        //gelir sayfası için


        //Gelir kısımları için
        public Regex regexDuzenle = new Regex(@"^[A-Za-z][A-Za-z0-9_]{2,29}$");


        //kart kısımları için
        public Regex regexKartNo = new Regex(@"^[A-Za-z0-9_]{16,16}$");
        public Regex regexCvc = new Regex(@"^[A-Za-z0-9_]{3,3}$");

    }
}
