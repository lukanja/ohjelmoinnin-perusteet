using System;

namespace teht20
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Syötä merkki.");

            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();


            if (Char.IsWhiteSpace(input))
            {
                Console.WriteLine("Syötit tyhjän merkin.");
            }

            if (Char.IsDigit(input))
            {
                Console.WriteLine("Syötit numeron {0}.", input);
            }

            if (Char.IsUpper(input))
            {
                Console.WriteLine("Syötit ison kirjaimen.");
            }

            if (Char.IsLower(input))
            {
                Console.WriteLine("Syötit pienen kirjaimen.");
            }

            if (Char.IsLetterOrDigit(input) == false)
            {
                Console.WriteLine("Syötit erikoismerkin.");
            }
                
        }
    }
}
