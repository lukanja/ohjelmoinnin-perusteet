using System;

namespace teht4
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.WriteLine("Kirjoita luku euroina.");

                decimal euro = decimal.Parse(Console.ReadLine());

                Console.WriteLine("{0} € = {1} $", euro, euro * 1.19m);
                Console.WriteLine("{0} € = {1} £", euro, euro * 0.86m);
        }
    }
}