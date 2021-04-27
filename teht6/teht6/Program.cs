using System;

namespace teht6
{
    class Program
    {
        static void Main(string[] args)
        {

            string sun;
            string rain;
            string temperature;

            Console.WriteLine("Paistaako aurinko? k/e");
            sun = Console.ReadLine();

            Console.WriteLine("Sataako vettä? k/e");
            rain = Console.ReadLine();

            Console.WriteLine("Onko lämpötila yli 0 astetta? k/e");
            temperature = Console.ReadLine();

            if (sun == "k" && rain == "k" && temperature == "k")
            {
                Console.WriteLine("Aurinko paistaa ja vettä sataa, taitaa tulla kesä!");
            }

            else if (sun == "e" && rain == "k" && temperature == "k")
            {
                Console.WriteLine("Syksy saapui, lehdet vei tuuli mennessään.");
            }
            else if ((sun == "e" && rain == "e" && temperature == "k") || (sun == "k" && rain == "e" && temperature == "e"))
            {
                Console.WriteLine("Jo joutui armas aika ja suvi suloinen...");
            }
            else if (sun == "e" && rain == "e" && temperature == "e")
            {
                Console.WriteLine("Villapaita päälle!");
            }
            else if (sun == "k" && rain == "e" && temperature == "e")
            {
                Console.WriteLine("Todennäköisesti kylmpempää kuin miltä näyttää.");
            }
            else if (sun == "e" && rain == "k" && temperature == "e")
            {
                Console.WriteLine("Welcome to Finland.");
            }
            else
            {
                Console.WriteLine("Kokeile syöttää jotain muuta.");
            }
        }
    }
}
