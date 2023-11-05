using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class Tutorial : baseData
    {
        string[,] tileTypes = new string[,]
        {
            {"Wall", "Tile that can't be walked on.", "DarkGray"},
            {"Exit Doorway", "Walk on this tile to leave.", "Yellow"},
            {"Key", "This item can be used to open Locked Doors.", "DarkYellow"},
            {"Common Enemy", "Walking on this tile starts a fight.", "DarkRed"},
            {"Health Artifact", "This item gives a 2x Healing Bonus to the player.", "DarkMagenta"},
            {"Fighting Artifact", "This item gives a 1.5x Fight Bonus to the player.", "Red"},
            {"Luck Artifact", "This item gives a Luck Bonus to the player.", "Green"},
            {"Boss Enemy", "Any color not listed above is a Boss Battle.", "White"}
        };
        public Tutorial()
        {
            bool open = true;

            while (open)
            {
                Console.Clear();
                verticalSpaces(Console.WindowHeight / 2 - (tileTypes.GetLength(0) * 3) / 2);
                for (int x = 0; x < tileTypes.GetLength(0); x++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        spaces(Console.WindowWidth / 3);
                        Console.Write("|");
                        if (i == 0) Console.Write("‾‾‾‾‾‾");
                        else if (i == 1) { Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), tileTypes[x, 2]); Console.Write("  ██  "); Console.ForegroundColor = ConsoleColor.White; }
                        else if (i == 2) Console.Write("______");
                        Console.Write("|");
                        for (int j = 0; j < Console.WindowWidth - (2 * (Console.WindowWidth / 3)) - (9 / 2); j++)
                        {
                            if (i == 0) Console.Write("‾‾");
                            if (i == 2) Console.Write("__");
                        }
                        int math = (Console.WindowWidth - (2 * (Console.WindowWidth / 3)) - (9 / 2))*2 - 21 - tileTypes[x, 1].Length;
                        if (i == 1)
                        {
                            for (int j = 0; j < (19 - tileTypes[x, 0].Length) / 2; j++) Console.Write(" ");
                            if (tileTypes[x, 0].Length % 2 == 0) Console.Write(' ');
                            Console.Write(tileTypes[x, 0]);
                            for (int j = 0; j < (19 - tileTypes[x, 0].Length) / 2; j++) Console.Write(" ");
                            Console.Write("| ");
                            Console.Write(tileTypes[x, 1]);
                            
                            for (int j = 0; j < math; j++)
                            {
                                Console.Write(' ');
                            } 
                        }
                        Console.WriteLine("|");
                    }
                }


                input = Console.ReadKey().Key.ToString();
                if (input == Controls["Return"].ToString() || input == Controls["Accept"].ToString())
                {
                    open = false;
                }
            }
        }

        static void colorPrint(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
