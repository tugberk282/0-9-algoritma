using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen vizenizi girin");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen finalinizi girin");
            int final = Convert.ToInt32(Console.ReadLine());

            int sonuc = (vize + final) / 2;

            if (sonuc > 50 || sonuc ==50)
            {
                Console.WriteLine("Dersi geçtiniz, tebrikler!");
            }
            else if (sonuc < 50)
            {
                Console.WriteLine("Dersten kaldınız");
            }
        }
    }
}

//50 ve üzeri geçer not olarak belirledim