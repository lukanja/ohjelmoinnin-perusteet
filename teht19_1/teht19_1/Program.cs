using System;

namespace teht19_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pilkku = true;
            bool kapitaalit = true;

            string esimerkki = "{" +
                "opettajat:[" +
                "{ firstName:Jussi, lastName:Torppa }," +
                "{ firstName:Sari, lastName:Paunonen }," +
                "{ firstName:Ville, lastName:Hämäläinen }" +
                "]" +
                "oppilaat:[" +
                "{ firstName:Aku, lastName:Ankka }," +
                "{ firstName:Mikki, lastName:Hiiri }," +
                "{ firstName:Hessu, lastName:Hopo }" +
                "]}";

            for (int i = 0; i < esimerkki.Length; i++)
            {
                string kirjain = esimerkki[i].ToString();

                switch (kirjain)
                {   
                    case ",":
                        if (pilkku)
                        {
                            Console.Write(kirjain);
                            pilkku = false;
                        }
                        else 
                        {
                            pilkku = true;
                        }
                        break;
                    case "[":
                        pilkku = true;
                        kapitaalit = false;
                        break;
                    case "]":
                        kapitaalit = true;
                        Console.WriteLine();
                        break;
                    case "{":
                        Console.WriteLine();
                        break;
                    case "}":
                        break;



                    default:
                        if (kapitaalit)
                        {
                            Console.Write(kirjain.ToUpper());
                        }
                        else
                        {
                            Console.Write(kirjain);
                        }
                        break;
                }
                
            }
        }
    }
}