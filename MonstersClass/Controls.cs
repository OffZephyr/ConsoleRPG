using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class Controls : baseData
    {
        static int menuOption = 0;
        static string controlInput;
        public Controls()
        {
            bool open = true;

            while (open)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                verticalSpaces((Console.WindowHeight/2) - (Controls.Count/2) - (Console.WindowHeight / 12) - 1);
                spaces(4);
                Console.WriteLine("CONTROLS");
                verticalSpaces((Console.WindowHeight / 12));
                for (int i = 0; i < Controls.Count + 1; i++)
                {
                    Console.WriteLine();
                    if (i < Controls.Count)
                    {
                        string controlName = Controls.ElementAt(i).Key;
                        string controlValue = Controls.ElementAt(i).Value;
                        if (menuOption == i)
                        {
                            spaces(((controlName.Length + 3 + controlValue.Length) / 2 + 2));
                        }
                        else
                        {
                            spaces(((controlName.Length + 3 + controlValue.Length) / 2));
                        }
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

                input = Console.ReadKey().Key.ToString();

                if (input == Controls["Move Up"].ToString())
                {
                    if (menuOption > 0)
                    {
                        menuOption--;
                    }
                    else menuOption = Controls.Count - 1;
                }
                if (input == Controls["Move Down"].ToString())
                {
                    if (menuOption < Controls.Count)
                    {
                        menuOption++;
                    }
                    else menuOption = 0;
                }
                if (input == Controls["Return"].ToString())
                {
                    open = false;
                }
                if (input == Controls["Accept"].ToString())
                {
                    if (menuOption != Controls.Count)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        spaces((12 + (Controls.ElementAt(menuOption).Key.Length / 2)));
                        Console.WriteLine("Press a key set it to '" + Controls.ElementAt(menuOption).Key + "'.");
                        controlInput = Console.ReadKey().Key.ToString();
                        Controls[Controls.ElementAt(menuOption).Key] = controlInput;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (menuOption == Controls.Count)
                    {
                        controlsReset();
                    }
                }
            }
        }
    }
}
