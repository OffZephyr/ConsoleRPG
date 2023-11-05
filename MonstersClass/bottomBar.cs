using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleRPG
{
    public class bottomBar
    {
        public static void print()
        {
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("_");
            }

            Spaces(Console.WindowWidth / 2 - 1);
            Console.WriteLine("|");
            Spaces(Console.WindowWidth / 4 - (baseData.playerLevel - 1).ToString().Length - 24);
            Console.Write("LV:  ");
            Console.Write(baseData.playerLevel - 1);
            Spaces(1);
            int levelMath = baseData.playerXP /  baseData.playerLevel / 3;
            if (levelMath <= 30)
            {
                for (int i = 0; i < levelMath; i++)
                {
                    Console.Write("|");
                }
            }
            else
            {
                int removeMath = levelMath - 30;
                for (int i = 0; i < levelMath - removeMath; i++)
                {
                    Console.Write("|");
                }
            }
            for (int i = 0; i < 30 - levelMath; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("|");
            }
            Spaces(1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(baseData.playerLevel);
            Console.Write(" (" + baseData.playerXP + "/" + 100 * baseData.playerLevel + ")");
            Spaces(Console.WindowWidth / 4 - baseData.playerLevel.ToString().Length - 18 - baseData.playerXP.ToString().Length - (100 * baseData.playerLevel).ToString().Length);
            Console.Write("|");
            Spaces(Console.WindowWidth / 4 - 5);
            printArtifacts();
            Spaces(Console.WindowWidth / 2 - 1);
            Console.WriteLine("|");

            void Spaces(int amount)
            {
                for (int i = 0; i < amount; i++)
                {
                    Console.Write(" ");
                }
            }

            void printArtifacts()
            {
                if (baseData.artifactHealth)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("██");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("██");
                }
                Console.Write("  ");
                if (baseData.artifactFight)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("██");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("██");
                }
                Console.Write("  ");
                if (baseData.artifactLuck)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("██");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("██");
                }
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < Console.WindowWidth / 4 - 15; i++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(baseData.keys + " Keys");
            }
        }
    }
}
