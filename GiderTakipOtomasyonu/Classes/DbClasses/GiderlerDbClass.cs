using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiderTakipOtomasyonu
{
    public class GiderlerDbClass
    {
        public int id { get; set; }
        public string aciklamasi { get; set; }
        public string kime { get; set; }
        public float tutar { get; set; }
        public DateTime tarih { get; set; }

        public OdemeTuruDbClass odemeTuru { get; set; }
        public int? odemeTuruId { get; set; }

        public KategoriDbClass Kategori { get; set; }
        public int? kategoriId { get; set; }
    }
}
