using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleRPG
{
    public class PlayerMove
    {
        static Random random = new Random();
        public static Character player = new Character();
        public static Character enemy = new Character();

        static bool movement = false;
        public static int playerX = 8;
        public static int playerY = 10;
        static string input;
        public static int roomChange;

        public static void canMove(bool canMove)
        {
            Character.Update(player, enemy);
            movement = canMove;
            while (movement)
            {

                addRoom();
                RoomGen.generateRoom(baseData.currentRoomX, baseData.currentRoomY, player, enemy);
                roomChange = 0;
                while (Console.KeyAvailable) Console.ReadKey(true);
                input = Console.ReadKey().Key.ToString();
                if (input == baseData.Controls["Move Down"])
                {
                    if (RoomGen.tileData[playerX, playerY + 1] != 1)
                    {
                        if (RoomGen.tileData[playerX, playerY + 1] != 13 || baseData.keys != 0)
                            playerY++;
                    }
                }
                if (input == baseData.Controls["Move Up"])
                {
                    if (RoomGen.tileData[playerX, playerY - 1] != 1)
                    {
                        if (RoomGen.tileData[playerX, playerY - 1] != 13 || baseData.keys != 0)
                            playerY--;
                    }
                }
                if (input == baseData.Controls["Move Left"])
                {
                    if (RoomGen.tileData[playerX - 1, playerY] != 1)
                    {
                        if (RoomGen.tileData[playerX - 1, playerY] != 13 || baseData.keys != 0)
                            playerX--;
                    }
                }
                if (input == baseData.Controls["Move Right"])
                {
                    if (RoomGen.tileData[playerX + 1, playerY] != 1)
                    {
                        if (RoomGen.tileData[playerX + 1, playerY] != 13 || baseData.keys != 0)
                            playerX++;
                    }
                }
                if (input == baseData.Controls["Pause Game"])
                {
                    new Pause();
                }
                if(input == baseData.Controls["Open Map"])
                {
                    new Map();
                }
                switch (RoomGen.tileData[playerX, playerY])
                {
                    case 2:
                        roomChange = 1;
                        baseData.currentRoomX--;
                        break;
                    case 3:
                        baseData.currentRoomY++;
                        roomChange = 2;
                        break;
                    case 4:
                        baseData.currentRoomX++;
                        roomChange = 3;
                        break;
                    case 5:
                        baseData.currentRoomY--;
                        roomChange = 4;
                        break;
                    case 6:
                        if (baseData.defeatedEntities[7, 7] != true)
                            gameOver.print(true);
                        else
                        {
                            winScreen.print(baseData.artifactHealth && baseData.artifactLuck && baseData.artifactFight);
                        }
                        break;
                    case 7:
                        if (baseData.defeatedEntities[baseData.currentRoomX, baseData.currentRoomY] != true)
                        {
                            enemy.name = Character.smallEnemies[random.Next(0, Character.smallEnemies.Length)];
                            Fighting.Fight(player, enemy);
                        }
                        break;
                    case 9:
                        if (baseData.defeatedEntities[baseData.currentRoomX, baseData.currentRoomY] != true)
                        {
                            Fighting.Fight(player, enemy);
                        }
                        break;
                    case 10:
                        if (!baseData.artifactHealth) baseData.artifactHealth = true;
                        break;
                    case 11:
                        if (!baseData.artifactFight) baseData.artifactFight = true;
                        break;
                    case 12:
                        if (!baseData.artifactLuck) baseData.artifactLuck = true;
                        break;
                    case 13:
                        if (!baseData.openDoorsList[baseData.currentRoomX, baseData.currentRoomY])
                        {
                            baseData.openDoorsList[baseData.currentRoomX, baseData.currentRoomY] = true;
                            baseData.keys--;
                        }
                        break;
                    case 14:
                        if (baseData.keysList[baseData.currentRoomX, baseData.currentRoomY] != true)
                        {
                            baseData.keysList[baseData.currentRoomX, baseData.currentRoomY] = true;
                            baseData.keys++;
                        }
                        break;
                }
            }
        }
        public static void playerDoorCheck(int Direction)
        {
            switch (Direction)
            {
                case 1:
                    PlayerMove.playerX = RoomGen.xSize - 2;
                    PlayerMove.playerY = RoomGen.ySize / 2;
                    Character.Update(PlayerMove.player, PlayerMove.enemy);
                    break;
                case 2:
                    PlayerMove.playerY = RoomGen.ySize - 2;
                    PlayerMove.playerX = RoomGen.xSize / 2;
                    Character.Update(PlayerMove.player, PlayerMove.enemy);
                    break;
                case 3:
                    PlayerMove.playerX = 1;
                    PlayerMove.playerY = RoomGen.ySize / 2;
                    Character.Update(PlayerMove.player, PlayerMove.enemy);
                    break;
                case 4:
                    PlayerMove.playerY = 1;
                    PlayerMove.playerX = RoomGen.xSize / 2;
                    Character.Update(PlayerMove.player, PlayerMove.enemy);
                    break;
            }
        }
        static void addRoom()
        {
            if (!baseData.visitedRooms.Contains((baseData.currentRoomX, baseData.currentRoomY))) baseData.visitedRooms.Add((baseData.currentRoomX, baseData.currentRoomY));
        }
    }
}
