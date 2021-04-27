using System;

namespace teht10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i <= 100)
                {

                Console.WriteLine("Syötä luku.");

                int j  = int.Parse(Console.ReadLine());

                i = i+j;

                Console.WriteLine("Lukujen yhteisumma on {0}.", i);
            }

            Console.WriteLine("Summa on yli 100. Lopetetaan ohjelma.");
        }
    }
}
