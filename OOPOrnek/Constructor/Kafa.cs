﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek.Constructor
{
    public class Kafa
    {
        public Goz goz;
        public Burun burun;
        public Kulak kulak;

        public Kafa(Goz goz, Burun burun, Kulak kulak)
        {
            this.goz = goz;
            this.burun = burun;
            this.kulak = kulak;
        }
    }
}
