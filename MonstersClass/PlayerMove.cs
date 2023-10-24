using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PlayerMove
{
    static Random random = new Random();
    public static Character player = new Character();
    public static Character enemy = new Character();

    static bool movement = false;
    public static int playerX = 8;
    public static int playerY = 10;
    static string input;

    public static void canMove(bool canMove)
    {
        Character.Update(player, enemy);
        movement = canMove;
        while (movement)
        {
            RoomGen.generateRoom(baseData.currentRoomX, baseData.currentRoomY, player, enemy);
            RoomGen.roomChange = 0;
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
            switch (RoomGen.tileData[playerX, playerY])
            {
                case 2:
                    baseData.currentRoomX--;
                    RoomGen.roomChange = 1;
                    break;
                case 3:
                    baseData.currentRoomY++;
                    RoomGen.roomChange = 2;
                    break;
                case 4:
                    baseData.currentRoomX++;
                    RoomGen.roomChange = 3;
                    break;
                case 5:
                    baseData.currentRoomY--;
                    RoomGen.roomChange = 4;
                    break;
                case 6:
                    if (RoomGen.defeatedEntities[7, 7] != true)
                    gameOver.print(true);
                    else
                    {
                        winScreen.print(baseData.artifactHealth && baseData.artifactLuck && baseData.artifactFight);
                    }
                    break;
                case 7:
                    enemy.name = Character.smallEnemies[random.Next(0, Character.smallEnemies.Length)];
                    Fighting.Fight(player, enemy);
                    break;
                case 9:
                    Fighting.Fight(player, enemy);
                    break;
                case 10:
                    baseData.artifactHealth = true;
                    break;
                case 11:
                    baseData.artifactFight = true;
                    break;
                case 12:
                    baseData.artifactLuck = true;
                    break;
                case 13:
                    RoomGen.defeatedEntities[baseData.currentRoomX, baseData.currentRoomY] = true;
                    baseData.keys--;
                    break;
                case 14:
                    baseData.keysList[baseData.currentRoomX,baseData.currentRoomY] = true;
                    baseData.keys++;
                    break;
            }
        }
    }
}
