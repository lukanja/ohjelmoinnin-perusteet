using System;

namespace teht12
{
    class Program
    {
        private static int Tervehdys(string name, string surname)

        { 
            Console.WriteLine("Tervetuloa ohjelmaan, {0} {1}!", name, surname);
            Console.WriteLine("Kuinka vanha olet?");
            int age = int.Parse(Console.ReadLine());
            return age;
        }

        private static void AgeCheck(int age)
        {
                if (age <= 13)
                {
                    Console.WriteLine("Hei muksu!");
                }

                else if (age <= 26)
                {
                    Console.WriteLine("Mitä tyyppi?");
                }

                else if (age <= 56)
                {
                    Console.WriteLine("Olet aikuinen parhaassa iässä!");
                }

                else
                {
                    Console.WriteLine("Hyvää päivää Teille!");
                }
        }


        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Anna etunimesi.");
            string name = Console.ReadLine();
            Console.WriteLine("Anna sukunimesi.");
            string surname = Console.ReadLine();

            age = Tervehdys(name, surname);
            AgeCheck(age);
        }
    }
}
