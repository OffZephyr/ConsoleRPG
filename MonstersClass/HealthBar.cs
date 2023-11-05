using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class HealthBar : baseData
    {
        public HealthBar(Character character, bool direction)
        {
            switch (direction)
            {
                case false:
                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int i = 0; i < character.hp25; i++)
                    {
                        Console.Write("|");
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    for (int i = 0; i < 24 - character.hp25; i++)
                    {
                        Console.Write("|");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case true:
                    Console.ForegroundColor = ConsoleColor.Red;
                    for (int i = 0; i < 24 - character.hp25; i++)
                    {
                        Console.Write("|");
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int i = 0; i < character.hp25; i++)
                    {
                        Console.Write("|");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

        }
    }
}
