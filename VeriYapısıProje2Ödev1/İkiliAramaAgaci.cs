using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapısıProje2Ödev1
{
    public class İkiliAramaAgaci
    {
        private İkiliAramaAgacDugumu kok;
        private string dugumler;

        public İkiliAramaAgaci()
        {
        }
        public İkiliAramaAgaci(İkiliAramaAgacDugumu kok)
        {
            this.kok = kok;
        }
        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        public int DugumSayisi(İkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;
        }
        public int YaprakSayisi()
        {
            return YaprakSayisi(kok);
        }
        public string DugumleriYazdir()
        {
            return dugumler;
        }
        public void PreOrder()
        {
            dugumler = "";
            // PreOrderInt(kok);
        }
        public int YaprakSayisi(İkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                if ((dugum.sol == null) && (dugum.sag == null))
                    count = 1;
                else
                    count = count + YaprakSayisi(dugum.sol) + YaprakSayisi(dugum.sag);
            }
            return count;
        }

        public void Ekle(string deger)
        {

            İkiliAramaAgacDugumu tempParent = new İkiliAramaAgacDugumu();

            İkiliAramaAgacDugumu tempSearch = kok;

            while (tempSearch != null)
            {
                tempParent = tempSearch;
                int j = 0;
                if (deger == (string)tempSearch.veri)
                    return;
                else
                {

                    if (j % 2 == 0)
                    {
                        tempSearch = tempSearch.sol;
                        j++;
                    }
                    else
                    {
                        tempSearch = tempSearch.sag;
                        j++;
                    }

                }

            }
            İkiliAramaAgacDugumu eklenecek = new İkiliAramaAgacDugumu(deger);

            int i = 0;
            if (kok == null)
                kok = eklenecek;
            else
            {
                if (i % 2 == 0)
                {
                    tempParent.sol = eklenecek;
                    i++;
                }
                else
                {
                    tempParent.sag = eklenecek;
                    i++;
                }

            }

        }
    }
}
