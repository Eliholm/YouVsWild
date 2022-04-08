using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouVsWild
{
    static internal class Player
    {
        static int healthPoints = 3;
        static public List<string> Inventory = new List<string>();

        static public int HealthPoints 
        {
            get { return healthPoints; }
            set 
            { 
                healthPoints = value;
                if (healthPoints <= 0)
                {
                    Console.WriteLine("Du har tatt for mange ukloke valg som har gått utover helsen din.");
                    Console.WriteLine("Du er nødt til å avbryte oppdraget.");
                    Console.WriteLine();
                    Program.RestartGame();
                }
            } 
        } 

        static public bool CheckInventory(string Item)
        {
            return Inventory.Contains(Item.ToLower());
        }

        static public void AddItemToInventory(string Item)
        {
            Inventory.Add(Item.ToLower());
        }
    }

} 

