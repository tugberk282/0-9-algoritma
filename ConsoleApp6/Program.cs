using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double fiyat;
            double toplamFiyat;
            Console.WriteLine("Ürünün kdv'siz fiyatını girin: ");
            fiyat = Convert.ToInt32(Console.ReadLine());

            toplamFiyat = fiyat + (fiyat * 0.18);

            Console.WriteLine("Ürünün kdvli fiyatı: " + toplamFiyat);
            Console.ReadLine();
        }
    }
}
