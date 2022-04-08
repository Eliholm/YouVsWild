using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouVsWild
{
    public partial class Program
    {
        public static void Third()
        {
            Console.WriteLine("Helikopteret lander oppe på et platå. Først og fremst må du komme deg ned i dalen.");
            Console.WriteLine("Du har to valg:");
            Console.WriteLine("1: Paraglide rett ned i dalen");
            Console.WriteLine("2: Stå på ski rundt");

            string Choice = GetPlayerInput();

            switch (Choice)
            {
                case "1":
                    {
                        Paraglide();
                    }
                    break;
                case "2":
                    {
                        Console.WriteLine("Du står på ski rundt. Det går smertefritt, men det tar lang tid.");
                        Dog.HealthPoints--;
                    }
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Trykk på 'Enter' for å fortsette.");

            Console.ReadLine();
            Console.Clear();
            Fourth();
        }

        static void Paraglide()
        {
            Random random = new Random();
            int RandomNumber = random.Next(0, 2);

            if (RandomNumber == 0)
            {
                Console.WriteLine("Du tar sats, får luft i seilet, og flyr!");
            }
            else
            {
                Console.WriteLine("Du tar sats, får luft i seilet, og flyr. Men du opplever problemer og må nødlande.");
                Player.HealthPoints--;
            }
        }
    }
}
