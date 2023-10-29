using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class Pause
    {
        public Pause()
        {
        int menuOption;
        string input;
        string[] options = new string[]
        {
        "Resume",
        "Open Map",
        "Controls",
        "How to play?",
        "Quit Game"
        };
        bool open = true;

            menuOption = 0;

            while (open)
            {
                Console.Clear();
                spaces((Console.WindowHeight / 2) - (options.Length + 3), true);
                spaces((Console.WindowWidth / 2) - 6, false);
                Console.WriteLine("GAME  PAUSED");
                spaces(2, true);

                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine();
                    if (menuOption == i)
                    {
                        spaces((Console.WindowWidth / 2) - (options[i].Length / 2) - 2, false);
                        Console.Write("> ");
                    }
                    else spaces((Console.WindowWidth / 2) - (options[i].Length / 2), false);
                    Console.WriteLine(options[i]);
                }

                input = Console.ReadKey().Key.ToString();
                if (input == baseData.Controls["Move Up"].ToString())
                {
                    if (menuOption > 0)
                    {
                        menuOption--;
                    }
                    else menuOption = options.Length - 1;
                }
                if (input == baseData.Controls["Move Down"].ToString())
                {
                    if (menuOption < options.Length - 1)
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
                    switch (menuOption)
                    {
                        case 0:
                            open = false;
                            break;
                        case 1:
                            new Map();
                            break;
                        case 2:
                            new Controls();
                            break;
                        case 3:
                            new Tutorial();
                            break;
                        case 4:
                            new RESET();
                            break;
                    }
                }
            }
        }
        static void spaces(int space, bool vertical)
        {
            if (vertical)
            {
                for (int j = 0; j < space; j++)
                {
                    Console.WriteLine();
                }
            }
            else
            {
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}