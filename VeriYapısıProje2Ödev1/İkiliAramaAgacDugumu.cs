using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapısıProje2Ödev1
{
    public class İkiliAramaAgacDugumu
    {
        public object veri;
        public İkiliAramaAgacDugumu sol;
        public İkiliAramaAgacDugumu sag;
        public İkiliAramaAgacDugumu()
        {
        }

        public İkiliAramaAgacDugumu(object veri)
        {
            this.veri = veri;
            sol = null;
            sag = null;
        }
    }
    }
