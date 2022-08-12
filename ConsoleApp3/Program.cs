using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;


            Console.WriteLine("Sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0)
            {
                Console.WriteLine("sayınız pozitif!");
            }
            else if (sayi < 0)
            {
                Console.WriteLine("sayınız negatif!");
            }
            else if(sayi == 0)
            {
                Console.WriteLine("sayınız '0' ");
            }
        }
    }
}
