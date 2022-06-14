using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiderTakipOtomasyonu
{
    public class AyarlarDbClass
    {
        public int id { get; set; }
        public bool alarm { get; set; }
        public bool bildirim { get; set; }

        public string tema { get; set; } = "Koyu";
        public bool boolDurum { get; set; } = true;
        public bool boolCuzdan { get; set; } = true;
        public bool boolBanka { get; set; } = true;
        public bool boolGider { get; set; } = true;
        public bool boolGelir { get; set; } = true;
        public bool boolKisiler { get; set; } = true;
        public bool boolTakvim { get; set; } = true;
        public bool boolPersonel { get; set; } = true;
        public bool boolFiyatlar { get; set; } = true;
        public bool boolKarZarar { get; set; } = true;
        public bool boolHammadde { get; set; } = true;








    }
}
