using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class RESET
    {
        public RESET()
        {
            baseData.currentRoomX = 3;
            baseData.currentRoomY = 2;
            baseData.playerLevel = 1;
            baseData.playerXP = 1;
            baseData.artifactHealth = false;
            baseData.artifactFight = false;
            baseData.artifactLuck = false;
            baseData.keysList = new bool[10, 10];
            baseData.openDoorsList = new bool[10, 10];
            baseData.defeatedEntities = new bool[10, 10];
            baseData.keys = 0;

            PlayerMove.playerX = 8;
            PlayerMove.playerY = 10;



        MainMenu.Start();
        }
    }
}
