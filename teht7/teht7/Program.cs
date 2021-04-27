using System;

namespace teht7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Syötä numero.");
            int input = int.Parse(Console.ReadLine());

            for (a = 1; a <= input; a++)
            {
                for (b = 1; b <= a; b++)
                {
                    Console.Write(b);
                }
                Console.WriteLine();
            }
        }
    }
}
