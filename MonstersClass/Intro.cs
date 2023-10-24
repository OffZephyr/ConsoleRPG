using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Intro
{
    static string[] frameImage = new string[Console.WindowHeight];
    static int frameImageWidth;
    static int frameImageHeight;
    static string input;
    static bool hasStarted;

    public static void initialize()
    {
        hasStarted = false;
        baseData.controlsReset();
        while (!hasStarted)
        {
            Console.Clear();
            Console.Write("Would you like to watch the intro? [y/n] : ");
            input = Console.ReadKey().Key.ToString();
            switch (input)
            {
                case "Y":
                    hasStarted = true;
                    start();
                    break;
                case "N":
                    hasStarted = true;
                    MainMenu.Start();
                    break;
            }
        }
    }
    static void start()
    {
        Console.Clear();
        Thread.Sleep(2000);

        imageData("ShrekHead");
        text("In a NOT so distant land", "Located in the Windows Console", "A Terrible Threat appeared...", 1);

        imageData("Destruction");
        text("It caused Destruction and Chaos", "And everyone had lost HOPE", "Until one day...", 0);

        imageData("Hero");
        text("A Brave HERO appeared beyond the horizon", "A HERO able to save everyone and SLAIN THE BEAST", "And that HERO was YOU...", 2);

        MainMenu.Start();


    }
    static void text(string line1, string line2, string line3, int color)
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
                    switch(lines)
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

    static void imagePrint(int color, string line1, string line2, string line3)
    {
        bool Done = false;
        int amount = 0;
        var imageColor = Console.ForegroundColor;

        while (!Done)
        {
            Console.Clear();

            Console.ForegroundColor= ConsoleColor.White;
            type(line1);
            type(line2);
            type(line3);
            for (int j = 0; j < Console.WindowHeight - frameImageHeight - Console.WindowHeight / 6.5 - 4 ; j++)
            {
                Console.WriteLine();
            }

            switch (color)
            {
                case 0:
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
                case 1:
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
                case 2:
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
    static void imageData(string name)
    {
        switch(name)
        {
            case "ShrekHead":
                frameImageWidth = 31;
                frameImageHeight = 15;

                frameImage[0] = "⢀⡴⠑⡄⠀⠀⠀⠀⠀⠀⠀⣀⣀⣤⣤⣤⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ";
                frameImage[1] = "⠸⡇⠀⠿⡀⠀⠀⠀⣀⡴⢿⣿⣿⣿⣿⣿⣿⣿⣷⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ";
                frameImage[2] = "⠀⠀⠀⠀⠑⢄⣠⠾⠁⣀⣄⡈⠙⣿⣿⣿⣿⣿⣿⣿⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀ ";
                frameImage[3] = "⠀⠀⠀⠀⢀⡀⠁⠀⠀⠈⠙⠛⠂⠈⣿⣿⣿⣿⣿⠿⡿⢿⣆⠀⠀⠀⠀⠀⠀⠀ ";
                frameImage[4] = "⠀⠀⠀⢀⡾⣁⣀⠀⠴⠂⠙⣗⡀⠀⢻⣿⣿⠭⢤⣴⣦⣤⣹⠀⠀⠀⢀⢴⣶⣆ ";
                frameImage[5] = "⠀⠀⢀⣾⣿⣿⣿⣷⣮⣽⣾⣿⣥⣴⣿⣿⡿⢂⠔⢚⡿⢿⣿⣦⣴⣾⠁⠸⣼⡿ ";
                frameImage[6] = "⠀⢀⡞⠁⠙⠻⠿⠟⠉⠀⠛⢹⣿⣿⣿⣿⣿⣌⢤⣼⣿⣾⣿⡟⠉⠀⠀⠀⠀⠀ ";
                frameImage[7] = "⠀⣾⣷⣶⠇⠀⠀⣤⣄⣀⡀⠈⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀ ";
                frameImage[8] = "⠀⠉⠈⠉⠀⠀⢦⡈⢻⣿⣿⣿⣶⣶⣶⣶⣤⣽⡹⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀ ";
                frameImage[9] = "⠀⠀⠀⠀⠀⠀⠀⠉⠲⣽⡻⢿⣿⣿⣿⣿⣿⣿⣷⣜⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀ ";
                frameImage[10] = "⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣷⣶⣮⣭⣽⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀ ";
                frameImage[11] = "⠀⠀⠀⠀⠀⠀⣀⣀⣈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⠀⠀⠀⠀⠀⠀⠀ ";
                frameImage[12] = "⠀⠀⠀⠀⠀⠀⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀ ";
                frameImage[13] = "⠀⠀⠀⠀⠀⠀⠀⠹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀ ";
                frameImage[14] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠛⠻⠿⠿⠿⠿⠛⠉             ";
                break;
            case "Destruction":
                frameImageWidth = 98;
                frameImageHeight = 18;

                frameImage[0] = "                                 ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⠔⠊⠉⠉⠑⠢⡀⠀⠀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                frameImage[1] = "                                 ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣴⠒⠉⢀⣠⣤⣈⠁⠀⠀⢘⣦⣼⡿⣿⣞⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                frameImage[2] = "                                 ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡿⣷⡄⣿⢯⣈⣹⡆⠄⠐⣇⢈⡴⠛⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                frameImage[3] = "                                 ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⡿⣃⠸⣿⣯⣿⠽⠀⠀⠈⠋⢳⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                frameImage[4] = "                                 ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⠀⠀⠀⡙⣦⠀⠀⠀⠀⠀⠀⠀⠘⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                frameImage[5] = "                                 ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⢿⡓⠿⠟⠛⠉⢳⡀⠀⠀⠀⠀⠀⠀⠙⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                frameImage[6] = "                                 ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡆⣄⣀⣀⣀⣀⣀⠁⠀⠀⠀⠀⠀⠀⠀⠘⣆⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                frameImage[7] = "                                 ⠀⠀⠀⠀⠀⠀⠀⢀⡀⠀⠀⠀⠀⠀⣷⡿⠛⠉⠉⠉⠀⠀⠀⠀⢀⡆⠐⠀⠀⠀⢹⣿⣹⡷⢤⣀⣀⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                frameImage[8] = "                                 ⠀⠀⠀⠀⠀⣠⡾⠋⠈⠉⠁⠈⠉⠉⠙⡷⢄⣀⠦⠴⠊⠀⠒⣨⠍⠂⠀⠀⠀⠀⠀⣿⣿⣿⣠⣿⡿⠛⠉⠉⠓⠢⢤⣀⡤⠤⠄⠀⠀⠀⣀⣀⣤⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                frameImage[9] = "                                 ⢀⣴⣊⣍⠁⣿⠀⠀⠀⠀⠀⠀⠀⠀⢰⣷⣤⠤⠤⣄⣀⣾⡝⠁⠀⠀⠀⠀⠀⠀⢰⣿⣿⣿⣿⡿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⠿⠿⠷⠄⢀⣀⣀⠀⠀⠀⠀⠀⠀";
                frameImage[10] = "⠀⠀⠀⠀⠀⠀⢱⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢱⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢱⣆⢟⡴⠻⣶⣤⣤⡤⢤⣴⣤⣀⣼⢱⣆⣿⠛⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⢱⣆⣿⣿⣿⡟⠁⠀⢠⠀⠀⠀⠀⠀⢱⣆⠀⠀⠀⠀⠀⣿⡏⠀⠀⠀⠀⠀⢱⣆⣺⢽⣽⣦⣀⠀";
                frameImage[11] = "⠀⠀⠀⠀⠀⠀⠈⣿⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣷⡀⠉⠀⠀⠀⠀⠀⠀⠀⠀⣿⠈⣿⣷⡀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⠈⣿⣷⡀⡟⠁⠀⠀⠀⢧⡀⠀⢀⣀⠈⣿⣷⡀⠀⠀⠀⣿⡗⡄⠀⠀⠀⢀⠈⣿⣷⡀⣎⠻⣮⡷";
                frameImage[12] = "⠀⠀⠀⠀⠀⠀⢸⣿⣿⣷⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣷⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣷⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣷⣧⠀⠀⠀⢀⣠⣾⣿⣿⣿⢸⣿⣿⣷⣧⠂⠀⠀⢲⣿⠟⠛⠋⠉⢸⣿⣿⣷⣧⠤⣤⣽⣷⣄⠀⠀⣾⠛⢸⣿⣿⣷⣧⣆⠱⣼";
                frameImage[13] = "⠀⠀⠀⠀⡀⢠⣿⡟⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⡀⢠⣿⡟⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⡀⢠⣿⡟⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⡀⢠⣿⡟⣿⣿⣿⡇⣶⣶⣿⣿⣿⣿⡀⢠⣿⡟⣿⣿⣿⡇⣵⣶⣾⣿⠀⠀⡀⢠⣿⡟⣿⣿⣿⡇⠀⠈⠉⠈⢦⠀⡀⢠⣿⡟⣿⣿⣿⡇⣤⡾";
                frameImage[14] = "⠀⠀⠀⠀⣳⣼⣿⡏⢸⣿⣿⣿⢀⠀⠀⠀⠀⠀⣳⣼⣿⡏⢸⣿⣿⣿⢀⠀⠀⠀⠀⠀⣳⣼⣿⡏⢸⣿⣿⣿⢀⠀⠀⠀⠀⠀⣳⣼⣿⡏⢸⣿⣿⣿⢀⠻⣿⣿⣿⣿⣳⣼⣿⡏⢸⣿⣿⣿⢀⣿⣿⣿⠀⠀⣳⣼⣿⡏⢸⣿⣿⣿⢀⠀⠀⠀⠈⢆⣳⣼⣿⡏⢸⣿⣿⣿⢀⠀";
                frameImage[15] = "⠀⠀⠀⣰⣿⣿⡿⠁⢸⣿⣿⡟⣼⡆⠀⠀⠀⣰⣿⣿⡿⠁⢸⣿⣿⡟⣼⡆⠀⠀⠀⣰⣿⣿⡿⠁⢸⣿⣿⡟⣼⡆⠀⠀⠀⣰⣿⣿⡿⠁⢸⣿⣿⡟⣼⡆⣿⣿⣿⣰⣿⣿⡿⠁⢸⣿⣿⡟⣼⡆⣿⡿⠀⣰⣿⣿⡿⠁⢸⣿⣿⡟⣼⡆⠀⠀⠀⣰⣿⣿⡿⠁⢸⣿⣿⡟⣼⡆";
                frameImage[16] = "⢰⢀⣾⣿⣿⠟⠀⠀⣾⢿⣿⣿⣿⣿⢰⢀⣾⣿⣿⠟⠀⠀⣾⢿⣿⣿⣿⣿⢰⢀⣾⣿⣿⠟⠀⠀⣾⢿⣿⣿⣿⣿⢰⢀⣾⣿⣿⠟⠀⠀⣾⢿⣿⣿⣿⣿⢰⢀⣾⣿⣿⠟⠀⠀⣾⢿⣿⣿⣿⣿⢰⢀⣾⣿⣿⠟⠀⠀⣾⢿⣿⣿⣿⣿⢰⢀⣾⣿⣿⠟⠀⠀⣾⢿⣿⣿⣿⣿";
                frameImage[17] = "⢸⣿⣿⣿⡏⠀⠀⠀⠃⠸⣿⣿⣿⡿⢸⣿⣿⣿⡏⠀⠀⠀⠃⠸⣿⣿⣿⡿⢸⣿⣿⣿⡏⠀⠀⠀⠃⠸⣿⣿⣿⡿⢸⣿⣿⣿⡏⠀⠀⠀⠃⠸⣿⣿⣿⡿⢸⣿⣿⣿⡏⠀⠀⠀⠃⠸⣿⣿⣿⡿⢸⣿⣿⣿⡏⠀⠀⠀⠃⠸⣿⣿⣿⡿⢸⣿⣿⣿⡏⠀⠀⠀⠃⠸⣿⣿⣿⡿";
                break;
            case "Hero":
                frameImageWidth = 22;
                frameImageHeight = 19;

                frameImage[0] = "⠀⠀⠀⠀⠀⠀⠀⣠⣶⣿⣶⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀";
                frameImage[1] = "⠀⠀⠀⠀⠀⠀⣼⣿⣿⣿⣿⣿⣷⡄⠀⠀⠀⠀⠀⠀⠀";
                frameImage[2] = "⠀⠀⠀⠀⢀⣾⣿⣿⣿⣿⣿⣿⣿⣷⡄⠀⠀⠀⠀⠀⠀";
                frameImage[3] = "⠀⠀⢀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡀⠀⠀⠀⠀";
                frameImage[4] = "⢀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⠀⠀⠀";
                frameImage[5] = "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡀⠀";
                frameImage[6] = "⠘⠿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⠀";
                frameImage[7] = "⠀⠀⠀⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠋⣁⣀⠄";
                frameImage[8] = "⠀⠀⠀⠀⢿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠛⠋⢁⢰⣿⡷⠀";
                frameImage[9] = "⠀⠀⠀⠀⠀⠉⠻⠻⠟⣿⣿⣿⣤⣄⡀⣾⣼⣿⣿⣧⣀";
                frameImage[10] = "⠀⠀⠀⠀⠀⠀⠀⣰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿";
                frameImage[11] = "⠀⠀⠀⠀⠀⣠⣾⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿";
                frameImage[12] = "⠀⠀⣀⣴⣾⣟⠁⣿⣿⣿⣿⣿⣿⣿⣦⠈⢿⣷⣍⡀⠀";
                frameImage[13] = "⠀⢰⣿⠿⢻⣟⠀⣿⣿⣿⣿⣿⣿⣿⣷⡤⠸⢿⣿⣿⡆";
                frameImage[14] = "⠀⠀⡿⠀⠀⠀⠈⠻⣿⣿⣿⣿⣿⣿⣟⣠⣀⠀⠙⠿⠅";
                frameImage[15] = "⠀⠀⠀⠀⠀⠀⠀⠀⠘⢿⣿⣿⣿⣿⣿⣿⣿⣆⠀⠀⠀";
                frameImage[16] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⣿⣿⠛⠋⣹⣿⣿⣿⡆⠀⠀";
                frameImage[17] = "⠀⠀⠀⠀⣠⣾⣿⣿⣾⣿⣿⡏⠀⠘⠿⣿⣿⣿⡇⠀⠀";
                frameImage[18] = "⠀⠀⠀⠀⠹⠿⠿⢿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                break;
        }

    }
}