using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouVsWild
{
    public partial class Program
    {
        public static void Seventh()
        {
            Console.WriteLine("Dagen etter står du opp og sjekker koordinatene til Dina.");
            Console.WriteLine("Det er ikke så langt igjen nå.");
            Console.WriteLine();
            Console.WriteLine("Du følger signalene frem til du kommer til en grotte.");
            Console.WriteLine("Du går inn i grotten, og roper på Dina. Men du ser henne ingen steder.");
            Console.WriteLine("Du ser en liten bekk, hvor Dina sikkert har gått for å drikke.");
            Console.WriteLine("Ved siden av bekken ligger halsbåndet hennes. Det må ha falt av på en eller annen måte.");
            Console.WriteLine("Men du ser i hvert fall noen potespor i snøen like ved bekken.");
            Console.WriteLine();
            Console.WriteLine("For å finne Dina er du nødt til å følge sporene hennes.");
            Console.WriteLine("Du kan lete spekulativt, hvor du prøver å sette den inn i hundens ståsted.");
            Console.WriteLine("Hvor den vil føle seg tryggest når den går, hvor den vil se etter dekning for været, mat eller vann.");
            Console.WriteLine();
            Console.WriteLine("Eller så kan du lete systematisk, hvor du ser nøye etter ethvert tegn på et dyr.");
            Console.WriteLine("Spor i snøen, nedtråkkede grener, pels, etc.");
            Console.WriteLine();
           
            Console.WriteLine("Hvordan vil du lete etter Dina?");
            Console.WriteLine("1: Spekulativt");
            Console.WriteLine("2: Systematisk");
            string Choice = GetPlayerInput();

            if (Choice == "spekulativt" || Choice == "1")
            {
                Instinctive();
            }
            else
            {
                Console.WriteLine("Du leter systematisk, og underveis finner du noen flere potespor, og litt pels som kan tilhøre henne sitter fast i et tre.");
                Console.WriteLine("Det tar litt tid, men du finner henne til slutt.");
            }
            Console.WriteLine();
            Console.WriteLine("Trykk på 'Enter' for å fortsette");

            Console.ReadLine();
            Console.Clear();
            Eight();
        }

        static void Instinctive()
        {
            Random random = new Random();
            int RandomNumber = random.Next(0, 2);

            if (RandomNumber == 0)
            {
                Console.WriteLine("Du finner Dina med en gang!");
                Dog.HealthPoints++;
            }
            else
            {
                Console.WriteLine("Du går og går, men finner ikke Dina. Du må gå tilbake og prøve på nytt.");
                Dog.HealthPoints--;
            }
        }
    }
}
