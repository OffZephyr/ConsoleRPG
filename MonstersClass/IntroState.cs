using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class IntroState : MainLoopState
    {
        public override void onUpdate()
        {
            Console.Clear();
            Console.Write("Would you like to watch the intro? [y/n] : ");
            input = Console.ReadKey().Key.ToString();
            switch (input)
            {
                case "Y":
                    new CutscenePlayer(CutsceneData.INTRO);
                    new MainMenuState();
                    break;
                case "N":
                    new MainMenuState();
                    break;
            }
        }
    }
}
