using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace polinom
{
    public class Polinom
    {
        // Polinomun toplam terim sayısını tutan özellik
        public int ToplamTerimSayisi { get; private set; }

        // Polinomun katsayılarını tutan dizi
        public double[] Katsayilar { get; private set; }

        // Polinomun kuvvetlerini tutan dizi
        public int[] Kuvvetler { get; private set; }

        // Yapılandırıcı (Constructor)
        public Polinom(int toplamTerimSayisi, double[] katsayilar, int[] kuvvetler)
        {
            // Katsayılar ve kuvvetler dizilerinin uzunluklarının toplam terim sayısına eşit olup olmadığını kontrol ediyoruz
            if (katsayilar.Length != toplamTerimSayisi || kuvvetler.Length != toplamTerimSayisi)
            {
                throw new ArgumentException("Katsayılar ve kuvvetler dizilerinin uzunlukları toplam terim sayısına eşit olmalıdır.");
            }

            // Özellikleri başlatıyoruz
            ToplamTerimSayisi = toplamTerimSayisi;
            Katsayilar = katsayilar;
            Kuvvetler = kuvvetler;
        }
        public Polinom(int toplamTerimSayisi, double [] katsayilar, int[] kuvvetler,int nArtır )
        {
            // Katsayılar ve kuvvetler dizilerinin uzunluklarının toplam terim sayısına eşit olup olmadığını kontrol ediyoruz
            if (katsayilar.Length != toplamTerimSayisi || kuvvetler.Length != toplamTerimSayisi)
            {
                throw new ArgumentException("Katsayılar ve kuvvetler dizilerinin uzunlukları toplam terim sayısına eşit olmalıdır.");
            }

            // Özellikleri başlatıyoruz
            ToplamTerimSayisi = toplamTerimSayisi;
            Katsayilar = katsayilar;
            for(int i = 0; i < katsayilar.Length; i++)
            {
                katsayilar[i] += nArtır;
            }  
            Kuvvetler = kuvvetler;
        }
        public Polinom(int toplamTerimSayisi, double [] katsayilar, int[] kuvvetler, double nKat )
        {
            // Katsayılar ve kuvvetler dizilerinin uzunluklarının toplam terim sayısına eşit olup olmadığını kontrol ediyoruz
            if (katsayilar.Length != toplamTerimSayisi || kuvvetler.Length != toplamTerimSayisi)
            {
                throw new ArgumentException("Katsayılar ve kuvvetler dizilerinin uzunlukları toplam terim sayısına eşit olmalıdır.");
            }

            // Özellikleri başlatıyoruz
            ToplamTerimSayisi = toplamTerimSayisi;
            Katsayilar = katsayilar;
            for (int i = 0; i < katsayilar.Length; i++)
            {
                katsayilar[i] *= nKat;
            }
            Kuvvetler = kuvvetler;
        }

        // Polinomu string olarak döndüren metod
        public string PolinomYaz()
        {
            // Polinomun string temsilini oluşturacak değişken
            string polinomStr = "";

            // Her bir terimi sırayla işliyoruz
            for (int i = 0; i < ToplamTerimSayisi; i++)
            {
                // Kuvvet 0 ise sadece katsayıyı yazıyoruz (örneğin, "5")
                if (Kuvvetler[i] == 0)
                {
                    polinomStr += $"{Katsayilar[i]}";
                }
                // Kuvvet 1 ise katsayı ve x'i yazıyoruz (örneğin, "2x")
                else if (Kuvvetler[i] == 1)
                {
                    polinomStr += $"{Katsayilar[i]}x";
                }
                // Diğer durumlarda katsayı ve kuvveti yazıyoruz (örneğin, "3x^2")
                else
                {
                    polinomStr += $"{Katsayilar[i]}x^{Kuvvetler[i]}";
                }

                // Son terim değilse, terimlerin arasına " + " ekliyoruz
                if (i < ToplamTerimSayisi - 1)
                {
                    polinomStr += " + ";
                }
            }

            // Oluşturulan stringi döndürüyoruz
            return polinomStr;
        }
        // Polinomların birbirine eşit olup olmadığını kontrol eden metod
        public  static bool polinom_kontrol(Polinom p1, Polinom p2)
        {
            // Katsayılar ve kuvvetler dizilerinin elemanlarının eşit olup olmadığını kontrol ediyoruz
            bool esitMi = p1.Katsayilar.SequenceEqual(p2.Katsayilar) && p1.Kuvvetler.SequenceEqual(p2.Kuvvetler);
            return esitMi;
        }

        // Polinomun sıfır polinom olup olmadığını kontrol eden metod
        public static  bool polinom_kontrol(Polinom p)
        {
            // Katsayıların hepsinin sıfır olup olmadığını kontrol ediyoruz
            bool sifirMi = p.Katsayilar.All(k => k == 0);
            return sifirMi;
        }

    }
}
