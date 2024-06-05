using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerslerVeEgitmenler
{   public class Egitmen
    {
        // Egitmen à int ID, String egitmen_adı, Ders[] verilen_dersler
        public int ID{ get; set; }
        public string egitmen_adı { get; set; }
        public Ders[] verilen_dersler =new Ders[0];
        List<string> egitmens;
     



    }
}
