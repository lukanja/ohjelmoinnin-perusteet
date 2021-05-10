using System;

namespace teht18
{
    class Program
    {
        static void Main(string[] args)
        {
            
           Console.WriteLine("Kirjoita tekstiä.");
           string input = Console.ReadLine();

            Console.WriteLine(input);

            char[] array = input.ToCharArray();
            

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            Console.WriteLine();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", array[i]);
                
            }

            Console.WriteLine();

            int findchar = input.IndexOf('a');

            if (findchar == -1)
            {
                Console.WriteLine("Merkkijonossa {0} ei ole kirjainta a.", input);
            }

            else
            {
                Console.WriteLine("Merkkijonossa {0} ensimmäinen a on {1}. kirjain.", input, findchar+1);
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == ' ')
                {
                    Console.WriteLine();
                }

                else
                {
                    Console.Write("{0} ", array[i]);
                }
            }
                Console.WriteLine();

                findchar = input.IndexOf(' ');

                for (int j = findchar+1; j < array.Length; j++)
                {
                    Console.Write(array[j]);
                }

            Console.Write(" ");

                for (int j = 0; j < findchar; j++)
                {
                    Console.Write(array[j]);
                }
            
        }
    }
}
