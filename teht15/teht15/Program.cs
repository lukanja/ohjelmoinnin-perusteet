using System;

namespace teht15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma suorittaa jakolaskun.");

            try
            {
                Console.WriteLine("Syötä jaettava luku.");
                decimal div = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Syötä luku, jolla haluat jakaa.");
                decimal divider = decimal.Parse(Console.ReadLine());

                decimal result = div / divider;

                Console.WriteLine("Jakolasku on {0} / {1} = {2}.", div, divider, result);
            }

            catch (FormatException)
            {
                Console.WriteLine("Väärä muoto, tarvitaan numero.");
            }

            catch (DivideByZeroException)
            {
                
                Console.WriteLine("Nollalla ei voi jakaa.");
            }

            finally
            {
                Console.WriteLine("Kiitos ohjelman käytöstä.");
            }
        }
    }
}
