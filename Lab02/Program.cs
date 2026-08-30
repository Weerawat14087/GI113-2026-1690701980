/*
 * Student ID :1690701980
 * Name       :Weerawat
 * Section    :129C
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part A

            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack power: {attackPower}");
            Console.WriteLine($"Critmultiplier: {critMultiplier}");
            Console.WriteLine($"Is boss: {isBoss}");

            Console.WriteLine("");

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine("");
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine("");

            currentHp = currentHp - 60;
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            //Part B

            string boss = "Leet Boss";
            char rankA = 'A';
            int levels = 5;
            int xHp = 200;
            int hp = 145;
            float power = 35.5f;
            double crit = 1.50;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {boss}");
            Console.WriteLine($"Rank: {rankA}");
            Console.WriteLine($"HP: {hp} / {xHp}");
            Console.WriteLine($"Attack power: {power}");
            Console.WriteLine($"Critmultiplier: {crit}");
            Console.WriteLine($"Is boss: {isBoss}");

            Console.WriteLine("");

            int hpPercent = hp * 100 / xHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine("");
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine("");

            currentHp = currentHp - 60;
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {hp} / {hp}");
            hpPercent = hp * 100 / xHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");


        }
    }
}
