﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class RoomGen
    {
        public static int xSize;
        public static int ySize;
        public static int roomChange;

        public static int[,] tileData = new int[xSize, ySize];

        public static void generateRoom(int roomx, int roomy, Character player, Character enemy)
        {

            Console.Clear();
            RoomData.updateRoom(roomx, roomy);

            printRoom(player, enemy);
            for (int i = 0; i < Console.WindowHeight / 2 - ySize / 2 - 3; i++)
            {
                Console.WriteLine();
            }
            bottomBar.print();
        }

        static void printRoom(Character player, Character enemy)
        {
            for (int i = 0; i < Console.WindowHeight / 2 - ySize / 2 - 3; i++)
            {
                Console.WriteLine();
            }
            for (int i = 0; i < ySize; i++)
            {
                for (int j = 0; j < Console.WindowWidth / 2 - xSize; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < xSize; j++)
                {
                    switch (tileData[j, i])
                    {
                        case 0:
                            blacknwhite();
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkGray; // WALL
                            Console.Write("██");
                            break;
                        case 2:
                            blacknwhite(); // DOOR LEFT
                            break;
                        case 3:
                            blacknwhite(); // DOOR UP
                            break;
                        case 4:
                            blacknwhite(); // DOOR RIGHT
                            break;
                        case 5:
                            blacknwhite(); // DOOR DOWN
                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.Yellow; // Entrance DOOR
                            Console.Write("██");
                            break;
                        case 7:
                            if (baseData.defeatedEntities[baseData.currentRoomX, baseData.currentRoomY] != true) // ENEMY
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write("██");
                            }
                            else blacknwhite();
                            break;
                        case 8:
                            Console.ForegroundColor = (ConsoleColor)player.color; // PLAYER
                            Console.Write("██");
                            break;
                        case 9:
                            if (baseData.defeatedEntities[baseData.currentRoomX, baseData.currentRoomY] != true) // BOSS
                            {
                                Console.ForegroundColor = (ConsoleColor)enemy.color;
                                Console.Write("██");
                            }
                            else blacknwhite();
                            break;
                        case 10:
                            if (!baseData.artifactHealth)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkMagenta; // Health Artifact
                                Console.Write("██");
                            }
                            else blacknwhite();
                            break;
                        case 11:
                            if (!baseData.artifactFight)
                            {
                                Console.ForegroundColor = ConsoleColor.Red; // Fight Artifact
                                Console.Write("██");
                            }
                            else blacknwhite();
                            break;
                        case 12:
                            if (!baseData.artifactLuck)
                            {
                                Console.ForegroundColor = ConsoleColor.Green; // Luck Artifact
                                Console.Write("██");
                            }
                            else blacknwhite();
                            break;
                        case 13:
                            if (baseData.openDoorsList[baseData.currentRoomX, baseData.currentRoomY] != true) // KEY DOORS
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("██");
                            }
                            else blacknwhite();
                            break;
                        case 14:
                            if (baseData.keysList[baseData.currentRoomX, baseData.currentRoomY] != true) // KEY
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("██");
                            }
                            else blacknwhite();
                            break;
                    }
                    void blacknwhite()
                    {
                        if (i % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("█");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("█");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("█");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("█");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
