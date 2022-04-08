using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouVsWild
{
    public partial class Program
    {
        public static void Eight()
        {
            CheckDogHealth();
            RestartGame();
        }

        public static void CheckDogHealth()
        {
            if (Dog.HealthPoints == 0)
            {
                Console.WriteLine("Dina er glad for å se deg, men du ser raskt at hun er i dårlig form.");
                Console.WriteLine("Hun skjelver og piper, og kaster seg over restene av mat du finner frem fra sekken din.");
                Console.WriteLine("Hun vil klare seg, men trenger tilsyn av veterinær så raskt som mulig.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Dina er overlykkelig for å se deg. Hun løper bort logrende, og virker tilfreds når hun får litt kos.");
                Console.WriteLine("Hun ser ut til å være i god form, omstendighetene tatt i betraktning.");
                Console.WriteLine();
            }
        }

        
       
    }
}
