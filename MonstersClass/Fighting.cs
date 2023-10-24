using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class Fighting
{
    static Random random = new Random();
    static bool fighting = false;
    static int enemyAttackRandom;
    static int healthGain;
    static int damageDealt;
    static int specialCheck;
    static string input;
    static bool playerTurn = false;
    public static void fightRunning(Character character1, Character character2)
    {

        HealthBars.print(character1, character2);
        windowspace();
        Character.printCharacters(character1 , character2, "battle");
        Comment.print();
        Attacks.print(character1);
        Thread.Sleep(1000);
        switch (playerTurn)
        {
            case true:
                playerAttack(character1, character2);
                break;
            case false:
                enemyAttack(character2, character1);
                break;
        }
    }

    public static void Fight(Character player, Character enemy)
    {
        PlayerMove.canMove(false);
        Console.Clear();
        Character.Update(player, enemy);
        FightingTitle.print(player, enemy);
        Thread.Sleep(5000);
        Console.Clear();
        while (Console.KeyAvailable) Console.ReadKey(true);
        fighting = true;
        if (baseData.artifactHealth)
        {
            player.hp = player.hpbase;
        }
        if(random.Next(2) == 0)
        {
            playerTurn = true;
        }
        while (player.hp > 0 && enemy.hp > 0 && fighting == true)
        {
            fightRunning(player, enemy);
            Console.Clear();
        }
        Comment.commentText = " ";
        if (player.hp > 0)
        {
            baseData.playerXP = baseData.playerXP + random.Next(15, 25) * enemy.strength;
            while (baseData.playerXP >= 100 * baseData.playerLevel)
            {
                baseData.playerXP = baseData.playerXP - 100 * baseData.playerLevel;
                baseData.playerLevel++;
            }
            fighting = false;
            RoomGen.defeatedEntities[baseData.currentRoomX, baseData.currentRoomY] = true;
            PlayerMove.canMove(true);
        }
        else
        {
            fighting = false;
            gameOver.print(false);
        }
    }
    static void enemyAttack(Character enemy, Character player)
    {
        if (enemy.hp / enemy.hpbase * 100 < 15 * Character.difficulty)
        {
            enemyAttackRandom = random.Next(0, 12);
        }
        else
        {
            enemyAttackRandom = random.Next(2, 12);
        }
        if(enemyAttackRandom >= 0 && enemyAttackRandom < 2)
        {
            healthGain = random.Next(enemy.hpbase / 16, enemy.hpbase / 16 + enemy.hpbase / 16 * Character.difficulty);
            enemy.hp = enemy.hp + healthGain;
            Comment.commentText = enemy.name + " used " + Character.enemyAttackNames[0] + " and gained " + healthGain + "HP.";
        }
        else if (enemyAttackRandom >= 2 && enemyAttackRandom < 10)
        {

            damageDealt = random.Next(enemy.strength + 2 * Character.difficulty, enemy.strength + 5 * Character.difficulty);
            player.hp = player.hp - damageDealt;
            Comment.commentText = enemy.name + " used " + Character.enemyAttackNames[1] + " and dealt " + damageDealt + "HP.";
        }
        else
        {
            specialCheck = random.Next(0, 3);

            if(specialCheck == 1)
            {
                damageDealt = random.Next(enemy.strength + 20, enemy.strength + 20 * Character.difficulty);
                player.hp = player.hp - damageDealt;
                Comment.commentText = enemy.name + " succeeded at using " + Character.enemyAttackNames[2] + " and dealt " + damageDealt + "HP. OUCH !";
            }
            else
            {
                Comment.commentText = enemy.name + " tried using " + Character.enemyAttackNames[2] + " and failed.";
            }
        }
        damageDealt = 0;
        healthGain = 0;
        specialCheck = 0;
        enemyAttackRandom = 0;
        playerTurn = true;
    }
    static void playerAttack(Character player, Character enemy)
    {
        input = Console.ReadKey().Key.ToString();

        if (input == baseData.Controls["Action 1"])
        {
            healthGain = random.Next(20, 50);
            if (baseData.artifactHealth)
            {
                player.hp = player.hp + healthGain * 2;
                Comment.commentText = player.name + " used " + Character.attackNames[0] + " and gained " + healthGain * 2 + "HP. (2x Boost)";
            }
            else
            {
                player.hp = player.hp + healthGain;
                Comment.commentText = player.name + " used " + Character.attackNames[0] + " and gained " + healthGain + "HP.";
            }
            playerTurn = false;
        }
        else if (input == baseData.Controls["Action 2"])
        {
            damageDealt = random.Next(2 * player.strength, 4 * player.strength);
            if (baseData.artifactFight)
            {
                enemy.hp = enemy.hp - damageDealt * 3 / 2;
                Comment.commentText = player.name + " used " + Character.attackNames[1] + " and dealt " + damageDealt * 3 / 2 + "HP. (1.5x Boost)";
            }
            else
            {
                enemy.hp = enemy.hp - damageDealt;
                Comment.commentText = player.name + " used " + Character.attackNames[1] + " and dealt " + damageDealt + "HP.";
            }
            playerTurn = false;
        }
        else if (input == baseData.Controls["Action 3"])
        {
            if (baseData.artifactLuck) specialCheck = random.Next(0, 3);
            else specialCheck = random.Next(0, 2);

            if (specialCheck == 1)
            {
                damageDealt = random.Next(25, 30 * player.strength);
                enemy.hp = enemy.hp - damageDealt;
                Comment.commentText = player.name + " succeeded at using " + Character.attackNames[2] + " and dealt " + damageDealt + "HP. OUCH !";
            }
            else
            {
                Comment.commentText = player.name + " tried using " + Character.attackNames[2] + " and failed.";
            }
            playerTurn = false;
        }
        else
        {
            playerTurn = true;
        }
        damageDealt = 0;
        healthGain = 0;
        specialCheck = 0;
    }
    static void windowspace()
    {
        for(int i = 0;i < Console.WindowHeight - 18 - 11; i++)
        {
            Console.WriteLine();
        }
    }
}
