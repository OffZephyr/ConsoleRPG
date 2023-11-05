using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleRPG
{
    public class DungeonState : MainLoopState
    {
        static Random random = new Random();

        public static int playerX = 8;
        public static int playerY = 10;
        public static int roomChange;

        public override void onCreate()
        {
            Character.Update(player, enemy, false, true);
        }

        public override void onUpdate()
        {

            addRoom();
            Console.Clear();
            Console.WriteLine();
            spaces(25 / 2);
            new HealthBar(player, false);
            RoomGen.generateRoom(currentRoomX, currentRoomY);
            roomChange = 0;
            while (Console.KeyAvailable) Console.ReadKey(true);
            input = Console.ReadKey().Key.ToString();
            if (input == Controls["Move Down"])
            {
                if (RoomGen.tileData[playerX, playerY + 1] != 1)
                {
                    if (RoomGen.tileData[playerX, playerY + 1] != 13 || openDoorsList[currentRoomX, currentRoomY] || keys != 0)
                        playerY++;
                }
            }
            if (input == Controls["Move Up"])
            {
                if (RoomGen.tileData[playerX, playerY - 1] != 1)
                {
                    if (RoomGen.tileData[playerX, playerY - 1] != 13 || openDoorsList[currentRoomX, currentRoomY] || keys != 0)
                        playerY--;
                }
            }
            else if (input == Controls["Move Left"])
            {
                if (RoomGen.tileData[playerX - 1, playerY] != 1)
                {
                    if (RoomGen.tileData[playerX - 1, playerY] != 13 || openDoorsList[currentRoomX, currentRoomY] || keys != 0)
                        playerX--;
                }
            }
            else if (input == Controls["Move Right"])
            {
                if (RoomGen.tileData[playerX + 1, playerY] != 1)
                {
                    if (RoomGen.tileData[playerX + 1, playerY] != 13 || openDoorsList[currentRoomX, currentRoomY] || keys != 0)
                        playerX++;
                }
            }
            else if (input == Controls["Pause Game"])
            {
                new Pause();
            }
            else if(input == Controls["Open Map"])
            {
                new Map();
            }
            switch (RoomGen.tileData[playerX, playerY])
            {
                case 2:
                    roomChange = 1;
                    currentRoomX--;
                    break;
                case 3:
                    currentRoomY++;
                    roomChange = 2;
                    break;
                case 4:
                    currentRoomX++;
                    roomChange = 3;
                    break;
                case 5:
                    currentRoomY--;
                    roomChange = 4;
                    break;
                case 6:
                    if (defeatedEntities[7, 7] != true)
                    {
                        GameOverState.left = true;
                        new GameOverState();
                    }
                    else
                    {
                        new WinState();
                    }
                    break;
                case 7:
                    if (defeatedEntities[currentRoomX, currentRoomY] != true)
                    {
                        enemy.name = Character.smallEnemies[random.Next(0, Character.smallEnemies.Length)];
                        new FightState();
                    }
                    break;
                case 9:
                    if (defeatedEntities[currentRoomX, currentRoomY] != true)
                    {
                        new FightState();
                    }
                    break;
                case 10:
                    if (!artifactHealth) artifactHealth = true;
                    break;
                case 11:
                    if (!artifactFight) artifactFight = true;
                    break;
                case 12:
                    if (!artifactLuck) artifactLuck = true;
                    break;
                case 13:
                    if (!openDoorsList[currentRoomX, currentRoomY])
                    {
                        openDoorsList[currentRoomX, currentRoomY] = true;
                        keys--;
                    }
                    break;
                case 14:
                    if (keysList[currentRoomX, currentRoomY] != true)
                    {
                        keysList[currentRoomX, currentRoomY] = true;
                        keys++;
                    }
                    break;
            }
        }
        public static void playerDoorCheck(int Direction)
        {
            switch (Direction)
            {
                case 1:
                    playerX = RoomGen.xSize - 2;
                    playerY = RoomGen.ySize / 2;
                    Character.Update(player, enemy, false, true);
                    break;
                case 2:
                    playerY = RoomGen.ySize - 2;
                    playerX = RoomGen.xSize / 2;
                    Character.Update(player, enemy, false, true);
                    break;
                case 3:
                    playerX = 1;
                    playerY = RoomGen.ySize / 2;
                    Character.Update(player, enemy, false, true);
                    break;
                case 4:
                    playerY = 1;
                    playerX = RoomGen.xSize / 2;
                    Character.Update(player, enemy, false, true);
                    break;
            }
        }
        static void addRoom()
        {
            if (!visitedRooms.Contains((currentRoomX, currentRoomY))) visitedRooms.Add((currentRoomX, currentRoomY));
        }
    }
}
