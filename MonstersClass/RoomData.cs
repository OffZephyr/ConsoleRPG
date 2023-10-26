using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleRPG
{
    public class RoomData

    /*
    Before I get bullied for spreading everything into multiple arrays, please note that I am very much aware that it would've been way easier with a single array.
    I did this to make everything easier to use for people that did not write this code and have a tiny bit more trouble understanding it !

    - Zephyr
    */
    {
        public static int[,] roomDoors = new int[,] // ROOM DOORS { ROOM X , ROOM Y , LEFT DOOR SIZE , TOP DOOR SIZE , RIGHT DOOR SIZE , BOTTOM DOOR SIZE }
        {
        {1,1, 0, 3, 0, 0 },
        {1,2, 0, 0, 3, 3 },
        {2,2, 3, 4, 3, 0 },
        {2,3, 0, 4, 0, 4 },
        {2,4, 0, 0, 0, 3 },
        {2,5, 0, 0, 0, 1 },
        {3,2, 3, 0, 3, 0 },
        {4,2, 3, 0, 3, 0 },
        {5,2, 3, 9, 3, 0 },
        {6,2, 3, 0, 3, 0 },
        {7,2, 3, 0, 0, 3 },
        {7,1, 0, 3, 0, 0 },
        {5,3, 0, 15, 0, 9 },
        {5,4, 0, 0, 5, 15 },
        {6,4, 5, 3, 0, 0 },
        {6,5, 3, 3, 0, 3 },
        {6,6, 3, 0, 7, 3 },
        {5,6, 5, 0, 3, 1 },
        {7,6, 7, 9, 0, 5 },
        {7,7, 0, 0, 0, 9 },
        {5,5, 0, 1, 3, 0 },
        {4,6, 0, 0, 3, 0 },
        {7,5, 0, 5, 0, 3 },
        {7,4, 0, 3, 0, 0 }
    };

        public static int[,,] roomSizeData = new int[,,] // ROOM SIZE { { [ROOM X] , [ROOM Y] },{ [SIZE X] , [SIZE Y] }}
        {
        { { 1 , 1 }, { 5  , 21 } },
        { { 1 , 2 }, { 9  , 7  } },
        { { 2 , 2 }, { 12 , 19 } },
        { { 2 , 3 }, { 12 , 9  } },
        { { 2 , 4 }, { 9  , 9  } },
        { { 3 , 2 }, { 17 , 17 } },
        { { 4 , 2 }, { 32 , 7  } },
        { { 5 , 2 }, { 17 , 17 } },
        { { 6 , 2 }, { 32 , 7  } },
        { { 7 , 2 }, { 9  , 9  } },
        { { 7 , 1 }, { 5  , 21 } },

        { { 5 , 3 }, { 17 , 21 } },
        { { 5 , 4 }, { 17 , 21 } },
        { { 6 , 4 }, { 9  , 13 } },
        { { 6 , 5 }, { 7  , 21 } },
        { { 6 , 6 }, { 17 , 17 } },
        { { 5 , 6 }, { 17 , 15 } },
        { { 4 , 6 }, { 15 , 15 } },
        { { 7 , 6 }, { 19 , 19 } },
        { { 7 , 7 }, { 21 , 21 } },
        { { 5 , 5 }, { 7  , 17 } },
        { { 2 , 5 }, { 5  , 5  } },
        { { 7 , 5 }, { 7  , 7  } },
        { { 7 , 4 }, { 5  , 9  } }
        };

        public static int[,,] wallTileData = new int[,,] // WALL TILE { { [ROOM X] , [ROOM Y] },{ [TILE POS X] , [TILE POS Y] }}
        {
        { { 2 , 4 }, { 1 , 4 } },
        { { 2 , 4 }, { 2 , 4 } },
        { { 2 , 4 }, { 3 , 4 } },
        { { 2 , 4 }, { 5 , 4 } },
        { { 2 , 4 }, { 6 , 4 } },
        { { 2 , 4 }, { 7 , 4 } },

        { { 5 , 4 }, { 1 , 4 } },
        { { 5 , 4 }, { 2 , 4 } },
        { { 5 , 4 }, { 6 , 4 } },
        { { 5 , 4 }, { 7 , 4 } },
        { { 5 , 4 }, { 8 , 4 } },
        { { 5 , 4 }, { 9 , 4 } },
        { { 5 , 4 }, { 10 , 4 } },
        { { 5 , 4 }, { 11 , 4 } },
        { { 5 , 4 }, { 12 , 4 } },
        { { 5 , 4 }, { 13 , 4 } },
        { { 5 , 4 }, { 13 , 5 } },
        { { 5 , 4 }, { 13 , 6 } },
        { { 5 , 4 }, { 13 , 7 } },
        { { 5 , 4 }, { 13 , 8 } },
        { { 5 , 4 }, { 13 , 9 } },
        { { 5 , 4 }, { 13 , 10 } },
        { { 5 , 4 }, { 13 , 11 } },
        { { 5 , 4 }, { 13 , 12 } },
        { { 5 , 4 }, { 13 , 13 } },
        { { 5 , 4 }, { 13 , 14 } },
        { { 5 , 4 }, { 13 , 15 } },
        { { 5 , 4 }, { 13 , 16 } },
        { { 5 , 4 }, { 13 , 17 } },
        { { 5 , 4 }, { 14 , 17 } },
        { { 5 , 4 }, { 15 , 17 } },

        { { 5 , 6 }, { 13 , 1 } },
        { { 5 , 6 }, { 13 , 2 } },
        { { 5 , 6 }, { 13 , 3 } },
        { { 5 , 6 }, { 13 , 4 } },
        { { 5 , 6 }, { 13 , 5 } },
        { { 5 , 6 }, { 13 , 6 } },
        { { 5 , 6 }, { 13 , 7 } },
        { { 5 , 6 }, { 13 , 8 } },
        { { 5 , 6 }, { 13 , 9 } },
        { { 5 , 6 }, { 13 , 10 } },
        { { 5 , 6 }, { 13 , 11 } },
        { { 5 , 6 }, { 13 , 12 } },
        { { 5 , 6 }, { 13 , 13 } },
        { { 5 , 6 }, { 13 , 14 } },

        { { 7 , 6 }, { 1 , 2 } },
        { { 7 , 6 }, { 2 , 2 } },
        { { 7 , 6 }, { 3 , 2 } },
        { { 7 , 6 }, { 4 , 2 } },
        { { 7 , 6 }, { 14 , 2 } },
        { { 7 , 6 }, { 15 , 2 } },
        { { 7 , 6 }, { 16 , 2 } },
        { { 7 , 6 }, { 17 , 2 } },
        { { 7 , 6 }, { 18 , 2 } },

        { { 7 , 4 }, { 1 , 4 } },
        { { 7 , 4 }, { 3 , 4 } }

    };
        public static int[,,] enemyTileData = new int[,,] // ENEMY TILE { { [ROOM X] , [ROOM Y] },{ [TILE POS X] , [TILE POS Y] }}
        {
        { { 1 , 1 }, { 2 , 10 } },
        { { 1 , 2 }, { 3 , 5 } },
        { { 2 , 2 }, { 4 , 7 } },
        { { 2 , 3 }, { 2 , 5 } },
        { { 5 , 2 }, { 3 , 2 } },
        { { 7 , 2 }, { 2 , 4 } },
        { { 6 , 4 }, { 2 , 4 } },
        { { 6 , 6 }, { 13 , 12 } },
        { { 5 , 6 }, { 5 , 7 } }
        };
        public static int[,,] bossTileData = new int[,,] // BOSS BATTLE TILE { { [ROOM X] , [ROOM Y] },{ [TILE POS X] , [TILE POS Y] }}
        {
        { { 2 , 4 }, { 4 , 4 } },

        { { 5 , 4 }, { 3 , 3 } },
        { { 5 , 4 }, { 4 , 3 } },
        { { 5 , 4 }, { 5 , 3 } },
        { { 5 , 4 }, { 3 , 4 } },
        { { 5 , 4 }, { 4 , 4 } },
        { { 5 , 4 }, { 5 , 4 } },
        { { 5 , 4 }, { 3 , 5 } },
        { { 5 , 4 }, { 4 , 5 } },
        { { 5 , 4 }, { 5 , 5 } },

        { { 7 , 7 }, { 8 , 5 } },
        { { 7 , 7 }, { 9 , 5 } },
        { { 7 , 7 }, { 10 , 5 } },
        { { 7 , 7 }, { 11 , 5 } },
        { { 7 , 7 }, { 12 , 5 } },
        { { 7 , 7 }, { 8 , 6 } },
        { { 7 , 7 }, { 9 , 6 } },
        { { 7 , 7 }, { 10 , 6 } },
        { { 7 , 7 }, { 11 , 6 } },
        { { 7 , 7 }, { 12 , 6 } },
        { { 7 , 7 }, { 8 , 7 } },
        { { 7 , 7 }, { 9 , 7 } },
        { { 7 , 7 }, { 10 , 7 } },
        { { 7 , 7 }, { 11 , 7 } },
        { { 7 , 7 }, { 12 , 7 } },
        { { 7 , 7 }, { 8 , 8 } },
        { { 7 , 7 }, { 9 , 8 } },
        { { 7 , 7 }, { 10 , 8 } },
        { { 7 , 7 }, { 11 , 8 } },
        { { 7 , 7 }, { 12 , 8 } },
        { { 7 , 7 }, { 8 , 9 } },
        { { 7 , 7 }, { 9 , 9 } },
        { { 7 , 7 }, { 10 , 9 } },
        { { 7 , 7 }, { 11 , 9 } },
        { { 7 , 7 }, { 12 , 9 } },

        { { 7 , 4 }, { 2 , 4 } }
        };
        public static int[,,] keyTileData = new int[,,] // KEY TILE { { [ROOM X] , [ROOM Y] },{ [TILE POS X] , [TILE POS Y] }}
        {
        { { 1 , 1 }, { 2 , 18 } },
        { { 2 , 5 }, { 2 , 2 } },
        { { 7 , 4 }, { 2 , 7 } }
        };
        public static int[,,] keyDoorTileData = new int[,,] // DOOR LOCK TILE { { [ROOM X] , [ROOM Y] },{ [TILE POS X] , [TILE POS Y] }}
        {
        { { 4 , 2 }, { 15 , 1 } },
        { { 4 , 2 }, { 15 , 2 } },
        { { 4 , 2 }, { 15 , 3 } },
        { { 4 , 2 }, { 15 , 4 } },
        { { 4 , 2 }, { 15 , 5 } },

        { { 7 , 6 }, { 5 , 2 } },
        { { 7 , 6 }, { 6 , 2 } },
        { { 7 , 6 }, { 7 , 2 } },
        { { 7 , 6 }, { 8 , 2 } },
        { { 7 , 6 }, { 9 , 2 } },
        { { 7 , 6 }, { 10 , 2 } },
        { { 7 , 6 }, { 11 , 2 } },
        { { 7 , 6 }, { 12 , 2 } },
        { { 7 , 6 }, { 13 , 2 } },

        { { 5 , 5 }, { 1 , 4 } },
        { { 5 , 5 }, { 2 , 4 } },
        { { 5 , 5 }, { 3 , 4 } },
        { { 5 , 5 }, { 4 , 4 } },
        { { 5 , 5 }, { 5 , 4 } },
        };
        public static int[,] extraTiles = new int[,] // OTHER TILES { [ROOM X] , [ROOM Y] , [TILE POS X] , [TILE POS Y] , TILE TYPE }
        {
        {2, 4, 4, 2, 10},
        {7, 1, 2, 18, 11},
        {4, 6, 7, 7, 12},

        {3, 2, 5, 16, 6},
        {3, 2, 6, 16, 6},
        {3, 2, 7, 16, 6},
        {3, 2, 8, 16, 6},
        {3, 2, 9, 16, 6},
        {3, 2, 10, 16, 6},
        {3, 2, 11, 16, 6}
        };


        public static void updateRoom(int roomx, int roomy)
        {
            for (int i = 0; i < roomSizeData.GetLength(0); i++)
            {
                if (roomSizeData[i, 0, 0] == roomx && roomSizeData[i, 0, 1] == roomy)
                {
                    RoomGen.xSize = roomSizeData[i, 1, 0];
                    RoomGen.ySize = roomSizeData[i, 1, 1];
                }
            }
            PlayerMove.playerDoorCheck(PlayerMove.roomChange);

            RoomGen.tileData = new int[RoomGen.xSize, RoomGen.ySize];
            updateInfo(roomx, roomy);

            void updateInfo(int roomx, int roomy)
            {
                for (int j = 0; j < RoomGen.xSize; j++)
                {
                    for (int k = 0; k < RoomGen.ySize; k++)
                    {
                        RoomGen.tileData[j, k] = 0;
                    }
                }


                for (int j = 0; j < RoomGen.xSize; j++)
                {
                    RoomGen.tileData[j, 0] = 1;
                    RoomGen.tileData[j, RoomGen.ySize - 1] = 1;
                }
                for (int j = 0; j < RoomGen.ySize; j++)
                {
                    RoomGen.tileData[0, j] = 1;
                    RoomGen.tileData[RoomGen.xSize - 1, j] = 1;
                }

                for (int j = 0; j < extraTiles.GetLength(0); j++)
                {
                    saveTilesSingle(j, extraTiles);
                }
                saveTiles(1, wallTileData);
                saveTiles(7, enemyTileData);
                saveTiles(9, bossTileData);
                saveTiles(13, keyDoorTileData);
                saveTiles(14, keyTileData);

                for (int i = 0; i < roomDoors.GetLength(0); i++)
                {
                    if (roomDoors[i, 0] == roomx && roomDoors[i, 1] == roomy)
                    {
                        door(0, roomDoors[i, 2]);
                        door(1, roomDoors[i, 3]);
                        door(2, roomDoors[i, 4]);
                        door(3, roomDoors[i, 5]);
                    }
                }

                if (baseData.currentRoomX == 2 && baseData.currentRoomY == 4 && baseData.artifactFight == true)
                {
                    door(1, 1);
                }

                if (baseData.currentRoomX == 7 && baseData.currentRoomY == 7 && baseData.defeatedEntities[7, 7] == true)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        RoomGen.tileData[i + 6, 0] = 6;
                    }
                }

                RoomGen.tileData[PlayerMove.playerX, PlayerMove.playerY] = 8;
            }
            void saveTiles(int type, int[,,] tyleType)
            {
                for (int i = 0; i < tyleType.GetLength(0); i++)
                {
                    if (tyleType[i, 0, 0] == roomx && tyleType[i, 0, 1] == roomy)
                    {
                        RoomGen.tileData[tyleType[i, 1, 0], tyleType[i, 1, 1]] = type;
                    }
                }
            }

            void saveTilesSingle(int i, int[,] tileType)
            {
                if (tileType[i, 0] == roomx && tileType[i, 1] == roomy)
                {
                    RoomGen.tileData[tileType[i, 2], tileType[i, 3]] = tileType[i, 4];
                }
            }

            void door(int direction, int length)
            {
                int posy = RoomGen.ySize / 2 - length / 2;
                int posx = RoomGen.xSize / 2 - length / 2;
                switch (direction)
                {
                    case 0:
                        for (int i = 0; i < length; i++)
                        {
                            RoomGen.tileData[0, posy] = 2;
                            posy++;
                        }
                        break;
                    case 1:
                        for (int i = 0; i < length; i++)
                        {
                            RoomGen.tileData[posx, 0] = 3;
                            posx++;
                        }
                        break;
                    case 2:
                        for (int i = 0; i < length; i++)
                        {
                            RoomGen.tileData[RoomGen.xSize - 1, posy] = 4;
                            posy++;
                        }
                        break;
                    case 3:
                        for (int i = 0; i < length; i++)
                        {
                            RoomGen.tileData[posx, RoomGen.ySize - 1] = 5;
                            posx++;
                        }
                        break;
                }
            }
        }
    }
}
