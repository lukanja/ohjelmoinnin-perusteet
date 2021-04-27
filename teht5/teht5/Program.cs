using System;

namespace teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oletko mies, nainen, vai joku muu?");
            string gender = Console.ReadLine();

            if (gender.Contains("mies") == true)

            {
                Console.WriteLine("Mikä on ikäsi?");
                int agemale = int.Parse(Console.ReadLine());

                if (agemale <= 13)
                {
                    Console.WriteLine("Hei poitsu!");
                }

                else if (agemale <= 26)
                {
                    Console.WriteLine("Mitä nuorimies?");
                }

                else if (agemale <= 56)
                {
                    Console.WriteLine("Olet mies parhaassa iässä!");
                }

                else
                {
                    Console.WriteLine("Hyvää päivää Teille!");
                }
            }

            else if (gender.Contains("nainen") == true)

            {

                Console.WriteLine("Mikä on ikäsi?");
                int agefemale = int.Parse(Console.ReadLine());

                if (agefemale <= 13)
                {
                    Console.WriteLine("Hei tytsy!");
                }

                else if (agefemale <= 26)
                {
                    Console.WriteLine("Mitä nuori neiti?");
                }

                else if (agefemale <= 56)
                {
                    Console.WriteLine("Olet nainen parhaassa iässä!");
                }

                else
                {
                    Console.WriteLine("Hyvää päivää Teille!");
                }

            }

            else
            {
                Console.WriteLine("Mikä on ikäsi?");
                int ageother = int.Parse(Console.ReadLine());

                if (ageother <= 13)
                {
                    Console.WriteLine("Hei muksu!");
                }

                else if (ageother <= 26)
                {
                    Console.WriteLine("Mitä tyyppi?");
                }

                else if (ageother <= 56)
                {
                    Console.WriteLine("Olet aikuinen parhaassa iässä!");
                }

                else
                {
                    Console.WriteLine("Hyvää päivää Teille!");
                }

            }

        }
    }
}
