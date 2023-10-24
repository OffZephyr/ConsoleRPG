using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class RoomData
{
    public static void updateRoom(int roomx, int roomy)
    {
        switch (roomx, roomy)
        {
            case (1, 1):
                RoomGen.xSize = 5;
                RoomGen.ySize = 21;
                break;
            case (1, 2):
                RoomGen.xSize = 9;
                RoomGen.ySize = 7;
                break;
            case (2, 2):
                RoomGen.xSize = 12;
                RoomGen.ySize = 19;
                break;
            case (2, 3):
                RoomGen.xSize = 12;
                RoomGen.ySize = 9;
                break;
            case (2, 4):
                RoomGen.xSize = 9;
                RoomGen.ySize = 9;
                break;
            case (3, 2):
                RoomGen.xSize = 17;
                RoomGen.ySize = 17;
                break;
            case (4, 2):
                RoomGen.xSize = 32;
                RoomGen.ySize = 7;
                break;
            case (5, 2):
                RoomGen.xSize = 17;
                RoomGen.ySize = 17;
                break;
            case (6, 2):
                RoomGen.xSize = 32;
                RoomGen.ySize = 7;
                break;
            case (7, 2):
                RoomGen.xSize = 9;
                RoomGen.ySize = 9;
                break;
            case (7, 1):
                RoomGen.xSize = 5;
                RoomGen.ySize = 21;
                break;
            case (5, 3):
                RoomGen.xSize = 17;
                RoomGen.ySize = 21;
                break;
            case (5, 4):
                RoomGen.xSize = 17;
                RoomGen.ySize = 21;
                break;
            case (6, 4):
                RoomGen.xSize = 9;
                RoomGen.ySize = 13;
                break;
            case (6, 5):
                RoomGen.xSize = 7;
                RoomGen.ySize = 21;
                break;
            case (6, 6):
                RoomGen.xSize = 17;
                RoomGen.ySize = 17;
                break;
            case (5, 6):
                RoomGen.xSize = 17;
                RoomGen.ySize = 15;
                break;
            case (4, 6):
                RoomGen.xSize = 15;
                RoomGen.ySize = 15;
                break;
            case (7, 6):
                RoomGen.xSize = 19;
                RoomGen.ySize = 19;
                break;
            case (7, 7):
                RoomGen.xSize = 21;
                RoomGen.ySize = 21;
                break;
            case (5, 5):
                RoomGen.xSize = 7;
                RoomGen.ySize = 21;
                break;
            case (2, 5):
                RoomGen.xSize = 5;
                RoomGen.ySize = 5;
                break;
            case (7, 5):
                RoomGen.xSize = 7;
                RoomGen.ySize = 21;
                break;
            case (7, 4):
                RoomGen.xSize = 5;
                RoomGen.ySize = 13;
                break;
        }
        RoomGen.tileData = new int[RoomGen.xSize, RoomGen.ySize];
        switch (RoomGen.roomChange)
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

            switch (roomx, roomy)
            {
                case (1, 1):
                    door(1, 3);
                    if (RoomGen.defeatedEntities[1, 1] == false)
                    {
                        RoomGen.tileData[2, 10] = 7;
                    }
                    if (baseData.keysList[1, 1] == true) RoomGen.tileData[2, 18] = 0;
                    else RoomGen.tileData[2, 18] = 14;

                    break;
                case (1, 2):
                    door(2, 3);
                    door(3, 3);
                    if (RoomGen.defeatedEntities[1, 2] == false)
                    {
                        RoomGen.tileData[3, 5] = 7;
                    }
                    break;
                case (2, 2):
                    door(0, 3);
                    door(1, 4);
                    door(2, 3);
                    if (RoomGen.defeatedEntities[2, 2] == false)
                    {
                        RoomGen.tileData[4, 7] = 7;
                    }
                    break;
                case (2, 3):
                    door(1, 4);
                    door(3, 4);
                    if (RoomGen.defeatedEntities[2, 3] == false)
                    {
                        RoomGen.tileData[2, 5] = 7;
                    }
                    break;
                case (2, 4):
                    door(3, 3);
                    RoomGen.tileData[1, 4] = 1;
                    RoomGen.tileData[2, 4] = 1;
                    RoomGen.tileData[3, 4] = 1;
                    RoomGen.tileData[5, 4] = 1;
                    RoomGen.tileData[6, 4] = 1;
                    RoomGen.tileData[7, 4] = 1;
                    if (RoomGen.defeatedEntities[2, 4] == false)
                    {
                        RoomGen.tileData[4, 4] = 9;
                    }
                    if (baseData.artifactHealth == false)
                    {
                        RoomGen.tileData[4, 2] = 10;
                    }
                    if (baseData.artifactFight == true)
                    {
                        door(1, 1);
                    }
                    break;
                case (2, 5):
                    door(3, 1);
                    if (baseData.keysList[2, 5] == true) RoomGen.tileData[2, 2] = 0;
                    else RoomGen.tileData[2, 2] = 14;
                    break;
                case (3, 2):
                    door(0, 3);
                    door(2, 3);
                    for (int i = 6; i < 11; i++)
                    {
                        RoomGen.tileData[i, RoomGen.ySize - 1] = 6;
                    }
                    break;
                case (4, 2):
                    door(0, 3);
                    door(2, 3);
                    if (RoomGen.defeatedEntities[4, 2] == false)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            RoomGen.tileData[15, i+1] = 13;
                        }
                    }
                    break;
                case (5, 2):
                    door(0, 3);
                    door(1, 9);
                    door(2, 3);
                    if (RoomGen.defeatedEntities[5, 2] == false)
                    {
                        RoomGen.tileData[3, 2] = 7;
                    }
                    break;
                case (6, 2):
                    door(0, 3);
                    door(2, 3);
                    break;
                case (7, 2):
                    door(0, 3);
                    door(3, 3);
                    if (RoomGen.defeatedEntities[7, 2] == false)
                    {
                        RoomGen.tileData[2, 4] = 7;
                    }
                    break;
                case (7, 1):
                    door(1, 3);
                    if (baseData.artifactFight == false)
                    {
                        RoomGen.tileData[2, 18] = 11;
                    }
                    break;
                case (5, 3):
                    door(1, 15);
                    door(3, 9);
                    break;
                case (5, 4):
                    door(2, 5);
                    door(3, 15);
                    RoomGen.tileData[1, 4] = 1;
                    RoomGen.tileData[2, 4] = 1;
                    for (int i = 6; i < 14; i++) 
                    {
                        RoomGen.tileData[i, 4] = 1;
                    }
                    for (int i = 4; i < 18; i++)
                    {
                        RoomGen.tileData[13, i] = 1;
                    }
                    RoomGen.tileData[14, 17] = 1;
                    RoomGen.tileData[15, 17] = 1;
                    if (RoomGen.defeatedEntities[5, 4] == false)
                    {
                        RoomGen.tileData[3, 3] = 9;
                        RoomGen.tileData[4, 3] = 9;
                        RoomGen.tileData[5, 3] = 9;
                        RoomGen.tileData[3, 4] = 9;
                        RoomGen.tileData[4, 4] = 9;
                        RoomGen.tileData[5, 4] = 9;
                        RoomGen.tileData[3, 5] = 9;
                        RoomGen.tileData[4, 5] = 9;
                        RoomGen.tileData[5, 5] = 9;
                    }
                    break;
                case (6, 4):
                    door(0, 5);
                    door(1, 3);
                    if (RoomGen.defeatedEntities[6, 4] == false)
                    {
                        RoomGen.tileData[2, 4] = 7;
                    }
                    break;
                case (6, 5):
                    door(0, 3);
                    door(1, 3);
                    door(3, 3);
                    break;
                case (6, 6):
                    door(0, 3);
                    door(2, 7);
                    door(3, 3);
                    if (RoomGen.defeatedEntities[6, 6] == false)
                    {
                        RoomGen.tileData[13, 12] = 7;
                    }
                    break;
                case (5, 6):
                    door(0, 5);
                    door(2, 3);
                    door(3, 3);
                    if (RoomGen.defeatedEntities[5, 6] == false)
                    {
                        RoomGen.tileData[5, 7] = 7;
                    }
                    for(int i = 0;i<RoomGen.ySize - 1;i++)
                    {
                        RoomGen.tileData[RoomGen.ySize - 3, i] = 1;
                    }
                    break;
                case (7, 6):
                    door(0, 7);
                    door(1, 9);
                    for (int i = 0; i < 5; i++)
                    {
                        RoomGen.tileData[i, 2] = 1;
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        RoomGen.tileData[i + 14, 2] = 1;
                    }
                    if (RoomGen.defeatedEntities[7, 6] == false)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            RoomGen.tileData[i + 5, 2] = 13;
                        }
                    }
                    door(3, 5);
                    break;
                case (7, 7):
                    door(3, 9);
                    if (RoomGen.defeatedEntities[7, 7] == false)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            for(int j = 0; j < 5; j++)
                            {
                                RoomGen.tileData[i + 8, j + 5] = 9;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 9; i++)
                        {
                                RoomGen.tileData[i + 6, 0] = 6;
                        }
                    }
                    break;
                case (5, 5):
                    door(1, 3);
                    door(2, 3);
                    if (RoomGen.defeatedEntities[5, 5] == false)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            RoomGen.tileData[i + 1 , 4] = 13;
                        }
                    }
                    break;
                case (4, 6):
                    door(2, 5);
                    if (baseData.artifactLuck == false)
                    {
                        RoomGen.tileData[7, 7] = 12;
                    }
                    break;
                case (7, 5):
                    door(1, 5);
                    door(3, 3);
                    break;
                case (7, 4):
                    door(1, 3);
                    RoomGen.tileData[1, 4] = 1;
                    RoomGen.tileData[3, 4] = 1;
                    if (RoomGen.defeatedEntities[7, 4] == false)
                    {
                        RoomGen.tileData[2, 4] = 9;
                    }
                    if (baseData.keysList[7, 4] == true) RoomGen.tileData[2, 7] = 0;
                    else RoomGen.tileData[2, 7] = 14;
                    break;
            }
            RoomGen.tileData[PlayerMove.playerX, PlayerMove.playerY] = 8;
        }
        void door(int direction, int length)
        {
            int posy = RoomGen.ySize / 2 - length / 2;
            int posx = RoomGen.xSize / 2 - length / 2;
            switch (direction)
            {
                case 0:
                    for(int i = 0; i < length; i++)
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
