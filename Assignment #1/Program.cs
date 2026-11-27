/*
 * Student ID : 1690701980
 * Name       : Weerawat
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Cooking System";
            var DishName = "Fried Chicken";
            var rank = "Chef";
            int chefLevel = 100;
            float cookingRate = 8.25f;
            double cookingTime = 20.5;
            double chicken = 10;
            double flour = 34;
            double oil = 10;
            double taste = 37;
            double crispy = 22;
            double nutrition = 10;
            double cookingSkill = 47;
            bool isAvailable = true;

            Console.WriteLine(@"
================================================
              WELCOME TO COOKING
================================================

                 .-=========-.
                /  _________  \
               /  /         \  \
              |  |  _   _    |  |
              |  | (o) (o)   |  |
              |  |    ^      |  |
               \  \  \_/    /  /
                \  '-------'  /
                 \___________/

                  .-'''''''-.
                .'  FRIED    '.
               /   CHICKEN     \
              |   *  *  *  *    |
               \   *  *  *     /
                '.___________.'

================================================
");

            Console.WriteLine($"Game Title  : {GameTitle}");
            Console.WriteLine($"Dish Name   : {DishName}");
            Console.WriteLine($"Rank        : {rank}");
            Console.WriteLine($"Level       : {chefLevel}");
            Console.WriteLine();

            Console.WriteLine("===== Cooking Attributes =====");
            Console.WriteLine($"Cooking Rate : {cookingRate}");
            Console.WriteLine($"Cooking Time : {cookingTime}");
            Console.WriteLine($"Chicken      : {chicken}");
            Console.WriteLine($"Flour        : {flour}");
            Console.WriteLine($"Oil          : {oil}");
            Console.WriteLine($"Taste        : {taste}");
            Console.WriteLine($"Crispy       : {crispy}");
            Console.WriteLine($"Nutrition    : {nutrition}");
            Console.WriteLine($"Cooking Skill: {cookingSkill}");
            Console.WriteLine($"Available    : {isAvailable}");
            Console.WriteLine();

            double chefLevelAsDouble = chefLevel;
            Console.WriteLine($"Level as double : {chefLevelAsDouble}");

            int tasteTruncated = (int)cookingTime;
            int tasteRounded = Convert.ToInt32(cookingTime);

            Console.WriteLine($"Taste cast    : {tasteTruncated}");
            Console.WriteLine($"Taste Convert : {tasteRounded}");
            Console.WriteLine("==============================");
        }
    }
}
