using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string programmer;
            Console.WriteLine("Programcının ismi nedir?: ");
            programmer = Console.ReadLine();

            for (int i = 1; i < 10; i++)      
            {
                Console.WriteLine(programmer);
            }
            Console.ReadKey();
        }
    }
}
