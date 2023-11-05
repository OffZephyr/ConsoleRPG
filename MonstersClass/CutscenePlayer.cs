using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ConsoleRPG
{
    public class CutscenePlayer : CutsceneData
    {
        public CutscenePlayer(string[,] cutscene)
        {
            Console.Clear();
            Thread.Sleep(2000);
            for (int i = 0; i < cutscene.GetLength(0); i++)
            {
                imageData(cutscene[i,0]);
                text(cutscene[i,1], cutscene[i,2], cutscene[i,3], cutscene[i,4]);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void text(string line1, string line2, string line3, string color)
        {
            int lineNumber = 0;
            bool Done = false;
            while (!Done)
            {
                switch (lineNumber)
                {
                    case 0:
                        writeText(line1, line2, line3, 1);
                        Thread.Sleep(750);
                        Console.Clear();
                        break;
                    case 1:
                        writeText(line1, line2, line3, 2);
                        Thread.Sleep(750);
                        Console.Clear();
                        break;
                    case 2:
                        writeText(line1, line2, line3, 3);
                        Thread.Sleep(250);
                        Done = true;
                        break;
                }
                lineNumber++;

                void writeText(string line1, string line2, string line3, int lines)
                {
                    int step = 0;
                    var color = Console.ForegroundColor;
                    while (step != 3)
                    {
                        switch (step)
                        {
                            case 0:
                                color = ConsoleColor.DarkGray;
                                break;
                            case 1:
                                color = ConsoleColor.Gray;
                                break;
                            case 2:
                                color = ConsoleColor.White;
                                break;
                        }
                        switch (lines)
                        {
                            case 1:
                                Console.ForegroundColor = color;
                                type(line1);
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.White;
                                type(line1);
                                Console.ForegroundColor = color;
                                type(line2);
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.White;
                                type(line1);
                                type(line2);
                                Console.ForegroundColor = color;
                                type(line3);
                                break;
                        }
                        Thread.Sleep(750);
                        step++;
                        if (step != 3) Console.Clear();
                    }

                }
            }
            imagePrint(color, line1, line2, line3);
            Thread.Sleep(2000);
        }
        static void type(string line)
        {
            Space(Console.WindowHeight / 12, line);
            Console.Write(line);
        }
        static void Space(int amount, string line)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine();
            }

            for (int i = 0; i < Console.WindowWidth / 2 - line.Length / 2; i++)
            {
                Console.Write(" ");
            }
        }

        static void imagePrint(string color, string line1, string line2, string line3)
        {
            bool Done = false;
            int amount = 0;
            var imageColor = Console.ForegroundColor;

            while (!Done)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;
                type(line1);
                type(line2);
                type(line3);
                for (int j = 0; j < Console.WindowHeight - frameImageHeight - Console.WindowHeight / 6.5 - 4; j++)
                {
                    Console.WriteLine();
                }

                switch (color)
                {
                    case "red":
                        switch (amount)
                        {
                            case 0:
                                imageColor = ConsoleColor.DarkRed;
                                break;
                            case 1:
                                imageColor = ConsoleColor.Red;
                                break;
                            case 2:
                                imageColor = ConsoleColor.Red;
                                break;
                            case 3:
                                imageColor = ConsoleColor.Red;
                                break;
                            case 4:
                                imageColor = ConsoleColor.DarkRed;
                                break;
                        }
                        break;
                    case "yellow":
                        switch (amount)
                        {
                            case 0:
                                imageColor = ConsoleColor.DarkRed;
                                break;
                            case 1:
                                imageColor = ConsoleColor.Red;
                                break;
                            case 2:
                                imageColor = ConsoleColor.DarkYellow;
                                break;
                            case 3:
                                imageColor = ConsoleColor.Red;
                                break;
                            case 4:
                                imageColor = ConsoleColor.DarkRed;
                                break;
                        }
                        break;
                    case "cyan":
                        switch (amount)
                        {
                            case 0:
                                imageColor = ConsoleColor.DarkBlue;
                                break;
                            case 1:
                                imageColor = ConsoleColor.Blue;
                                break;
                            case 2:
                                imageColor = ConsoleColor.DarkCyan;
                                break;
                            case 3:
                                imageColor = ConsoleColor.Blue;
                                break;
                            case 4:
                                imageColor = ConsoleColor.DarkBlue;
                                break;
                        }
                        break;
                    case "lightyellow":
                        switch (amount)
                        {
                            case 0:
                                imageColor = ConsoleColor.DarkYellow;
                                break;
                            case 1:
                                imageColor = ConsoleColor.Yellow;
                                break;
                            case 2:
                                imageColor = ConsoleColor.White;
                                break;
                            case 3:
                                imageColor = ConsoleColor.DarkYellow;
                                break;
                            case 4:
                                imageColor = ConsoleColor.DarkRed;
                                break;
                        }
                        break;
                    case "green":
                        switch (amount)
                        {
                            case 0:
                                imageColor = ConsoleColor.DarkYellow;
                                break;
                            case 1:
                                imageColor = ConsoleColor.DarkGreen;
                                break;
                            case 2:
                                imageColor = ConsoleColor.Green;
                                break;
                            case 3:
                                imageColor = ConsoleColor.DarkGreen;
                                break;
                            case 4:
                                imageColor = ConsoleColor.DarkYellow;
                                break;
                        }
                        break;
                    case "dark":
                        switch (amount)
                        {
                            case 0:
                                imageColor = ConsoleColor.Black;
                                break;
                            case 1:
                                imageColor = ConsoleColor.DarkGray;
                                break;
                            case 2:
                                imageColor = ConsoleColor.Gray;
                                break;
                            case 3:
                                imageColor = ConsoleColor.DarkGray;
                                break;
                            case 4:
                                imageColor = ConsoleColor.Black;
                                break;
                        }
                        break;
                }
                for (int i = 0; i < frameImageHeight; i++)
                {
                    for (int j = 0; j < Console.WindowWidth / 2 - frameImageWidth / 2; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.ForegroundColor = imageColor;
                    Console.Write(frameImage[i]);
                    Console.WriteLine();
                }
                if (amount < 2) Thread.Sleep(500);
                if (amount == 2) Thread.Sleep(1500);
                if (amount > 2) Thread.Sleep(100);
                Console.Clear();
                amount++;
                if (amount == 5) Done = true;
            }
        }
    }
}