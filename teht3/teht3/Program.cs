using System;

namespace teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä pituus senttimetreinä.");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("{0:0.00} cm", height);
            Console.WriteLine("{0:0.00} metriä", height * 0.01);
            Console.WriteLine("{0:0.00} mailia", height * 0.0000062137119224);
            Console.WriteLine("{0:0.00} jaardia", height / 91.44);
            Console.WriteLine("{0:0.00} tuumaa", height / 2.54);
        }
    }
}
