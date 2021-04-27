using System;

namespace teht10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int arvonta, input = 0;

            Random satluku = new Random();

            arvonta = satluku.Next(1, 11);



            while (input != arvonta)

            {
                Console.WriteLine("Arvaa luku väliltä 1-10. Syötä q lopettaaksesi.");
                string temp = Console.ReadLine();

                if (temp == "q") break;

                else
                {
                    int.TryParse(temp, out input);

                    if (input == arvonta)
                    {
                        Console.WriteLine("Onneksi olkoon, arvasit luvun!");
                        break;
                    }
                }

            }

            Console.WriteLine("Lopetetaan ohjelma.");
        }
    }
}
