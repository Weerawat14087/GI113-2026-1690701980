/*
 * Student ID : 1690701980
 * Name       : Weerawat
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW ADVENTURE        |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Name your hero: ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"Welcome, {playerName}. Your journey begins...");
            //_____________________________________________________________________________
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         DIFFICULTY SELECT    |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Choose difficlty (1-3): ");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Difficulty {difficulty} selected. Good Luck out there...\");
            //_____________________________________________________________________________
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         ITEM SHOP            |");
            Console.WriteLine("+------------------------------+");
            Console.Write("How many potions? ");
            bool isValid = int.TryParse(Console.Readline(), out int quantity);
            Console.WriteLine($"Valid input: {isValid}");
            Console.WriteLine($"Quantity: {quantity}");


        }
    }
}
