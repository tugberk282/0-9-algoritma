using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1;
            int sayi2;
            int sayi3;
            int sayi4;
            int sayi5;

            double ortalama, toplam;

            Console.WriteLine("1.sayıyı girin");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayıyı girin");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.sayıyı girin");
            sayi3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("4.sayıyı girin");
            sayi4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("5.sayıyı girin");
            sayi5 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2 + sayi3 + sayi4 + sayi5;

            ortalama = toplam / 5;

            Console.WriteLine("Toplam :" + toplam);
            Console.WriteLine("Ortalama :" + ortalama);
            Console.ReadKey();
        }
    }
}
