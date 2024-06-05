using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerslerVeEgitmenler
{
    public  class Ders
    {        // Ders à int ID, String ders_adı, int egitmen_ID
        public int ID { get; set; }
        public string ders_adı { get; set; }
        public int egitmen_ID { get; set; }
        public string egitmenAd { get; set; }
        //b-Bir eğitmene ders eklemek ve eğitmenin verdiği dersleri listelemek(max 20 ders listelenecek) için gerekli metotları yazınız.
        public Ders(int id ,string dersAdi ,int  egitmen_ID,string egitmenAdi) {
            ID = id;
            dersAdi = dersAdi;
            egitmen_ID = egitmen_ID;
            egitmenAdi = egitmenAd;
        }
    }
}
