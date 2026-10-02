/*
 * Student ID : 1690701980
 * Name       : Weerawat
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lap03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int level10 = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆSSssss
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;


            Console.WriteLine($"Name: {bossName}" +
                $"(\nRank: {rank})" +
                $"(\nLevel: {level})" +
                $"(\nMax HP: {maxHp} )" +
                $"(\nCurrent HP: {currentHp} )" +
                $"(\nAttack Power: {attackPower})" +
                $"(\nCritical Multiplier: {critMultiplier})" +
                $"(\nIs Boss: {isBoss})");
            // 1.Implicit conversion int {Hp} --> double

            Console.WriteLine("\n------ Implicit Conversion : HP as Double ------");
            double currentHpDouble = currentHp;
            Console.WriteLine($" HP (as Double): {currentHpDouble}");

            //2.Calculate Percentage

            Console.WriteLine("\n------ Exact Hp Percent  (no integer truncation) ------");
            double hpPercentExact = currentHpDouble / maxHp * 100;
            Console.WriteLine($"HP Percent (exact): {hpPercentExact}%");

            //3.Explite Flot (attackPower) --> int

            Console.WriteLine("\n------ Explicit Conversion : Attack Power -> Display ------");
            int attackDisplay = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {attackDisplay}");

            //4 Cast vs Convert double (critMultiplier) --> int

            Console.WriteLine("\n------ Cast vs Convert : Critical Multiplier ------");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (Convert.ToInt32): {critConvert}");



        }
    }
}
