using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouVsWild
{
    public partial class Program
    {
        public static void First()
        {
            SetUpGame();

            Console.WriteLine("YOU VS WILD - teksteventyrversjonen");
            Console.WriteLine("Basert på episoden 'Searching for a Saint Bernhard'");
            Console.WriteLine();
            Console.WriteLine("Du har fått et nytt søks- og redningsoppdrag.");
            Console.WriteLine("I går gikk noen turgåere seg vill i et snødekt og avsideliggende fjell.");
            Console.WriteLine("De ble heldigvis funnet av redningstjenesten til slutt, men i prosessen forsvant redningshunden Dina.");
            Console.WriteLine("Hun har på seg et sporingshalsbånd, så vi vet omtrent hvor hun befinner seg," +
                " men været og terrenget er krevende.");
            Console.WriteLine();

            Console.WriteLine("Om du lykkes eller ikke avhenger av dine egne valg.");
            Console.WriteLine("Du vil bli bedt om å skrive inn flere svar underveis (obs: sjekk at ord er stavet rett før du sender dem),");
            Console.WriteLine("og du må veie risiko opp mot tidssparing.");
            Console.WriteLine();
            Console.WriteLine("Trykk på 'Enter' for å fortsette.");

            Console.ReadLine();
            Console.Clear();
            
            Second();
        }

    }
}
