using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiderTakipOtomasyonu
{
    public class PersonelDbClass
    {
        public int id { get; set; }
        public string adi { get; set; }
        public string soyAdi { get; set; }
        public string görevi { get; set; }
        public float maasi { get; set; }
        public DateTime iseBaslamaTarihi { get; set; } = new DateTime(2022, 06, 11);

        public string tatilGunu { get; set; }
    }
}
