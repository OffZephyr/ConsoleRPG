using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

public class Character
{
    public static int playerCharacter;
    public string name;
    public static string[] attackNames = new string[3];
    public static string[] enemyAttackNames = new string[3];
    static bool firstUpdate = false;
    public object color = Console.ForegroundColor;

    public int hpbase;
    public float hp;
    public float hp25;
    public int strength;
    public static int difficulty;

    public static string[] smallEnemies =
    {
        "Breadbug",
        "Vibe Checker"
    };

    public static void Update(Character player, Character enemy)
    {
        switch (baseData.currentRoomX, baseData.currentRoomY)
        {
            case (2, 4):
                    enemy.name = "Anti MrBeast";
                break;
            case (5, 4):
                    enemy.name = "Kirby";
                break;
            case (7, 4):
                enemy.name = "Broken Monday";
                break;
            case (7, 7):
                enemy.name = "Shrek";
                break;
        }
        player.strength = 3 + 8 * baseData.playerLevel / 5;
        player.hpbase = 150 + 25 * baseData.playerLevel / 2;
        if (firstUpdate == false)
        {
            player.hp = player.hpbase;
        }
        switch (playerCharacter)
        {
            case 1:
                player.name = "Smurf Cat";
                attackNames = new string[] { "We Live", "We Love", "We Lie" };
                player.color = ConsoleColor.DarkCyan;
                break;
            case 2:
                player.name = "Crewmate";
                attackNames = new string[] { "Fix Sabotage ", "Finish Task", "Call Meeting" };
                player.color = ConsoleColor.Red;
                break;
            case 3:
                player.name = "Saul Goodman";
                attackNames = new string[] { "Get Money", "Defend Cartel", "Pay Taxes" };
                player.color = ConsoleColor.DarkYellow;
                break;
        }
        switch (enemy.name)
        {
// BOSSES
            case "Shrek":
                enemyAttackNames = new string[] { "Mud Bath", "All Star", "GET OUT OF MY SWAMP" };
                enemy.strength = 30;
                enemy.hpbase = 500 + difficulty * 150;
                enemy.hp = enemy.hpbase;
                enemy.color = ConsoleColor.Green;
                break;
            case "Kirby":
                enemyAttackNames = new string[] { "Feast upon Flesh", "Beat up", "The cries of DreamLand" };
                enemy.strength = 20;
                enemy.hpbase = 300 + difficulty * 150;
                enemy.hp = enemy.hpbase;
                enemy.color = ConsoleColor.Magenta;
                break;
            case "Anti MrBeast":
                enemyAttackNames = new string[] { "Steal from the POOR", "Crime", "APOLOGY VIDEO" };
                enemy.strength = 10;
                enemy.hpbase = 300 + difficulty * 100;
                enemy.hp = enemy.hpbase;
                enemy.color = ConsoleColor.Yellow;
                break;
            case "Broken Monday":
                enemyAttackNames = new string[] { "Tuesday I was truly hoping...", "Wednesday my empty arms were open...", "Monday left me broken..." };
                enemy.strength = 15;
                enemy.hpbase = 300 + difficulty * 175;
                enemy.hp = enemy.hpbase;
                enemy.color = ConsoleColor.Gray;
                break;
            // SMALL ENEMIES
            case "Breadbug":
                enemyAttackNames = new string[] { "Theft", "Bread Shaker", "Bread Power" };
                enemy.strength = 4 + 8 * baseData.playerLevel / 5;
                enemy.hpbase = 75 + difficulty * 25 + 25 * baseData.playerLevel / 2;
                enemy.hp = enemy.hpbase;
                enemy.color = ConsoleColor.DarkYellow;
                break;
            case "Vibe Checker":
                enemyAttackNames = new string[] { "Heavy Breathing", "Shame", "VIBE CHECK" };
                enemy.strength = 5 + 8 * baseData.playerLevel / 5;
                enemy.hpbase = 50 + difficulty * 25 + 25 * baseData.playerLevel / 2;
                enemy.hp = enemy.hpbase;
                enemy.color = ConsoleColor.Yellow;
                break;
        }
        DrawCharacters.definePlayer(player);
        DrawCharacters.defineEnemy(enemy);
        DrawCharacters.definePlayerTitle(player);
        DrawCharacters.defineEnemyTitle(enemy);
        firstUpdate = true;
    }
    public static void printCharacters(Character player, Character enemy,string mode)
    {
        for (int i = 0; i < 18; i++)
        {
            Console.ForegroundColor = (ConsoleColor)player.color;
            Console.Write(DrawCharacters.playerCharacter[i]);
            for (int j = 0; j < Console.WindowWidth - DrawCharacters.playerWidth - DrawCharacters.enemyWidth; j++)
            {
                Console.Write(" ");
            }
            Console.ForegroundColor = (ConsoleColor)enemy.color;
            Console.WriteLine(DrawCharacters.enemyCharacter[i]);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}