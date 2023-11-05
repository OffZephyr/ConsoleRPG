using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleRPG
{
    public class FightTitleState
    {
        static int i2 = 0;
        public FightTitleState()
        {
            Console.Clear();
            emptySpace(Console.WindowHeight / 18);
            titleCard();
            emptySpace(Console.WindowHeight - Console.WindowHeight / 18 - 24);
            Characters();
            Thread.Sleep(5000);
            Console.Clear();
        }
            static void Characters()
            {
                for (int i = 0; i < 18; i++)
                {

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(DrawCharacters.playerCharacter[i]);
                    for (int j = 0; j < Console.WindowWidth / 2 - 2 - DrawCharacters.playerWidth; j++)
                    {
                        Console.Write(" ");
                    }
                    printLightning();
                    for (int j = 0; j < Console.WindowWidth / 2 - 2 - DrawCharacters.enemyWidth; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(DrawCharacters.enemyCharacter[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            static void emptySpace(int Lines)
            {
                for (int i = 0; i < Lines; i++)
                {
                    for (int j = 0; j < Console.WindowWidth / 2 - 2; j++)
                    {
                        Console.Write(" ");
                    }
                    printLightning();
                    Console.WriteLine();
                }
            }

            static void printLightning()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                switch (i2)
                {
                    case 0:
                        Console.Write("\\\\ ");
                        break;
                    case 1:
                        Console.Write(" \\\\");
                        break;
                    case 2:
                        Console.Write(" //");
                        break;
                    case 3:
                        Console.Write("// ");
                        break;
                }
                i2++;
                while (i2 > 3) { i2 = i2 - 4; };
            }
            static void titleCard()
            {

                for (int j = 0; j < 5; j++)
                {
                    for (int i = 0; i < Console.WindowWidth / 4 - DrawCharacters.playerTitleWidth / 2 - 1; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(DrawCharacters.playerTitle[j]);
                    for (int i = 0; i < Console.WindowWidth / 4 - DrawCharacters.playerTitleWidth / 2 - 1; i++)
                    {
                        Console.Write(" ");
                    }
                    printLightning();
                    for (int i = 0; i < Console.WindowWidth / 4 - DrawCharacters.enemyTitleWidth / 2 - 1; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(DrawCharacters.enemyTitle[j]);
                    for (int i = 0; i < Console.WindowWidth / 4 - DrawCharacters.enemyTitleWidth / 2 - 1; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

    }
}