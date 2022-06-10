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
    }
}
