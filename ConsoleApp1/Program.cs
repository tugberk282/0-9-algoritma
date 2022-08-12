using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1;
            int sayi2;
            Console.WriteLine("1.Sayı: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Sayı: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            if(sayi1 > sayi2)
            {
                Console.WriteLine("1. Sayı daha büyük");
            }
            
            else if(sayi1 < sayi2)
            {
                Console.WriteLine("2. Sayı daha büyük");
            }

            else if(sayi2 == sayi1)
            {
                Console.WriteLine("Sayılar birbirine eşittir");
            }
        }

    }
}
