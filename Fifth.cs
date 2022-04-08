using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouVsWild
{
    public partial class Program
    {
        public static void Fifth()
        {
            Console.WriteLine("Du kommer til et stort islagt vann du må krysse.");
            Console.WriteLine("Du tester forsiktig isen. Den virker relativt trygg, men du vet at det kan være utrygge partier lengre ut.");
            Console.WriteLine();
            Console.WriteLine("Det tryggeste alternativet er nok å krype over isen.");
            Console.WriteLine("Det fordeler kroppsvekten din over en større overflate.");
            Console.WriteLine("Men det er tidkrevende. Du vet ikke hvor lenge Dina klarer seg alene, i kulden.");
            Console.WriteLine();
            Console.WriteLine("Det kan også gå fint å krysse isen gående," +
                " så lenge du forsiktig sjekker hvert steg før du legger full vekt på foten.");
            Console.WriteLine("Hva velger du å gjøre, gå eller krype?");
            string Choice = GetPlayerInput();

            if (Choice == "krype")
            {
                Console.WriteLine("Du kryper sakte over isen.");
                Console.WriteLine("Det tar lang tid, men du kommer deg trygt over til andre siden");
                Dog.HealthPoints--;
                Console.WriteLine();
                Console.WriteLine("Trykk på 'Enter' for å fortsette.");
            }
            else
            {
                Walk();
            }

            Console.ReadLine();
            Console.Clear();
            Sixth();
        }

        static void Walk()
        {
            Random random = new Random();
            int RandomNumber = random.Next(0, 2);

            if (RandomNumber == 0)
            {
                Console.WriteLine("Du går så forsiktig kan over isen.");
                Console.WriteLine("Det knaker og gir litt etter i blant, og pulsen er høy.");
                Console.WriteLine("Men den rolige fremgangsmåten lønner seg.");
                Console.WriteLine("Du kommer trygt frem til den andre siden.");
                Console.WriteLine();
                Console.WriteLine("Trykk på 'Enter' for å fortsette.");

                Console.ReadLine();
                Console.Clear();
                Sixth();
            }
            else
            {
                Console.WriteLine("Du går så forsiktig kan over isen.");
                Console.WriteLine("Isen knaker, og du stopper opp. Men det er for sent.");
                Console.WriteLine("Den gir etter, og før du vet ordet av det er du i det iskalde vannet.");

                Console.WriteLine();
                Console.WriteLine("Trykk på 'Enter' for å fortsette.");

                Console.ReadLine();
                Console.Clear();
                GameOver1();
            }
        }

        static void GameOver1()
        {
            Console.WriteLine("Du klarer til slutt å dra deg opp av vannet.");
            Console.WriteLine("Men du er gjennomvåt og du vet at du er avhengig av rask hjelp for å klare deg. ");
            Console.WriteLine("Du ringer etter hjelp, og må avslutte søket etter Dina for i dag.");
            Console.WriteLine();
            RestartGame();
        }
    }
}
