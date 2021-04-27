using System;

namespace teht7_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, arvonta;

            Random satluku = new Random();

            arvonta = satluku.Next(1, 11);
            
            for (a = 1; a <= 5; a++)
            {
                Console.WriteLine("Syötä luku väliltä 1-10.");
                int input = int.Parse(Console.ReadLine());

                if (input == arvonta)
                {
                    Console.WriteLine("Onneksi olkoon, sama luku!");
                    break;
                }
                else if (a < 5)
                {
                    Console.WriteLine("Yritä uudestaan.");
                }
                else if (a == 5)
                {
                    Console.WriteLine("Kierroksia 5, lopetetaan ohjelma.");
                }
            }
        }
    }
}
