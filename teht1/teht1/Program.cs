using System;

namespace teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;

            {
                Console.WriteLine("Syötä numero välillä 0-10");
                {
                    int inputnumber = int.Parse(Console.ReadLine());

                    {
                        Console.WriteLine("{0} * {1} = {2}      {0} / {1} = {3}     {0} % {1} = {4}", inputnumber, a, inputnumber * a, inputnumber / a, inputnumber % a);
                        Console.WriteLine("{0} * {1} = {2}      {0} / {1} = {3}     {0} % {1} = {4}", inputnumber, b, inputnumber * b, inputnumber / b, inputnumber % b);
                        Console.WriteLine("{0} * {1} = {2}      {0} / {1} = {3}     {0} % {1} = {4}", inputnumber, c, inputnumber * c, inputnumber / c, inputnumber % c);
                        Console.WriteLine("{0} * {1} = {2}      {0} / {1} = {3}     {0} % {1} = {4}", inputnumber, d, inputnumber * d, inputnumber / d, inputnumber % d);
                        Console.WriteLine("{0} * {1} = {2}      {0} / {1} = {3}     {0} % {1} = {4}", inputnumber, e, inputnumber * e, inputnumber / e, inputnumber % e);
                    }
                }
            }
        }
    }
}