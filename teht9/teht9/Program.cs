using System;

namespace teht9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] luvut = new int[5];

            Console.WriteLine("Syötä viisi kokonaislukua.");

            for (i = 0; i < 5; i++)
            {
                luvut[i] = int.Parse(Console.ReadLine());
            }

            decimal sum = 0;

            foreach(int x in luvut)
            {
                sum += x;    
            }

            decimal keskiarvo = sum / luvut.Length;

            Console.WriteLine("Lukujen keskiarvo on: {0}", keskiarvo);

        }
    }
}
