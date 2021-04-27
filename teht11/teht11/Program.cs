using System;
using System.Collections.Generic;

namespace teht11
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, choice;
            int a, amount;

            List<string> oppilaat = new List<string>();

            Console.WriteLine("Syötä oppilaiden nimet. Kun haluat lopettaa, syötä q.");

            input = Console.ReadLine();

            while (input != "q")
            {
                oppilaat.Add(input);
                input = Console.ReadLine();
            }

            oppilaat.Sort();

            Console.WriteLine("Syötit {0} nimeä. Kuinka monta nimeä haluat nähdä?", oppilaat.Count);

            amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Haluatko listan aakkosten alku- vai loppupäästä? Syötä alku tai loppu.");
            choice = Console.ReadLine();

            if (choice=="alku")
            {
                Console.WriteLine("Tässä {0} nimeä aakkosjärjestyksessä alkupäästä.", amount);
                for (a = 0; a < amount; a++)
                {
                    Console.WriteLine(oppilaat[a]);
                }
            }

            else if (choice=="loppu")
            {
                oppilaat.Reverse();
                Console.WriteLine("Tässä {0} nimeä aakkosjärjestyksessä loppupäästä.", amount);
                for (a = 0; a < amount; a++)
                {
                    Console.WriteLine(oppilaat[a]);
                }
            }
        }
    }
}
