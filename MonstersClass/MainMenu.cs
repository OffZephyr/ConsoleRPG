using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace ConsoleRPG
{
    public class MainMenu
    {

        public static bool mainTitle = false;
        static int menu = 0;
        static int menuOption = 0;
        static string input;

        //ConsoleKey.Escape
        public static
        void Refresh()
        {
            Console.Clear();
            //Console.Write(menu + " " + menuOption); -- DEBUG
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
                    new Controls();
                    menu = 2;
                    break;
                case 5:
                    new Tutorial();
                    menu = 2;
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
            spaces(55);
            Console.WriteLine("_________                            .__           ________                          __    ________  ____  ___");
            spaces(55);
            Console.WriteLine("\\_   ___ \\  ____   ____   __________ |  |   ____   \\_____  \\  __ __   ____   _______/  |_  \\______ \\ \\   \\/  /");
            spaces(55);
            Console.WriteLine("/    \\  \\/ /  _ \\ /    \\ /  ___/  _ \\|  | _/ __ \\   /  / \\  \\|  |  \\_/ __ \\ /  ___/\\   __\\  |    |  \\ \\     / ");
            spaces(55);
            Console.WriteLine("\\     \\___(  <_> )   |  \\\\___ (  <_> )  |_\\  ___/  /   \\_/.  \\  |  /\\  ___/ \\___ \\  |  |    |    `   \\/     \\ ");
            spaces(55);
            Console.WriteLine(" \\______  /\\____/|___|  /____  >____/|____/\\___  > \\_____\\ \\_/____/  \\___  >____  > |__|   /_______  /___/\\  \\");
            spaces(55);
            Console.WriteLine("        \\/            \\/     \\/                \\/         \\__>           \\/     \\/                 \\/      \\_/");
            string subtitle = "A SUPER MEGA EPIC AND CRAZY ADVENTURE INTO THE CENTER OF THE WINDOWS CONSOLE™ !";
            Console.WriteLine();
            spaces(subtitle.Length/2);
            Console.WriteLine(subtitle);

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
                        if (menuOption == i) Console.Write("> ");
                        Console.Write(creditName);

                    }
                    break;
            }


            verticalSpaces(12);
            Console.WriteLine();
            if (menu > 0) input = Console.ReadKey().Key.ToString();
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
                                PlayerMove.canMove(true);
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
}