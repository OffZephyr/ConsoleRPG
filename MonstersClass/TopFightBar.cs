using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleRPG
{
    public class TopFightBar : baseData
    {
        public static void print()
        {
            printName(player.name, enemy.name);
            printHealth(player, enemy);
            printBottomHealth();
        }
        static void middleSpaces()
        {
            for (int i = 0; i < Console.WindowWidth - 2 * Console.WindowWidth / 3 - 2 * Console.WindowWidth / 10 - 2; i++)
            {
                Console.Write(" ");
            }
        }
        static void printBottomHealth()
        {
            for (int i = 0; i < Console.WindowWidth / 3 + Console.WindowWidth / 10; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");
            middleSpaces();
            Console.Write("|");
            for (int i = 0; i < Console.WindowWidth / 3 + Console.WindowWidth / 10; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("");
        }
        static void printHealth(Character player, Character enemy)
        {
            for (int i = 0; i < (Console.WindowWidth / 10) - player.hp.ToString().Length - player.hpbase.ToString().Length - 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write(player.hp + "/" + player.hpbase + " ");
            new HealthBar(player, false);
            for (int i = 0; i < Console.WindowWidth / 3 - 25; i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            middleSpaces();
            Console.Write("|");
            for (int i = 0; i < Console.WindowWidth / 3 - 25; i++)
            {
                Console.Write(" ");
            }
            new HealthBar(enemy, true);
            Console.Write(" " + enemy.hp + "/" + enemy.hpbase);
            Console.WriteLine();

        }
        static void printName(string name1, string name2)
        {
            for (int i = 0; i < Console.WindowWidth / 10; i++)
            {
                Console.Write(" ");
            }
            Console.Write(name1);
            for (int i = 0; i < Console.WindowWidth / 3 - name1.Length; i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            middleSpaces();
            Console.Write("|");
            for (int i = 0; i < Console.WindowWidth / 3 - name2.Length; i++)
            {
                Console.Write(" ");
            }
            Console.Write(name2);
            for (int i = 0; i < Console.WindowWidth / 10; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("");
        }
    }
}
