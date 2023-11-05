using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace ConsoleRPG
{
    public class FightState : MainLoopState
    {
        static Random random = new Random();
        static int enemyAttackRandom;
        static int healthGain;
        static int damageDealt;
        static int specialCheck;
        static bool playerTurn = false;

        public override void onCreate()
        {
            input = "";
            Character.Update(player, enemy, false, true);
            new FightTitleState();
            while (Console.KeyAvailable) Console.ReadKey(true);
            if (artifactHealth && player.hp > (player.hpbase / 3) * 2)
            {
                player.hp = (player.hpbase / 3) * 2;
            }
            if (random.Next(2) == 0)
            {
                playerTurn = true;
            }
        }
        public override void onUpdate()
        {

            Character.Update(player, enemy, false, false);
            Console.Clear();
            TopFightBar.print();
            verticalSpaces(Console.WindowHeight - 18 - 11);
            Character.printCharacters(player, enemy, "battle");
            Comment.print();
            Attacks.print(player);
            while (Console.KeyAvailable) Console.ReadKey(true);
            if (playerTurn)
            {
                Thread.Sleep(500);
                playerInput();
            }
            else
            {
                Thread.Sleep(1000);
                enemyAttack();
            }

            playerTurn = !playerTurn;
            damageDealt = 0;
            healthGain = 0;
            specialCheck = 0;
            enemyAttackRandom = 0;

            if (player.hp < 0 || enemy.hp < 0)
            {
                Comment.commentText = " ";
                if (player.hp > 0)
                {
                    playerXP += random.Next(15, 25) * enemy.strength;
                    while (playerXP >= 100 * playerLevel)
                    {
                        playerXP -= 100 * playerLevel;
                        playerLevel++;
                        Character.Update(player, enemy, false, false);
                        player.hp = player.hpbase;
                    }
                    defeatedEntities[currentRoomX, currentRoomY] = true;
                    _ = new DungeonState();
                }
                else
                {
                    GameOverState.left = false;
                    _ = new GameOverState();
                }
            }
        }
        static void enemyAttack()
        {
            if (enemy.hp / enemy.hpbase * 100 < 15 * Character.difficulty)
            {
                enemyAttackRandom = random.Next(0, 12);
            }
            else
            {
                enemyAttackRandom = random.Next(2, 12);
            }
            if (enemyAttackRandom >= 0 && enemyAttackRandom < 2)
            {
                healthGain = random.Next(enemy.hpbase / 16, enemy.hpbase / 16 + enemy.hpbase / 16 * Character.difficulty);
                enemy.hp += healthGain;
                Comment.commentText = enemy.name + " used " + Character.enemyAttackNames[0] + " and gained " + healthGain + "HP.";
            }
            else if (enemyAttackRandom >= 2 && enemyAttackRandom < 10)
            {

                damageDealt = random.Next(enemy.strength + 2 * Character.difficulty, enemy.strength + 5 * Character.difficulty);
                player.hp -= damageDealt;
                Comment.commentText = enemy.name + " used " + Character.enemyAttackNames[1] + " and dealt " + damageDealt + "HP.";
            }
            else
            {
                specialCheck = random.Next(0, 3);

                if (specialCheck == 1)
                {
                    damageDealt = random.Next(enemy.strength + 20, enemy.strength + 20 * Character.difficulty);
                    player.hp -= damageDealt;
                    Comment.commentText = enemy.name + " succeeded at using " + Character.enemyAttackNames[2] + " and dealt " + damageDealt + "HP. OUCH !";
                }
                else
                {
                    Comment.commentText = enemy.name + " tried using " + Character.enemyAttackNames[2] + " and failed.";
                }
            }
        }
        static void playerInput()
        {
            input = Console.ReadKey().Key.ToString();

            if (input == Controls["Action 1"])
            {
                healthGain = random.Next(20, 50);
                if (artifactHealth)
                {
                    player.hp += healthGain * 3 / 2;
                    Comment.commentText = player.name + " used " + Character.attackNames[0] + " and gained " + healthGain * 2 + "HP. (2x Boost)";
                }
                else
                {
                    player.hp += healthGain;
                    Comment.commentText = player.name + " used " + Character.attackNames[0] + " and gained " + healthGain + "HP.";
                }
            }
            else if (input == Controls["Action 2"])
            {
                damageDealt = random.Next(2 * player.strength, 4 * player.strength);
                if (artifactFight)
                {
                    enemy.hp -=  damageDealt * 3 / 2;
                    Comment.commentText = player.name + " used " + Character.attackNames[1] + " and dealt " + damageDealt * 3 / 2 + "HP. (1.5x Boost)";
                }
                else
                {
                    enemy.hp -= damageDealt;
                    Comment.commentText = player.name + " used " + Character.attackNames[1] + " and dealt " + damageDealt + "HP.";
                }
            }
            else if (input == Controls["Action 3"])
            {
                if (artifactLuck) specialCheck = random.Next(0, 3);
                else specialCheck = random.Next(0, 2);

                if (specialCheck == 1)
                {
                    damageDealt = random.Next(25, 30 * player.strength);
                    enemy.hp -=  damageDealt;
                    Comment.commentText = player.name + " succeeded at using " + Character.attackNames[2] + " and dealt " + damageDealt + "HP. OUCH !";
                }
                else
                {
                    Comment.commentText = player.name + " tried using " + Character.attackNames[2] + " and failed.";
                }
            }
            else if (input == Controls["Pause Game"])
            {
                _ = new Pause();
            }
            else
            {
                playerTurn = false;
            }
        }
    }
}
