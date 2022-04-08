using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouVsWild
{
    public partial class Program
    {
        
        public static int WrongDirection = 0;

        public static void Fourth()
        {
            Random random = new Random();
            int RandomNumber = random.Next(1, 5);
            string CorrectDirection;

            switch (RandomNumber)
            {
                case 1:
                    CorrectDirection = "1"; 
                    break;
                case 2:
                    CorrectDirection = "2"; 
                    break;
                case 3:
                    CorrectDirection = "3"; 
                    break;
                case 4:
                    CorrectDirection = "4"; 
                    break;
                default:
                    CorrectDirection = "1";
                    break;
            }

            Console.WriteLine("Det neste du må gjøre er å finne rett kurs. Du tar en titt på kompasset.");
            Console.WriteLine("Hvilken retning vil du gå? Nord, sør, øst eller vest?");
            Console.WriteLine("1: Nord");
            Console.WriteLine("2: Sør");
            Console.WriteLine("3: Øst");
            Console.WriteLine("4: Vest");

            string DirectionChoice = GetPlayerInput();
           
            while (DirectionChoice != CorrectDirection)
            {
                WrongDirection--;
                if (WrongDirection == -3)
                {
                    Console.WriteLine("Du begynner å bli sliten av å traske rundt i den dype snøen, og bekymret for hvor lang tid dette tar.");
                    Console.WriteLine("Du prøver å finne rett kurs en siste gang.");
                    Player.HealthPoints--;
                    break;
                }
                else
                {
                    Console.WriteLine("Du begynner å gå, men forstår etterhvert at du går i feil retning.");
                    Console.WriteLine("Prøv på nytt. Hvilken retning vil du gå?");

                    DirectionChoice = GetPlayerInput();
                    
                } 
            }

            Console.WriteLine();
            Console.WriteLine("Du har funnet rett kurs, og er nå på rett vei for å finne Dina.");

            Console.ReadLine();
            Console.Clear();
            Fifth();
        }

        
    }
}
