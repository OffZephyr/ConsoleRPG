using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleRPG
{
    public class GameOverState : MainLoopState
    {
        string subText = "";
        string continueText = "[Press " + baseData.Controls["Accept"] + " to Continue]";
        public static bool left = false;
        public override void onCreate()
        {
            if(left)
            {
                subText = "You monster.";
            }
            else
            {
                subText = "Better luck next time!";
            }
        }
        public override void onUpdate()
        {
        Console.Clear();
            for (int i = 0; i < Console.WindowHeight / 2 - 6; i++)
            {
                Console.WriteLine();
            }
            spaces(30);
            Console.WriteLine(" .---.   .--.  .-.   .-..----.    .----. .-. .-..----..----. ");
            spaces(30);
            Console.WriteLine("/   __} / {} \\ |  `.'  || {_     /  {}  \\| | | || {_  | {}  }");
            spaces(30);
            Console.WriteLine("\\  {_ }/  /\\  \\| |\\ /| || {__    \\      /\\ \\_/ /| {__ | .-. \\");
            spaces(30);
            Console.WriteLine(" `---' `-'  `-'`-' ` `-'`----'    `----'  `---' `----'`-' `-'");
            Console.WriteLine();
            Console.WriteLine();

            spaces(subText.Length / 2);
            Console.WriteLine(subText);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            spaces(continueText.Length / 2);
            Console.WriteLine(continueText);
            while (Console.KeyAvailable) Console.ReadKey(true);
            input = Console.ReadKey().Key.ToString();
            if (input == Controls["Accept"])
            {
                Console.Clear();
                new RESET();
            }
        }
    }
}