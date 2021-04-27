using System;

namespace teht16
{
    class Program
    {
        static void Main(string[] args)
        { string weekday = "0";

            while (weekday != "quit")
            {
                Console.WriteLine("Syötä numero 1-7, saat vastaavan viikonpäivän. Syötä quit, jos haluat lopettaa.");
                weekday = Console.ReadLine();

                switch (weekday)
                {
                    case "1":
                        Console.WriteLine("Maanantai");
                        break;
                    case "2":
                        Console.WriteLine("Tiistai");
                        break;
                    case "3":
                        Console.WriteLine("Keskiviikko");
                        break;
                    case "4":
                        Console.WriteLine("Torstai");
                        break;
                    case "5":
                        Console.WriteLine("Perjantai");
                        break;
                    case "6":
                        Console.WriteLine("Lauantai");
                        break;
                    case "7":
                        Console.WriteLine("Sunnuntai");
                        break;
                    case "quit":
                        Console.WriteLine("Kiitos ohjelman käytöstä.");
                        break;
                    default:
                        Console.WriteLine("Viikossa on seitsemän päivää.");
                        break;
                }

            }
                Console.WriteLine("Lopetetaan ohjelma.");
        }       
    }
}
