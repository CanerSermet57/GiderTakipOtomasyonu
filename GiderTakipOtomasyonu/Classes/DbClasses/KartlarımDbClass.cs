using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiderTakipOtomasyonu
{
    public class KartlarımDbClass
    {
        public int id { get; set; }
        public string kartAdi { get; set; }
        public string kartNo { get; set; }
        public string sonKullanmaTarihi { get; set; }
        public string CVCKodu { get; set; }
        public int islemSınırı { get; set; }
    }
}
