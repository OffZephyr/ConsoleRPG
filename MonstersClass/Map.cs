using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleRPG
{
    public class Map
    {
        public Map()
        {
            bool open = true;
            string input;
            string sideText;
            while (open)
            {
                Console.Clear();
                

                for (int i = 7; i > 0; i--)
                {
                    for (int j = -1; j < 3; j++)
                    {
                        if (i == 7 && j == 0) sideText = "Dungeon Map";
                        else if (i == 7 && j == 1) sideText = "Current Room: " + baseData.currentRoomX + "-" + baseData.currentRoomY;
                        else sideText = "";

                        sideTextWrite(sideText);
                        if (j == -1)
                        {
                            for (int k = 1; k < 8; k++)
                            {
                                string doorsymbol = "        ";
                                for (int l = 0; l < RoomData.roomDoors.GetLength(0); l++)
                                {
                                    if (RoomData.roomDoors[l, 0] == k && RoomData.roomDoors[l, 1] == i && RoomData.roomDoors[l, 3] != 0 && baseData.visitedRooms.Contains((k, i))) doorsymbol = "   ██   ";
                                }
                                Console.Write(doorsymbol);
                            }
                        }
                        else 
                        {
                            for (int k = 1; k < 8; k++)
                            {
                                string doorsymbol = " ";
                                if (j == 1 && baseData.visitedRooms.Contains((k, i)))
                                {
                                    for (int l = 0; l < RoomData.roomDoors.GetLength(0); l++)
                                    {
                                        if (RoomData.roomDoors[l, 0] == k && RoomData.roomDoors[l, 1] == i && RoomData.roomDoors[l, 2] != 0) doorsymbol = "█";
                                    }
                                }
                                Console.Write(doorsymbol);
                                    for (int m = 0; m < 3; m++)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        foreach ((int, int) o in baseData.visitedRooms)
                                        {
                                        if (o == (k, i)) Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        if (k == baseData.currentRoomX && i == baseData.currentRoomY && j == 1 && m == 1 && Character.playerCharacter == 1) Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        if (k == baseData.currentRoomX && i == baseData.currentRoomY && j == 1 && m == 1 && Character.playerCharacter == 2) Console.ForegroundColor = ConsoleColor.Red;
                                        if (k == baseData.currentRoomX && i == baseData.currentRoomY && j == 1 && m == 1 && Character.playerCharacter == 3) Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.Write("██");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                doorsymbol = " ";
                                if (j == 1 && baseData.visitedRooms.Contains((k, i)))
                                {
                                    for (int l = 0; l < RoomData.roomDoors.GetLength(0); l++)
                                    {
                                        if (RoomData.roomDoors[l, 0] == k && RoomData.roomDoors[l, 1] == i && RoomData.roomDoors[l, 4] != 0) doorsymbol = "█";
                                    }
                                }
                                Console.Write(doorsymbol);
                            }
                        }
                        Console.WriteLine();
                    }

                }

                input = Console.ReadKey().Key.ToString();
                if (input == baseData.Controls["Return"].ToString())
                {
                    open = false;
                }
            }

        }
        static void spaces(int amount)
        {
            for(int i = 0; i < amount; i++)
            {
                Console.Write(" ");
            }
        }
        static void sideTextWrite(string text)
        {
            Console.Write(text);
            spaces(Console.WindowWidth / 2 - text.Length - (4 * 7));
        }
    }
}
