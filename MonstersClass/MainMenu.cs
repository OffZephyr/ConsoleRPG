using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

public class MainMenu
{

    public static bool mainTitle = false;
    static int menu = 0;
    static int menuOption = 0;
    static string input;
    static string controlInput;
    static bool changeKey;

    //ConsoleKey.Escape
    public static
    void Refresh()
    {
        Console.Clear();
        Console.Write(menu);
        Console.Write(" " + menuOption);
        switch (menu)
        {
            case 1:
                printTitle(2, 5, 0);
                printOptions("> Press Enter <", "", "", "", "", ConsoleColor.White, ConsoleColor.White, ConsoleColor.White, ConsoleColor.White);
                break;
            case 2:
                printTitle(2, 9, 0);
                printOptions("", "NEW GAME", "Controls", "How to play?", "Credits", ConsoleColor.White, ConsoleColor.White, ConsoleColor.White, ConsoleColor.White);
                break;
            case 3:
                printTitle(2, 9, 0);
                printOptions("PLEASE PICK A DIFFICULTY:", "EASY", "NORMAL", "HARD", "INSANE", ConsoleColor.Green, ConsoleColor.DarkYellow, ConsoleColor.Red, ConsoleColor.DarkMagenta);
                break;
            case 4:
                printOptions("", "", "", "", "", ConsoleColor.White, ConsoleColor.White, ConsoleColor.White, ConsoleColor.White);
                break;
            case 5:
                printOptions("How to play ?", "", "", "", "", ConsoleColor.White, ConsoleColor.White, ConsoleColor.White, ConsoleColor.White);
                break;
            case 6:
                printOptions("", "", "", "", "", ConsoleColor.White, ConsoleColor.White, ConsoleColor.White, ConsoleColor.White);
                break;
            case 7:
                printTitle(2, 9, 0);
                printOptions("PLEASE PICK A CHARACTER:", "Smurf Cat", "Crewmate", "Saul Goodman", "", ConsoleColor.DarkCyan, ConsoleColor.Red, ConsoleColor.DarkYellow, ConsoleColor.White);
                break;
        }
    }
    public static void Start()
    {
        menu = 1;
        mainTitle = true;
        Console.Clear();
        printTitle(0, 5, 150);
        Console.Clear();
        printTitle(1, 5, 150);
        Console.Clear();
        printTitle(2, 5, 0);
        verticalSpaces(12);
        Refresh();
        
    }
    static void printTitle(int dark, int vertSpace, int sleep)
    {
        verticalSpaces(vertSpace);
        switch (dark)
        {
            case 0: Console.ForegroundColor = ConsoleColor.DarkGray; break;
            case 1: Console.ForegroundColor = ConsoleColor.DarkCyan; break;
            case 2: Console.ForegroundColor = ConsoleColor.Cyan; break;
        }
        Console.WriteLine(" ");
        spaces(40);
        Console.WriteLine(" ____ ___       __  .__  __  .__             .___ ____________________  ________ ");
        spaces(40);
        Console.WriteLine("|    |   \\_____/  |_|__|/  |_|  |   ____   __| _/ \\______   \\______   \\/  _____/ ");
        spaces(40);
        Console.WriteLine("|    |   /    \\   __\\  \\   __\\  | _/ __ \\ / __ |   |       _/|     ___/   \\  ___ ");
        spaces(40);
        Console.WriteLine("|    |  /   |  \\  | |  ||  | |  |_\\  ___// /_/ |   |    |   \\|    |   \\    \\_\\  \\");
        spaces(40);
        Console.WriteLine("|______/|___|  /__| |__||__| |____/\\___  >____ |   |____|_  /|____|    \\______  /");
        spaces(40);
        Console.WriteLine("             \\/                        \\/     \\/          \\/                  \\/ ");

        Thread.Sleep(sleep);
    }

    static void printOptions(string subtitle, string option1, string option2, string option3, string option4, object color1, object color2, object color3, object color4)
    {
        var optionsList = new List<string>()
        {
            option1, option2, option3, option4
        };

        var colorList = new List<object>()
        {
            color1, color2, color3, color4
        };

        Console.ForegroundColor = ConsoleColor.White;
        verticalSpaces(9);
        spaces(subtitle.Length / 2);
        Console.WriteLine(subtitle);

        switch (menu)
        {
            default:
                if (option1 != "")
                {
                    verticalSpaces(24);
                    for (int i = 0; i < optionsList.Count; i++)
                    {
                        verticalSpaces(24);
                        if (menuOption == i)
                        {
                            spaces((optionsList[i].Length / 2) + 2);
                        }
                        else
                        {
                            spaces(optionsList[i].Length / 2);
                        }
                        Console.ForegroundColor = (ConsoleColor)colorList[i];
                        if (menuOption == i) Console.Write("> ");
                        Console.Write(optionsList[i]);
                        if (menuOption == i) Console.Write(" <");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                break;
            case 4:
                    Console.ForegroundColor = ConsoleColor.White;
                    verticalSpaces( + (baseData.Controls.Count + (baseData.Controls.Count*(Console.WindowHeight / 18))) / 2);
                    spaces(4);
                    Console.WriteLine("CONTROLS");
                    for (int i = 0; i < baseData.Controls.Count + 1; i++)
                    {

                        verticalSpaces(18);
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
                if (changeKey == true) controlInput = Console.ReadKey().Key.ToString();
                    break;
            case 6:
                Console.ForegroundColor = ConsoleColor.White;
                verticalSpaces(+(baseData.Controls.Count + (baseData.Credits.Count * (Console.WindowHeight / 12))) / 2);
                spaces(4);
                Console.WriteLine("CREDITS");
                for (int i = 0; i < baseData.Credits.Count; i++)
                {

                    verticalSpaces(12);
                        string creditName = baseData.Credits.ElementAt(i).Key;
                        if (menuOption == i)
                        {
                            spaces(((creditName.Length) / 2) + 2);
                        }
                        else
                        {
                            spaces((creditName.Length) / 2);
                        }
                        if (changeKey) Console.ForegroundColor = ConsoleColor.Green;
                        if (menuOption == i) Console.Write("> ");
                        Console.Write(creditName);

                }
                if (changeKey == true) controlInput = Console.ReadKey().Key.ToString();
                break;
        }


        verticalSpaces(12);
        Console.WriteLine();
        if (menu > 0 && changeKey == false) input = Console.ReadKey().Key.ToString();
        menuChange();

        void menuChange()
        {
            if (menu != 0)
            {
                if (input == baseData.Controls["Return"])
                {
                    switch (menu)
                    {
                        default:
                            menu--;
                            menuOption = 0;
                            break;
                        case 1:
                            menu--;
                            Intro.initialize();
                            break;
                        case 4:
                            menu = 2;
                            menuOption = 0;
                            break;
                        case 5:
                            menu = 2;
                            menuOption = 0;
                            break;
                        case 6:
                            menu = 2;
                            menuOption = 0;
                            break;
                        case 7:
                            menu = 3;
                            menuOption = 0;
                            break;
                    }
                    menuOption = 0;
                }
                if (input == baseData.Controls["Accept"])
                {
                    switch (menu)
                    {
                        case 1:
                            menu = 2;
                            menuOption = 0;
                            break;
                        case 2:
                            menu = menuOption + 3;
                            menuOption = 0;
                            break;
                        case 3:
                            Character.difficulty = menuOption + 1;
                            menu = 7;
                            menuOption = 0;
                            break;
                        case 4:
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

                            break;
                        case 6:
                            var uri = baseData.Credits[baseData.Credits.ElementAt(menuOption).Key];
                            var psi = new System.Diagnostics.ProcessStartInfo();
                            psi.UseShellExecute = true;
                            psi.FileName = uri;
                            System.Diagnostics.Process.Start(psi);
                            break;
                        case 7:
                            Character.playerCharacter = menuOption + 1;
                            menu = 0;
                            menuOption = 0;
                            break;
                    }
                    Refresh();
                    menuOption = 0;
                }
                if (input == baseData.Controls["Move Down"])
                {
                    if (option4 == "" && menuOption < 2)
                    {
                        menuOption++;
                    }
                    else if (option4 != "" && menuOption < 3)
                    {
                        menuOption++;
                    }
                    else if (menu == 4 && menuOption < baseData.Controls.Count)
                    {
                        menuOption++;
                    }
                    else if (menu == 5 && menuOption < baseData.Credits.Count - 1)
                    {
                        menuOption++;
                    }
                }
                if (input == baseData.Controls["Move Up"] && menuOption != 0)
                {
                    menuOption--;
                }
                Refresh();
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
    static void verticalSpaces(int fraction)
    {
        for (int i = 0; i < Console.WindowHeight / fraction; i++)
        {
            Console.WriteLine("");
        }

    }
}