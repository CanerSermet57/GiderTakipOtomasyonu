﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiderTakipOtomasyonu
{
    public class CuzdanDbClass
    {
        public int id { get; set; }

        public float bakiyeTL { get; set; }
        public float bakiyeEURO { get; set; }
        public float bakiyeDolar { get; set; }
        public float kurDolar { get; set; } = 16.50F;
        public float kurEuro { get; set; } = 17.50F;

    }
}
