/*
 * Student ID : 1690701980
 * Name       : Weerawat
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   
            var rank = 'S';           
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"\nName: {bossName}\nRank {rank}\nLevel: {level} / {MaxLevel}\nHP: {currentHp} / {maxHp}");
            Console.WriteLine($"\nAttack Power: {attackPower}\nCritical Multiplier: {critMultiplier}\nIs Boss: {isBoss}");

            
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp; 
            Console.WriteLine($"HP (double): {currentHpDouble}");

            
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            double hpPercent = currentHpDouble * 100 / maxHp; 
            Console.WriteLine($"HP Percent: (exct):{hpPercent}%");

            
            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            int attackInt = (int)attackPower;  
            Console.WriteLine($"Attack Power (int cast): {attackInt}");

            Console.WriteLine($"\n----- Cast vs Convert: (int)critMultiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);

            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (Convert rounded): {critConvert}");
            Console.WriteLine($"\n----- Cast vs Convert: Crit Multiplier -----");
        }
    }
}
