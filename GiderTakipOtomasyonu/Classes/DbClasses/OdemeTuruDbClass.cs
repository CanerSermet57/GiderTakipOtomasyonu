using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiderTakipOtomasyonu
{
    public class OdemeTuruDbClass
    {
        public int id { get; set; }

        public string adi { get; set; }

        public List<GiderlerDbClass> Giderler { get; set; }


    }
}
