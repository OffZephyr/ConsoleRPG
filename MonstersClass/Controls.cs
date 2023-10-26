using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class Controls
    {
        static int menuOption = 0;
        static string input;
        static string controlInput;
        static bool changeKey;
        public Controls()
        {
            bool open = true;

            while (open)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                verticalSpaces((Console.WindowHeight/2) - (baseData.Controls.Count/2) - (Console.WindowHeight / 12) - 1);
                spaces(4);
                Console.WriteLine("CONTROLS");
                verticalSpaces((Console.WindowHeight / 12));
                for (int i = 0; i < baseData.Controls.Count + 1; i++)
                {
                    Console.WriteLine();
                    if (i < baseData.Controls.Count)
                    {
                        string controlName = baseData.Controls.ElementAt(i).Key;
                        string controlValue = baseData.Controls.ElementAt(i).Value;
                        if (menuOption == i)
                        {
                            spaces(((controlName.Length + 3 + controlValue.Length) / 2) + 2);
                        }
                        else
                        {
                            spaces((controlName.Length + 3 + controlValue.Length) / 2);
                        }
                        if (changeKey) Console.ForegroundColor = ConsoleColor.Green;
                        if (menuOption == i) Console.Write("> ");
                        Console.Write(controlName + " : " + controlValue);
                    }
                    else
                    {
                        if (menuOption == i)
                        {
                            spaces(7);
                        }
                        else
                        {
                            spaces(5);
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (menuOption == i) Console.Write("> ");
                        Console.Write("Reset Keys");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }
                verticalSpaces((Console.WindowHeight / 12));

                if (changeKey) controlInput = Console.ReadKey().Key.ToString();
                if (!changeKey) input = Console.ReadKey().Key.ToString();

                if (input == baseData.Controls["Move Up"].ToString())
                {
                    if (menuOption > 0)
                    {
                        menuOption--;
                    }
                    else menuOption = baseData.Controls.Count - 1;
                }
                if (input == baseData.Controls["Move Down"].ToString())
                {
                    if (menuOption < baseData.Controls.Count)
                    {
                        menuOption++;
                    }
                    else menuOption = 0;
                }
                if (input == baseData.Controls["Return"].ToString())
                {
                    open = false;
                }
                if (input == baseData.Controls["Accept"].ToString())
                {
                    if (menuOption != baseData.Controls.Count)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        spaces(12 + (baseData.Controls.ElementAt(menuOption).Key.Length / 2));
                        Console.WriteLine("Press a key set it to '" + baseData.Controls.ElementAt(menuOption).Key + "'.");
                        controlInput = Console.ReadKey().Key.ToString();
                        baseData.Controls[baseData.Controls.ElementAt(menuOption).Key] = controlInput;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (menuOption == baseData.Controls.Count)
                    {
                        baseData.controlsReset();
                    }
                }
            }
        }
        static void spaces(int distance)
        {
            for (int i = 0; i < Console.WindowWidth / 2 - distance; i++)
            {
                Console.Write(" ");
            }
        }
        static void verticalSpaces(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("");
            }

        }
    }
}
