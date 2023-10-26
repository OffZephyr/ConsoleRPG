using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleRPG
{
    public class baseData
    {
        public static int currentRoomX = 3;
        public static int currentRoomY = 2;

        public static int playerLevel = 1;
        public static int playerXP = 0;

        public static bool artifactHealth = false;
        public static bool artifactFight = false;
        public static bool artifactLuck = false;
        public static bool[,] keysList = new bool[10, 10];
        public static bool[,] openDoorsList = new bool[10, 10];
        public static bool[,] defeatedEntities = new bool[10, 10];
        public static List<(int, int)> visitedRooms = new List<(int, int)>();

        public static int keys = 0;

        public static Dictionary<string, string> Controls = new Dictionary<string, string>()
    {
        {"Move Left", "LeftArrow"},
        {"Move Right", "RightArrow"},
        {"Move Up", "UpArrow"},
        {"Move Down", "DownArrow"},
        {"Action 1", "NumPad1"},
        {"Action 2", "NumPad2"},
        {"Action 3", "NumPad3"},
        {"Open Map", "E"},
        {"Pause Game", "Spacebar"},
        {"Accept", "Enter"},
        {"Return", "Backspace"},
    };
        public static void controlsReset()
        {
            Controls["Move Left"] = "LeftArrow";
            Controls["Move Right"] = "RightArrow";
            Controls["Move Up"] = "UpArrow";
            Controls["Move Down"] = "DownArrow";
            Controls["Action 1"] = "NumPad1";
            Controls["Action 2"] = "NumPad2";
            Controls["Action 3"] = "NumPad3";
            Controls["Open Map"] = "E";
            Controls["Pause Game"] = "Spacebar";
            Controls["Accept"] = "Enter";
            Controls["Return"] = "Backspace";
        }

        public static Dictionary<string, string> Credits = new Dictionary<string, string>()
    {
        {"Zephyr", "https://zephyr1.carrd.co/"},
        {"vulca ", "https://www.youtube.com/watch?v=dQw4w9WgXcQ"},
        {"Firefoxy [Aide Additionnelle]", "https://twitter.com/FirefoxyLeGibus"}
    };

    }
}
