using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
        bigSpaces(24, 23, true);
        Console.Write("LV:  ");
        Console.Write(baseData.playerLevel - 1);
        Spaces(1);
        float levelMath = baseData.playerXP / baseData.playerLevel / 3;
        for (int i = 0; i < levelMath; i++)
        {
            Console.Write("|");
        }
        for (int i = 0; i < 30 - levelMath; i++)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("|");
        }
        Spaces(1);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(baseData.playerLevel);
        //Console.Write(" " + baseData.playerXP + " " + levelMath); //DEBUG LEVEL BAR
        bigSpaces(18, 17, false);
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

        void bigSpaces(int amount1, int amount2, bool type)
        {
            if(type)
            {
                if (baseData.playerLevel - 1 >= 10)
                {
                    Spaces(Console.WindowWidth / 4 - amount1);
                }
                else
                {
                    Spaces(Console.WindowWidth / 4 - amount2);
                }
            }
            else
                if (baseData.playerLevel >= 10)
                {
                    Spaces(Console.WindowWidth / 4 -amount1);
                }
                else
                {
                    Spaces(Console.WindowWidth / 4 -amount2);
                }
        }
        
        void printArtifacts()
        {
            if(baseData.artifactHealth)
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
            for(int i = 0; i < Console.WindowWidth / 4 - 15; i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(baseData.keys + " Keys");
        }
    }
}
