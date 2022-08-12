using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int icnt=0, rslt=1;
            while (true) 
            {
                Console.WriteLine("sayi giriniz(bitirmek için 0 giriniz) :");

                int num = int.Parse(Console.ReadLine());

                if (num==0) { break; };

                icnt++;
            }

            for (int i = icnt; i > 0; i--)
            {
                rslt = rslt * i;
            }

            Console.WriteLine("Girilen Adet : {0}, Sonuc : {1} : ", icnt, rslt);
        }
    }
}