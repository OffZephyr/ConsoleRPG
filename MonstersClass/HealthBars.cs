using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HealthBars
{
    public static void print(Character character1, Character character2)
    {
        printName(character1.name, character2.name);
        printHealth(character1, character2);
        printBottomHealth();
    }
    static void middleSpaces()
    {
        for (int i = 0; i < Console.WindowWidth - 2 * Console.WindowWidth / 3 - 2 * Console.WindowWidth / 10 - 2; i++)
        {
            Console.Write(" ");
        }
    }
    static void healthBars(float character, string color)
    {
        switch (color)
        {
            case "red":
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i < 25 - character; i++)
                {
                    Console.Write("|");
                }
                Console.ForegroundColor = ConsoleColor.White;
                break;

            case "green":
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < character; i++)
                {
                    Console.Write("|");
                }
                Console.ForegroundColor = ConsoleColor.White;
                break;
        }

    }
    static void printBottomHealth()
    {
        for (int i = 0; i < Console.WindowWidth / 3 + Console.WindowWidth / 10; i++)
        {
            Console.Write("_");
        }
        Console.Write("|");
        middleSpaces();
        Console.Write("|");
        for (int i = 0; i < Console.WindowWidth / 3 + Console.WindowWidth / 10; i++)
        {
            Console.Write("_");
        }
        Console.WriteLine("");
    }
    static void printHealth(Character character1, Character character2)
    {
        List<Character> characterList = new List<Character>();
        characterList.Add(character1);
        characterList.Add(character2);


        foreach (Character character in characterList)
        {
            if (character.hp < 0)
            {
                character.hp = 0;
            }
            if (character.hp > character.hpbase)
            {
                character.hp = character.hpbase;
            }
            character.hp25 = Convert.ToInt32(character.hp / character.hpbase * 25);
        }
        for (int i = 0; i < Console.WindowWidth / 10; i++)
        {
            Console.Write(" ");
        }
        healthBars(character1.hp25, "green");
        healthBars(character1.hp25, "red");
        for (int i = 0; i < Console.WindowWidth / 3 - 25; i++)
        {
            Console.Write(" ");
        }
        Console.Write("|");
        middleSpaces();
        Console.Write("|");
        for (int i = 0; i < Console.WindowWidth / 3 - 25; i++)
        {
            Console.Write(" ");
        }
        healthBars(character2.hp25, "red");
        healthBars(character2.hp25, "green");
        for (int i = 0; i < Console.WindowWidth / 10; i++)
        {
            Console.Write(" ");
        }
        Console.WriteLine("");

    }
    static void printName(string name1, string name2)
    {
        for (int i = 0; i < Console.WindowWidth / 10; i++)
        {
            Console.Write(" ");
        }
        Console.Write(name1);
        for (int i = 0; i < Console.WindowWidth / 3 - name1.Length; i++)
        {
            Console.Write(" ");
        }
        Console.Write("|");
        middleSpaces();
        Console.Write("|");
        for (int i = 0; i < Console.WindowWidth / 3 - name2.Length; i++)
        {
            Console.Write(" ");
        }
        Console.Write(name2);
        for (int i = 0; i < Console.WindowWidth / 10; i++)
        {
            Console.Write(" ");
        }
        Console.WriteLine("");
    }
}
