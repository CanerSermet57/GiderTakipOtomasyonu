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

        //sadece yazi
        public Regex regexsadeceyazi = new Regex(@"^[A-Za-z][A-Za-z0-9_]{7,29}$");

        //sifre için
        public Regex regexsifre = new Regex(@"(?=^.{6,10}$)(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\s).*$");

        //e posta için
        public Regex regexEposta = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");




    }
}
