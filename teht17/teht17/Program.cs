using System;

namespace teht17
{
    class Program
    {
        enum Menu { None, addName, addAge, showName, showAge, exit }
            
        static void Main(string[] args)
        {
            bool done = false;
            string choice, name = "";
            int age = 0;
            Menu selection;

            Console.WriteLine("Tervetuloa ohjelmaan. Siirry valikossa valitsemalla numero.");

            while (!done)

            {
                    Console.WriteLine("1. Syötä nimi.");
                    Console.WriteLine("2. Syötä ikä.");
                    Console.WriteLine("3. Näytä nimi.");
                    Console.WriteLine("4. Näytä ikä.");
                    Console.WriteLine("5. Poistu ohjelmasta.");

                    Console.Write("> ");
                    choice = Console.ReadLine();
                    Enum.TryParse(choice, out selection);

                switch (selection)
                {
                    case Menu.addName:
                        Console.Write("Kirjoita nimesi: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Nimi tallennettu.");
                        Console.WriteLine();
                        break;

                    case Menu.addAge:
                        Console.Write("Kirjoita ikäsi: ");
                        string ageinput = Console.ReadLine();
                        int.TryParse(ageinput, out age);
                        Console.WriteLine("Ikä tallennettu.");
                        Console.WriteLine();
                        break;

                    case Menu.showName:
                        if (name == "")
                        {
                            Console.WriteLine("Nimeä ei ole tallennettu.");
                            Console.WriteLine();
                        }

                        else
                        {
                            Console.WriteLine("Nimesi on {0}.", name);
                            Console.WriteLine();
                        }
                        break;

                    case Menu.showAge:
                        if (age == 0)
                        {
                            Console.WriteLine("Ikää ei ole tallennettu.");
                            Console.WriteLine();
                        }

                        else
                        {
                            Console.WriteLine("Ikäsi on {0}.", age);
                            Console.WriteLine();
                        }
                        break;

                    case Menu.exit:
                        Console.WriteLine("Lopetetaan ohjelma.");
                        done = true;
                        break;
                }
            }
        }
        
    }
}
