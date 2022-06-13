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

        public TemaDbClass tema { get; set; }
        public int? temaId { get; set; } = 1;
        public bool boolDurum { get; set; }
        public bool boolCuzdan { get; set; }
        public bool boolBanka { get; set; }
        public bool boolGider { get; set; }
        public bool boolGelir { get; set; }
        public bool boolKisiler { get; set; }
        public bool boolTakvim { get; set; }
        public bool boolPersonel { get; set; }
        public bool boolFiyatlar { get; set; }
        public bool boolKarZarar { get; set; }
        public bool boolHammadde { get; set; }








    }
}
