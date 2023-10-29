using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class Tutorial
    {
        public Tutorial()
        {
            bool open = true;
            string input;
            string line;

            while (open)
            {
                Console.Clear();
                line = " is a Key. It can be used to open blocked paths.";
                spaces(line.Length + 2);
                colorPrint("██", ConsoleColor.DarkYellow);
                Console.WriteLine(line);
                Console.WriteLine();

                line = " is a Common Enemy. Going near it will trigger a fight.";
                spaces(line.Length + 2);
                colorPrint("██", ConsoleColor.DarkRed);
                Console.WriteLine(line);
                Console.WriteLine();

                line = " is a Healing Artifact. It grants a 2x healing boost when collected.";
                spaces(line.Length + 2);
                colorPrint("██", ConsoleColor.DarkMagenta);
                Console.WriteLine(line);
                Console.WriteLine();

                line = " is a Fighting Artifact. It grants a 1.5x fighting boost when collected.";
                spaces(line.Length + 2);
                colorPrint("██", ConsoleColor.Red);
                Console.WriteLine(line);
                Console.WriteLine();

                line = " is a Luck Artifact. It grants a higher chance of landing a special hit when collected.";
                spaces(line.Length + 2);
                colorPrint("██", ConsoleColor.Green);
                Console.WriteLine(line);
                Console.WriteLine();


                input = Console.ReadKey().Key.ToString();
                if (input == baseData.Controls["Return"].ToString())
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
        static void spaces(int length)
        {
            for(int i = 0; i < Console.WindowWidth/2 - length / 2; i++)
            {
                Console.Write(" ");
            }
        }
    }
}
