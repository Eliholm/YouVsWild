using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouVsWild
{
    public partial class Program
    {
        public static void Sixth()
        {
            Console.WriteLine("Du er trygt på den andre siden av vannet.");
            Console.WriteLine("Men det begynner å bli mørkt, og du må finne et egnet overnattingssted.");
            Console.WriteLine();
            Console.WriteLine("Du ser et stort tre med litt naturlig ly på siden.");
            Console.WriteLine("Det vil ikke beskytte deg helt mot været, men ");
            Console.WriteLine("Du ser et egnet sted å grave en iglo.");
            Console.WriteLine("Det krever litt energi, men isolerer godt mot vær og kulde.");
            Console.WriteLine();
            Console.WriteLine("Hva velger du? Grave iglo eller sove under tre?");
            Console.WriteLine("1: Sove under treet.");
            Console.WriteLine("2: Grave en iglo.");

            ChoiceAndInventoryCheck();

            Console.ReadLine();
            Console.Clear();
            Seventh();
        }

        static void ChoiceAndInventoryCheck()
        {
            string Choice = GetPlayerInput();

            if (Choice == "1")
            {
                if (Player.CheckInventory("fyrstikker"))
                {
                    Console.WriteLine("Du bestemmer deg for å sove under treet.");
                    Console.WriteLine("Det er kaldt. Men du kommer på at du har fyrstikker i sekken, og du får fyr på et bål. ");
                    Console.WriteLine("Du holder i alle fall varmen frem til du må sove noen timer, og bålet dør ut.");
                    Console.WriteLine();
                    Console.WriteLine("Trykk på 'Enter' for å fortsette.");
                }
                else
                {
                    Console.WriteLine("Du bestemmer deg for å sove under treet.");
                    Console.WriteLine("Det er kaldt. Du prøver å få fyr på et lite bål, men får det ikke til.");
                    Console.WriteLine("Det blir en lang og kald natt.");
                    Player.HealthPoints--;
                    Console.WriteLine();
                    Console.WriteLine("Trykk på 'Enter' for å fortsette.");
                }
            }
            else if (Choice == "2")
            {
                if (Player.CheckInventory("spade"))
                {
                    Console.WriteLine("Du bestemmer deg for å grave en iglo.");
                    Console.WriteLine("Du finner frem spaden du pakket med tidligere.");
                    Console.WriteLine("Det tar litt tid og krefter, men når du er ferdig blir det fint og lunt på innsiden.");
                    Player.HealthPoints++;
                    Console.WriteLine();
                    Console.WriteLine("Trykk på 'Enter' for å fortsette.");
                }
                else 
                {
                    Console.WriteLine("Du bestemmer deg for å grave en iglo.");
                    Console.WriteLine("Men du mangler et passende redskap.");
                    Console.WriteLine("Du prøver å grave en stund med hendene, men må til slutt gi opp.");
                    Console.WriteLine("Du legger deg under treet likevel.");
                    Player.HealthPoints--;
                    Console.WriteLine();
                    Console.WriteLine("Trykk på 'Enter' for å fortsette.");
                }
            }
            else
            {
                Console.WriteLine("Ugyldig svar. Trykk på 'Enter' for å prøve igjen.");

                Console.ReadLine();
                Console.Clear();
                Sixth();
            }
        }

    }
}