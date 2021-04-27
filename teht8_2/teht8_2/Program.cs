using System;

namespace teht8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] hero = new string[4, 4] 
                { 
                { "Ana", "Support", "200", "0" }, 
                { "Bastion", "Defense", "200", "0" }, 
                { "Brigitte", "Support", "200", "50" }, 
                { "D.Va (Mech)", "Tank", "400", "200" } 
                };

            Console.WriteLine("Choose Hero:");
            Console.WriteLine("1 = Ana");
            Console.WriteLine("2 = Bastion");
            Console.WriteLine("3 = Brigitte");
            Console.WriteLine("4 = D.Va (Mech)");

            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("Hero: {0}", hero[input - 1, 0]);
            Console.WriteLine("Role: {0}", hero[input - 1, 1]);
            Console.WriteLine("Health: {0}", hero[input - 1, 2]);
            Console.WriteLine("Armor: {0}", hero[input - 1, 3]);
        }
    }
}
