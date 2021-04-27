using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace teht13
{
    class Program

    {

        private static int Pienin(int eka, int toka, int kolmas)

        {
            int pieninLuku = Math.Min(Math.Min(eka,toka),kolmas);
            return pieninLuku;
        }

        private static int Suurin(int eka, int toka, int kolmas)

        {
            int suurinLuku = Math.Max(Math.Max(eka, toka), kolmas);
            return suurinLuku;

        }



        static void Main(string[] args)

        {

            int luku1, luku2, luku3, suurinLuku, pieninLuku;

            string syote;

            Console.WriteLine("Anna eka luku:");

            syote = Console.ReadLine();

            bool result1 = int.TryParse(syote, out luku1);

            if (result1)
            {
                Console.WriteLine("Ensimmäinen luku muunnettu.");
            }

            else
            {
                Console.WriteLine("Tyyppimuunnos epäonnistui, tarvitaan kokonaisluku.");
            }

            
            Console.WriteLine("Anna toka luku:");

            syote = Console.ReadLine();

            bool result2 = int.TryParse(syote, out luku2);

            if (result2)
            {
                Console.WriteLine("Toinen luku muunnettu.");
            }

            else
            {
                Console.WriteLine("Tyyppimuunnos epäonnistui, tarvitaan kokonaisluku.");
            }

            
            Console.WriteLine("Anna kolmas luku:");

            syote = Console.ReadLine();

            bool result3 = int.TryParse(syote, out luku3);

            if (result3)
            {
                Console.WriteLine("Kolmas luku muunnettu.");
            }

            else
            {
                Console.WriteLine("Tyyppimuunnos epäonnistui, tarvitaan kokonaisluku.");
            }


            if (result1 && result2 && result3)
            {
                pieninLuku = Pienin(luku1, luku2, luku3);
                suurinLuku = Suurin(luku2, luku2, luku3);

                Console.WriteLine("Pienin luku on {0}.", pieninLuku);
                Console.WriteLine("Suurin luku on {0}.", suurinLuku);
            }

            else
            {
                Console.WriteLine("Lopetetaan ohjelma.");
            }
        }
    }

}