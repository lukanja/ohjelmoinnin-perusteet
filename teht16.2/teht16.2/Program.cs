using System;

namespace teht16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä arvosana väliltä 4-10.");
            string grade = Console.ReadLine();

            switch (grade)
            {
                case "4":
                    Console.WriteLine("4 on hylätty arvosana.");
                    break;
                case "5":
                    Console.WriteLine("5 on huono arvosana.");
                    break;
                case "6":
                    Console.WriteLine("6 on välttävä arvosana.");
                    break;
                case "7":
                    Console.WriteLine("7 on tyydyttävä arvosana.");
                    break;
                case "8":
                    Console.WriteLine("8 on hyvä arvosana.");
                    break;
                case "9":
                    Console.WriteLine("9 on kiitettävä arvosana.");
                    break;
                case "10":
                    Console.WriteLine("10 on erinomainen arvosana.");
                    break;
                default:
                    Console.WriteLine("Virheellinen syöte.");
                    break;
            }

        }
    }
}
