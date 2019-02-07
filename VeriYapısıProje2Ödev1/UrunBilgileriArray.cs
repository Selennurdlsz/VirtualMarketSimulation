using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace VeriYapısıProje2Ödev1
{
    public class UrunBilgileriArray
    {
        public string UrunAdi { get; set; }
        public string Marka { get; set; }
        public int Model { get; set; }
        public int UrunMiktari { get; set; }
        public int UrunMaliyeti { get; set; }
        public int Fiyat { get; set; }
        public string UrunAciklamasi { get; set; }
        public int UrunSayisi { get; set; }
        ArrayList UrunBilgileri = new ArrayList();


        public void ekle(UrunBilgileriArray ub)
        {
            UrunSayisi = 0;
            UrunBilgileri.Add(ub);
            UrunSayisi++; 
         
        }
     /*public void hashEkle(string key, int tableSize)
        {
            UrunBilgileriArray ub = new UrunBilgileriArray();
            int indis;
            int hashVal = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hashVal += key[i];

            }
            indis = hashVal % tableSize;
            ub.hashing(indis, key,tableSize);

                 return;
        } 
           
          public void hashing(int i, string k,int s)
        {
            ArrayList UrunAciklamalari = new ArrayList();
            UrunAciklamalari.Capacity = s;
            UrunAciklamalari.Insert(i, k);
            return;
        }*/

        public void UrunSil(UrunBilgileriArray ub)
        {
            UrunBilgileri.Remove(ub);
            UrunSayisi--;
        }


    }
}
