using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleRPG
{
    public class gameOver
    {
        public static void print(bool left)
        {
            PlayerMove.canMove(false);
            Console.Clear();
            for (int i = 0; i < Console.WindowHeight / 2 - 6; i++)
            {
                Console.WriteLine();
            }
            Spaces();
            Console.WriteLine(" .---.   .--.  .-.   .-..----.    .----. .-. .-..----..----. ");
            Spaces();
            Console.WriteLine("/   __} / {} \\ |  `.'  || {_     /  {}  \\| | | || {_  | {}  }");
            Spaces();
            Console.WriteLine("\\  {_ }/  /\\  \\| |\\ /| || {__    \\      /\\ \\_/ /| {__ | .-. \\");
            Spaces();
            Console.WriteLine(" `---' `-'  `-'`-' ` `-'`----'    `----'  `---' `----'`-' `-'");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            if (left)
            {
                for (int i = 0; i < Console.WindowWidth / 2 - 13; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("You decided to give up... ");
            }
            else
            {
                for (int i = 0; i < Console.WindowWidth / 2 - 12; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("Better luck next time...");
            }
            Thread.Sleep(5000);
            Console.Clear();
            new RESET();
        }
        static void Spaces()
        {
            for (int i = 0; i < Console.WindowWidth / 2 - 30; i++)
            {
                Console.Write(" ");
            }
        }
    }
}