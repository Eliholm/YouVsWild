using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouVsWild
{
    public partial class Program
    {
        public static void Second()
        {
            Console.WriteLine("Du sitter i et helikopter på vei til området hun sist ble sett.");
            Console.WriteLine("Du går gjennom ryggsekken din og sjekker at du har det du trenger.");
            Console.WriteLine("Den inneholder;");

            foreach (string element in Player.Inventory)
            {
                Console.WriteLine($"{element}");
            }

            Console.WriteLine(" ");
            Console.WriteLine("I tillegg finner du en noen flere ting liggende i helikopteret.");
            Console.WriteLine("Du ser en kniv, en liten spade, en eske med fyrstikker, en hårføner og en lommelykt.");
            Console.WriteLine("Hva er det første du velger å pakke med i sekken?");
            string FirstItem = GetPlayerInput();
            Player.AddItemToInventory(FirstItem);

            Console.WriteLine("Hva er det andre du velger å pakke med i sekken?");
            string SecondItem = GetPlayerInput();
            Player.AddItemToInventory(SecondItem);
            Console.WriteLine("Du pakker ferdig sekken, og helikopteret gjør seg klar for landing.");
            Console.WriteLine("Trykk på 'Enter' for å fortsette.");

            Console.ReadLine();
            Console.Clear();

            Third();
        }

    }
}
