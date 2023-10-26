using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class winScreen
    {
        public static void print(bool perfect)
        {
            PlayerMove.canMove(false);
            Console.Clear();
            for (int i = 0; i < Console.WindowHeight / 2 - 6; i++)
            {
                Console.WriteLine();
            }
            Spaces();
            Console.WriteLine(",--.   ,--.,-----. ,--. ,--.    ,--.   ,--.,--.,--.  ,--. ");
            Spaces();
            Console.WriteLine(" \\  `.'  /'  .-.  '|  | |  |    |  |   |  ||  ||  ,'.|  | ");
            Spaces();
            Console.WriteLine("  '.    / |  | |  ||  | |  |    |  |.'.|  ||  ||  |' '  | ");
            Spaces();
            Console.WriteLine("    |  |  '  '-'  ''  '-'  '    |   ,'.   ||  ||  | `   | ");
            Spaces();
            Console.WriteLine("    `--'   `-----'  `-----'     '--'   '--'`--'`--'  `--' ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            if (perfect)
            {
                for (int i = 0; i < Console.WindowWidth / 2 - 23; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("You have saved the day and found everything ! ");
            }
            else
            {
                for (int i = 0; i < Console.WindowWidth / 2 - 19; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("You haven't found everything though...");
            }
            Thread.Sleep(5000);
            Console.Clear();
            new RESET();
        }
        static void Spaces()
        {
            for (int i = 0; i < Console.WindowWidth / 2 - 29; i++)
            {
                Console.Write(" ");
            }
        }
    }
}