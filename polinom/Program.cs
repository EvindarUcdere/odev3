using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polinom
{
    public class Program
    {
        static void Main(string[] args)
        {
            // P1 polinomunun katsayıları ve kuvvetleri
            double[] p1Katsayilar = { 1, 2, 5 };
            int[] p1Kuvvetler = { 4, 2, 0 };
            // P1 polinomunu oluşturuyoruz
            Polinom p1 = new Polinom(3, p1Katsayilar, p1Kuvvetler);
            // P1 polinomunu konsola yazdırıyoruz
            Console.WriteLine("P1: " + p1.PolinomYaz());

            // P2 polinomunun katsayıları ve kuvvetleri
            double[] p2Katsayilar = { 3, 6 };
            int[] p2Kuvvetler = { 3, 0 };
            // P2 polinomunu oluşturuyoruz
            Polinom p2 = new Polinom(2, p2Katsayilar, p2Kuvvetler);
            // P2 polinomunu konsola yazdırıyoruz
            Console.WriteLine("P2: " + p2.PolinomYaz());
        

            double[] p3Katsayilar = { 1, 2, 5 };
            int[] p3Kuvvetler = { 4, 2, 0 };
            Polinom p3 = new Polinom(3,p3Katsayilar,p3Kuvvetler,10);
            Console.WriteLine("P3: " + p3.PolinomYaz());


            double[] p4Katsayilar = { 1, 2, 5 };
            int[] p4Kuvvetler = { 4, 2, 0 };
            Polinom p4 = new Polinom(3, p4Katsayilar, p4Kuvvetler, 4.0);
            Console.WriteLine("P4: " + p4.PolinomYaz());


            double[] p5Katsayilar = { 1, 2, 3 };
            int [] p5Kuvvetler = { 2, 1, 0 };
            Polinom p5 = new Polinom(3, p5Katsayilar, p5Kuvvetler);
            Console.WriteLine("sıfır mı :"+ Polinom.polinom_kontrol(p5));


            double[] p6Katsayilar = { 1, 4, 10};
            int[] p6Kuvvetler = { 3, 2, 0 };
            Polinom p6 = new Polinom(3, p6Katsayilar, p6Kuvvetler);
            Console.WriteLine("esit mi :" + Polinom.polinom_kontrol(p6,p5));


            Console.ReadKey();
        }
    }
    
}
