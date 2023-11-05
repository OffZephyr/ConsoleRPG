using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class MainLoopState : baseData
    {
        public static bool Update;
        public MainLoopState()
        {
            while (true)
            {
                Update = true;
                onCreate();
                while (Update)
                {
                    onUpdate();
                }
            }
        }
    }
}
