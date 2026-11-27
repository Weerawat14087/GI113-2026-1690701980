/*
 * Student ID : 1690701980
 * Name       : Weerawat
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
using System;

class Program
{
    const string MaterialName = "Chicken";
    const double CookingRate = 0.50;
    const double SalvageRate = 0.30;
    const double MaxBatch = 500.0;

    static void Main()
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("--    Welcome to Cooking Shop    --");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"=> {MaterialName} Cooking {CookingRate:F2} / Salvage {SalvageRate:F2}");
        Console.WriteLine($"=> Key 'C' for Cooking (Chicken -> Fried Chicken)");
        Console.WriteLine($"=> Key 'B' for Breakdown (Fried Chicken -> Chicken)");

        Console.Write("=> Choose Menu: ");
        char.TryParse(Console.ReadLine(), out char menu);

        Console.Write("=> How much would you like: ");
        bool amountParsed = double.TryParse(Console.ReadLine(), out double amount);

        if (amountParsed && amount > 0 && amount <= MaxBatch)
        {
            if (menu == 'C' || menu == 'c')
            {
                double food = amount * CookingRate;

                Console.WriteLine(
                    $"=> {amount:F2} {MaterialName} = {food:F2} Fried Chicken");
            }
            else if (menu == 'B' || menu == 'b')
            {
                double chicken = amount / SalvageRate;

                Console.WriteLine(
                    $"=> {amount:F2} Fried Chicken = {chicken:F2} {MaterialName}");
            }
            else
            {
                Console.WriteLine("Error: Invalid menu.");
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid amount.");
        }
    }
}
