using System;

namespace teht8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int i, j;

            Console.WriteLine("Kuinka monen hedelmän tiedot syötetään?");
            int a = int.Parse(Console.ReadLine());

            string[] fruit = new string[a];
            decimal[] price = new decimal[a];
            int[] amount = new int[a];

            for (i = 0; i < a; i++)
            {
                Console.WriteLine("Anna {0}. tuotteen nimi.", i + 1);
                fruit[i] = Console.ReadLine();
                Console.WriteLine("Anna {0}. tuotteen hinta.", i + 1);
                price[i] = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Anna {0}. tuotteen lukumäärä.", i + 1);
                amount[i] = int.Parse(Console.ReadLine());
            }

            for (j = 0; j < a; j++)
            {
                Console.WriteLine("{0} yhteishinta on {1:0.00} €", fruit[j], price[j] * amount[j]);
            }
        }
    }
}
