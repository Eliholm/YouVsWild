using System;

namespace YouVsWild
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            First();
        }

        static void SetUpGame()
        {
            Player.AddItemToInventory("Litt mat");
            Player.AddItemToInventory("Ullundertøy");
            Player.AddItemToInventory("Sovepose");
            Player.AddItemToInventory("Kompass");
            Player.AddItemToInventory("Kart");
        }

        static string GetPlayerInput()
        {
            Console.WriteLine();
            string input = Console.ReadLine().ToLower(); 
            Console.WriteLine();
            return input;
        }

        public static void RestartGame()
        {
            Console.WriteLine("Vil du spille igjen, ja eller nei?");
            string Answer = GetPlayerInput();

            if (Answer == "ja" || Answer == "j")
            {
                Console.Clear();
                First();
            }
            else return;
        }
    }
}