using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cikolataSatis
{
    internal class Program
    {
        static void Main()
        {
            // Örnek girdi değerleri
            int N = 5;
            int[] C = { 3, 0, 2, 1, 4 };

            // Toplam satılan çikolata sayısını hesapla
            int result = CalculateTotalSoldChocolates(N, C);
            Console.WriteLine($"Toplam satılan çikolata sayısı: {result}");
            Console.ReadKey();  
        }

        static int CalculateTotalSoldChocolates(int N, int[] C)
        {
            Stack<int> stack = new Stack<int>();
            int totalSoldChocolates = 0;

            for (int i = 0; i < N; i++)
            {
                if (C[i] == 0)
                {
                    // Eğer yığın boş değilse, üstteki kutuyu sat
                    if (stack.Count > 0)
                    {
                        totalSoldChocolates += stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Uyarı: Yığın boş, satılacak kutu yok!");
                    }
                }
                else
                {
                    // Yeni çikolata kutusunu yığına ekle
                    stack.Push(C[i]);
                }
            }
            return totalSoldChocolates;




        }

    }
}
