using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int fahrenheit;
            int celcius;

            Console.WriteLine("Sıcaklığı fahrenheit cinsinden yazınız: ");
            fahrenheit = Convert.ToInt32(Console.ReadLine());

            celcius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("Sıcaklık değeriniz celcius cinsinden: " + celcius + "C");
            Console.ReadLine();
        }
    }
}
