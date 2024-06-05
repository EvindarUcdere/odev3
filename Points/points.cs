using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points
{
    internal class points
    {
        private double x;
        private double y;

        // Noktanın koordinatlarını atayan metot
        public void SetCoordinates(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Noktanın koordinatlarını yazdıran metot
        public void PrintCoordinates()
        {
            Console.WriteLine($"Noktanın koordinatları: ({x}, {y})");
        }

        // Noktanın x koordinatını geri döndüren metot
        public double GetX()
        {
            return x;
        }

        // Noktanın y koordinatını geri döndüren metot
        public double GetY()
        {
            return y;
        }
    }
}
