using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class WinState : MainLoopState
    {
        string subTitle = "";
        string endingText = "";
        string continueText = "[Press " + baseData.Controls["Accept"] + " to Continue]";
        public override void onCreate()
        {
            if (artifactHealth && artifactFight && artifactLuck)
            {
                subTitle = "You saved the day and banished the BEAST !";
                endingText = "Good Ending!";
                new CutscenePlayer(CutsceneData.PERFECTEND);
            }
            else
            {
                subTitle = "You saved the day, but not forever...";
                endingText = "Bad Ending";
                new CutscenePlayer(CutsceneData.BADEND);
            }
        }
        public override void onUpdate()
        {
            Console.Clear();
            for (int i = 0; i < Console.WindowHeight / 2 - 6; i++)
            {
                Console.WriteLine();
            }

            spaces(29);
            Console.WriteLine(",--.   ,--.,-----. ,--. ,--.    ,--.   ,--.,--.,--.  ,--. ");
            spaces(29);
            Console.WriteLine(" \\  `.'  /'  .-.  '|  | |  |    |  |   |  ||  ||  ,'.|  | ");
            spaces(29);
            Console.WriteLine("  '.    / |  | |  ||  | |  |    |  |.'.|  ||  ||  |' '  | ");
            spaces(29);
            Console.WriteLine("    |  |  '  '-'  ''  '-'  '    |   ,'.   ||  ||  | `   | ");
            spaces(29);
            Console.WriteLine("    `--'   `-----'  `-----'     '--'   '--'`--'`--'  `--' ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            spaces(subTitle.Length / 2);
            Console.WriteLine(subTitle);
            Console.WriteLine();
            spaces(endingText.Length / 2);
            Console.WriteLine(endingText);

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