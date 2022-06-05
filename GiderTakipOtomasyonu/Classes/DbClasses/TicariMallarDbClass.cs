using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiderTakipOtomasyonu
{
    public class TicariMallarDbClass
    {
        public int id { get; set; }
        public string urunAdi { get; set; }
        public float stokSayisi { get; set; }
        public float fiyat { get; set; }
    }
}
