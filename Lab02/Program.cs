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
            int levels = 80;
            int xHp = 500;
            int hp = 445;
            float power = 85.5f;
            double crit = 50.50;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {boss}");
            Console.WriteLine($"Rank: {rankA}");
            Console.WriteLine($"HP: {hp} / {xHp}");
            Console.WriteLine($"Attack power: {power}");
            Console.WriteLine($"Critmultiplier: {crit}");
            Console.WriteLine($"Is boss: {isBoss}");

            string playerName = "Geer";
            char rankPlayer = 'S';
            int levelPlayer = 50;
            int maxHpPlayer = 200;
            int currentHpPlayer = 145;
            float attackPowerPlayer = 55.5f;
            double critMultiplierPlayer = 45.50;
            bool isPlayer = true;

            Console.WriteLine("===== PLAYER STATUS: INITIAL =====");
            Console.WriteLine($"Name: {playerName}");
            Console.WriteLine($"Rank: {rankPlayer}");
            Console.WriteLine($"HP: {currentHpPlayer} / {maxHpPlayer}");
            Console.WriteLine($"Attack power: {attackPowerPlayer}");
            Console.WriteLine($"Critmultiplier: {critMultiplierPlayer}");
            Console.WriteLine($"Is player: {isPlayer}");

            string npcName = "Por";
            char rankNpc = 'f';
            int levelNpc = 1;
            int maxHpNpc = 100;
            int currentHpNpc = 95;
            float attackPowerNpc = 2.5f;
            double critMultiplierNpc = 0.50;
            bool isNpc = true;

            Console.WriteLine("===== NPC STATUS: INITIAL =====");
            Console.WriteLine($"Name: {npcName}");
            Console.WriteLine($"Rank: {rankNpc}");
            Console.WriteLine($"HP: {currentHpNpc} / {maxHpNpc}");
            Console.WriteLine($"Attack power: {attackPowerNpc}");
            Console.WriteLine($"Critmultiplier: {critMultiplierNpc}");
            Console.WriteLine($"Is npc: {isNpc}");

            string mpcName = "Geer";
            char rankMpc = 'B';
            int levelMpc = 5;
            int maxHpMpc = 100;
            int currentHpMpc = 85;
            float attackPowerMpc = 5.5f;
            double critMultiplierMpc = 1.50;
            bool isMpc = true;

            Console.WriteLine("===== MPC STATUS: INITIAL =====");
            Console.WriteLine($"Name: {mpcName}");
            Console.WriteLine($"Rank: {rankMpc}");
            Console.WriteLine($"HP: {currentHpMpc} / {maxHpMpc}");
            Console.WriteLine($"Attack power: {attackPowerMpc}");
            Console.WriteLine($"Critmultiplier: {critMultiplierMpc}");
            Console.WriteLine($"Is mpc: {isMpc}");




        }
    }
}
