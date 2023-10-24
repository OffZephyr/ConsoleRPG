using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Attacks
{
    public static void print(Character player)
    {
        printTop();
        printNames(player);
        printBottom();
    }
    static void printTop()
    {
        printOverscore();
        Console.Write("|");
        printOverscore();
        Console.Write("|");
        printOverscore();
        Console.Write("‾");

        void printOverscore()
        {
            for (int i = 0; i < Console.WindowWidth / 3 - 1; i++)
            {
                Console.Write("‾");
            }
        }
        Console.WriteLine();
    }

    static void printNames(Character player)
    {
        Name(player, Character.attackNames, 1);
        Console.Write("|");
        Name(player, Character.attackNames, 2);
        Console.Write("|");
        Name(player, Character.attackNames, 3);

        void Name(Character player, string[] attackName, int num)
        {
            string keyName = baseData.Controls[baseData.Controls.ElementAt(num + 3).Key].ToString();
            if (keyName == ("NumPad" + num.ToString()))
            {
                keyName = num.ToString();
            }
            for (int i = 0; i < (Console.WindowWidth / 6) - (attackName[num-1].Length /2) - (keyName.Length / 2) - 3; i++)
            {
                Console.Write(" ");
            }
            if (num == 1 && baseData.artifactHealth) Console.ForegroundColor = ConsoleColor.DarkMagenta;
            if (num == 2 && baseData.artifactFight) Console.ForegroundColor = ConsoleColor.Red;
            if (num == 3 && baseData.artifactLuck) Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[" + keyName + "] " + attackName[num-1]);
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < (Console.WindowWidth / 6) - (attackName[num-1].Length / 2) - (keyName.Length / 2) - 3; i++)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
    static void printBottom()
    {
        for (int i = 0; i < 2; i++)
        {
            for (int i2 = 0; i2 < Console.WindowWidth / 3 - 1; i2++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
        }
        Console.WriteLine();
    }

}
