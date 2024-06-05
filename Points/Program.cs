using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Points sınıfından bir nesne oluşturma
            points point = new points();

            // Noktanın koordinatlarını atama
            point.SetCoordinates(3.5, 7.2);

            // Noktanın koordinatlarını yazdırma
            point.PrintCoordinates();

            // Noktanın x koordinatını alma
            double x = point.GetX();
            Console.WriteLine("Noktanın x koordinatı: " + x);

            // Noktanın y koordinatını alma
            double y = point.GetY();
            Console.WriteLine("Noktanın y koordinatı: " + y);

            Console.ReadKey();
        }
    }
    
}
