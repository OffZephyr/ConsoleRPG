﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;


namespace ConsoleRPG
{
    public class DrawCharacters
    {
        public static string[] playerCharacter = new string[18];
        public static string[] enemyCharacter = new string[18];
        public static string[] playerTitle = new string[5];
        public static string[] enemyTitle = new string[5];
        public static int playerTitleWidth;
        public static int enemyTitleWidth;
        public static int playerWidth;
        public static int enemyWidth;
        public static void definePlayer(Character player)
        {
            switch (player.name)
            {
                case "Smurf Cat":
                    playerCharacter[0] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡠⠖⠊⠉⠙⠒⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[1] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠎⠁⠀⠀⠀⠀⠀⠀⠱⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[2] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡰⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⢣⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[3] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡴⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠳⡀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[4] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠴⠊⠀⠀⠤⠤⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢄⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[5] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡔⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠑⢄⠀⠀⠀⠀⠀";
                    playerCharacter[6] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠔⠃⠀⠀⠀⠀⠀⢀⣀⣀⣀⡠⠠⡠⡠⠠⡀⣀⣀⣀⡀⠀⠀⠀⠑⢄⠀⠀⠀";
                    playerCharacter[7] = "⠀⠀⠀⠀⠀⠀⠀⠀⡠⠋⣀⡤⠔⠲⡪⠙⡙⡅⢃⠀⠀⠀⠀⠏⢅⠀⢀⡇⠀⡐⡌⠋⢱⠲⠤⣀⢣⠀⠀";
                    playerCharacter[8] = "⠀⠀⠀⠀⠀⠀⠀⠀⣇⠾⠄⠌⢆⠤⣀⣑⠵⠜⠒⠑⠉⠉⠉⠉⠁⠉⠉⠉⠉⠉⠒⠽⠁⣀⠄⠤⢳⡇⠀";
                    playerCharacter[9] = "⠀⠀⠀⠀⠀⠀⠀⠀⠻⣤⢄⠤⠠⢹⠁⠀⠀⠀⠀⠀⢀⣤⣶⣦⡀⠀⠀⠀⠀⠀⠀⠀⡗⡑⣐⣒⠞⠀⠀";
                    playerCharacter[10] = "⠀⠀⠀⠀⠀⠀⢀⠀⠀⠀⠑⢦⠤⣐⣣⠀⠀⠀⠀⠀⠸⠿⣿⠿⠗⠀⠀⠀⠀⡀⢠⣾⠉⠉⠀⠀⠀⠀⠀";
                    playerCharacter[11] = "⠀⠀⠀⠀⠀⠀⠀⢹⢔⠢⡄⠈⠢⣄⠀⠣⡀⠀⠀⠀⠀⠁⠈⠀⠀⠀⣀⣀⣀⣐⡔⡇⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[12] = "⠀⠀⠀⠀⠀⠀⠀⡾⠙⠁⢇⢀⠀⠀⠉⠉⠙⢆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠀⠉⢀⠇⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[13] = "⠀⠀⠀⠀⠀⠀⢀⣸⠀⡆⢘⢻⣄⢄⡦⠀⠀⢀⡉⡖⠤⠄⠀⣀⠠⠄⡀⢦⠤⠔⠊⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[14] = "⠀⠀⠀⠀⠀⢠⠊⠑⠳⣇⢸⠀⠙⢿⡇⠤⠒⡳⢮⢕⠈⠂⠀⢰⣈⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[15] = "⠀⠀⠀⠀⠀⡎⠁⠀⠀⠀⠻⡀⠀⣔⣿⠗⠁⠀⠀⠉⠫⢦⣄⠊⢦⢱⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[16] = "⠀⠀⠀⠀⠀⢫⠀⢰⠉⡤⡄⢱⢀⠟⠁⢀⡴⠄⢀⠀⠀⠀⠈⢳⡌⢆⠙⢄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[17] = "⠀⠀⠀⠀⠀⠀⠓⠬⠦⠽⠕⡗⠁⡠⠛⠡⡧⠀⠀⠉⠒⠒⠀⠀⠹⡺⡢⡀⠈⢦⡀⠀⠀⠀⠀⠀⠀⠀⠀";
                    break;
                case "Crewmate":
                    playerCharacter[0] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣤⣤⣤⣤⣤⣤⣤⣤⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀ ";
                    playerCharacter[1] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⡿⠛⠉⠙⠛⠛⠛⠛⠻⢿⣿⣷⣤⡀⠀⠀⠀⠀⠀ ";
                    playerCharacter[2] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⣿⠋⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⠈⢻⣿⣿⡄⠀⠀⠀⠀ ";
                    playerCharacter[3] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⣿⡏⠀⠀⠀⣠⣶⣾⣿⣿⣿⠿⠿⠿⢿⣿⣿⣿⣄⠀⠀⠀ ";
                    playerCharacter[4] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠁⠀⠀⢰⣿⣿⣯⠁⠀⠀⠀⠀⠀⠀⠀⠈⠙⢿⣷⡄⠀ ";
                    playerCharacter[5] = "⠀⠀⠀⠀⠀⠀⣀⣤⣴⣶⣶⣿⡟⠀⠀⠀⢸⣿⣿⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣷⠀ ";
                    playerCharacter[6] = "⠀⠀⠀⠀⠀⢰⣿⡟⠋⠉⣹⣿⡇⠀⠀⠀⠘⣿⣿⣿⣿⣷⣦⣤⣤⣤⣶⣶⣶⣶⣿⣿⣿⠀ ";
                    playerCharacter[7] = "⠀⠀⠀⠀⠀⢸⣿⡇⠀⠀⣿⣿⡇⠀⠀⠀⠀⠹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠃⠀ ";
                    playerCharacter[8] = "⠀⠀⠀⠀⠀⣸⣿⡇⠀⠀⣿⣿⡇⠀⠀⠀⠀⠀⠉⠻⠿⣿⣿⣿⣿⡿⠿⠿⠛⢻⣿⡇⠀⠀ ";
                    playerCharacter[9] = "⠀⠀⠀⠀⠀⣿⣿⠁⠀⠀⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣧⠀⠀ ";
                    playerCharacter[10] = "⠀⠀⠀⠀⠀⣿⣿⠀⠀⠀⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⠀⠀ ";
                    playerCharacter[11] = "⠀⠀⠀⠀⠀⣿⣿⠀⠀⠀⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⠀⠀ ";
                    playerCharacter[12] = "⠀⠀⠀⠀⠀⢿⣿⡆⠀⠀⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡇⠀⠀ ";
                    playerCharacter[13] = "⠀⠀⠀⠀⠀⠸⣿⣧⡀⠀⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠃⠀⠀ ";
                    playerCharacter[14] = "⠀⠀⠀⠀⠀⠀⠛⢿⣿⣿⣿⣿⣇⠀⠀⠀⠀⠀⣰⣿⣿⣷⣶⣶⣶⣶⠶⠀⢠⣿⣿⠀⠀⠀ ";
                    playerCharacter[15] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠀⠀⠀⠀⠀⣿⣿⡇⠀⣽⣿⡏⠁⠀⠀⢸⣿⡇⠀⠀⠀ ";
                    playerCharacter[16] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠀⠀⠀⠀⠀⣿⣿⡇⠀⢹⣿⡆⠀⠀⠀⣸⣿⠇⠀⠀⠀ ";
                    playerCharacter[17] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⣦⣄⣀⣠⣴⣿⣿⠁⠀⠈⠻⣿⣿⣿⣿⡿⠏⠀⠀⠀⠀ ";
                    break;
                case "Saul Goodman":
                    playerCharacter[0] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⢏⣼⣿⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⣿⣿⣧⠀⢻⣆⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[1] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⡏⣼⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⣄⠀⣶⠈⢻⣿⡄⠸⡟⢻⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[2] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⠙⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢿⣿⡆⢸⣿⡇⠀⡁⠈⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[3] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣿⣿⣿⣿⠀⠀⣀⡀⠀⠀⠀⠀⠃⠀⠀⠀⠘⠙⢃⣾⣿⠃⠀⡇⠀⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[4] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣟⣿⣿⡇⢠⡾⢻⡿⠿⢷⣦⣤⠁⣷⣄⣤⣾⠿⠿⢿⣿⣄⠀⣯⣀⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[5] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⣿⠃⠈⠡⠾⣿⣿⣿⡿⠁⠀⣼⣿⣿⡿⠛⢶⣿⣿⣿⠀⠹⢿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[6] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⣿⣿⣿⡇⠀⠀⠀⠀⠈⡹⠏⠀⠀⢻⣿⣿⣷⠀⠀⠙⠻⣿⡇⣠⡼⣟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[7] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣿⣿⣿⣿⠀⠀⠀⠀⠈⠀⠀⠀⠀⣸⣿⣿⣿⣧⠀⠀⠀⣿⠀⢿⡻⢿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[8] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⣿⣿⠀⠀⣼⣿⠀⠀⣿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[9] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢻⡿⡄⠀⠀⠀⠀⠀⠀⠉⢳⣶⣿⣿⣿⣯⡀⢸⣧⣼⡀⠀⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[10] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⢀⠀⠀⠀⡀⠀⠀⠀⢸⡅⢘⣟⣽⣿⣿⣿⣿⣿⠤⣼⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[11] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣮⡀⡀⠀⠙⠛⠛⠛⠛⠿⠻⣿⣿⣿⣿⣻⣧⡿⢿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[12] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣷⠀⠀⠀⠀⠀⠐⠛⠃⠀⠛⣿⣿⣿⣿⣿⣷⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[13] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣬⣿⣿⣷⣴⣦⠀⠀⠀⠀⣀⡀⣴⣿⣿⣿⣿⣿⣿⢸⣟⢢⣤⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[14] = "⠀⠀⠀⠀⠀⢀⣠⣤⣴⣶⣶⣿⣿⣿⣿⣿⣿⠻⣿⡷⢷⣦⠴⡾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣸⣿⠀⢲⣾⡿⠦⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀";
                    playerCharacter[15] = "⢀⣠⣴⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠈⠛⢦⣀⠀⠐⠛⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣼⣿⣿⣷⣶⣾⣯⣄⠀⠀⠀⠀⠀⠀";
                    playerCharacter[16] = "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡀⠀⠀⠀⠉⠳⣦⣀⣀⣾⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣤⡀⠀⠀";
                    playerCharacter[17] = "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡀⠀⠀⠀⠀⣨⡿⢟⣵⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷";
                    break;
            }
            playerWidth = playerCharacter[0].Length;
        }
        public static void defineEnemy(Character enemy)
        {
            switch (enemy.name)
            {
                case "Shrek":
                    enemyCharacter[0] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⠔⠊⠉⠉⠑⠢⡀⠀⠀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[1] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣴⠒⠉⢀⣠⣤⣈⠁⠀⠀⢘⣦⣼⡿⣿⣞⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[2] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡿⣷⡄⣿⢯⣈⣹⡆⠄⠐⣇⢈⡴⠛⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[3] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⡿⣃⠸⣿⣯⣿⠽⠀⠀⠈⠋⢳⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[4] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⠀⠀⠀⡙⣦⠀⠀⠀⠀⠀⠀⠀⠘⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[5] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⢿⡓⠿⠟⠛⠉⢳⡀⠀⠀⠀⠀⠀⠀⠙⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[6] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡆⣄⣀⣀⣀⣀⣀⠁⠀⠀⠀⠀⠀⠀⠀⠘⣆⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[7] = "⠀⠀⠀⠀⠀⠀⠀⢀⡀⠀⠀⠀⠀⠀⣷⡿⠛⠉⠉⠉⠀⠀⠀⠀⢀⡆⠐⠀⠀⠀⢹⣿⣹⡷⢤⣀⣀⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[8] = "⠀⠀⠀⠀⠀⣠⡾⠋⠈⠉⠁⠈⠉⠉⠙⡷⢄⣀⠦⠴⠊⠀⠒⣨⠍⠂⠀⠀⠀⠀⠀⣿⣿⣿⣠⣿⡿⠛⠉⠉⠓⠢⢤⣀⡤⠤⠄⠀⠀⠀⣀⣀⣤⣀⡀⠀⠀⠀⠀";
                    enemyCharacter[9] = "⢀⣴⣊⣍⠁⣿⠀⠀⠀⠀⠀⠀⠀⠀⢰⣷⣤⠤⠤⣄⣀⣾⡝⠁⠀⠀⠀⠀⠀⠀⢰⣿⣿⣿⣿⡿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⠿⠿⠷⠄⢀⣀⣀";
                    enemyCharacter[10] = "⢯⣠⣾⢟⡴⠻⣶⣤⣤⡤⢤⣴⣤⣀⣼⣿⣿⣿⠛⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⣠⣾⣿⣿⣿⡟⠁⠀⢠⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⡏⠀⠀⠀⠀⠀⠀⠐";
                    enemyCharacter[11] = "⠀⠠⣥⣯⠏⠉⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⣿⡟⠁⠀⠀⠀⢧⡀⠀⢀⣀⢢⡀⠀⠀⠀⠀⠀⣿⡗⡄⠀⠀⠀⢀⣄⡀";
                    enemyCharacter[12] = "⠀⠀⠈⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⣿⣧⠀⠀⠀⠀⠀⢀⣠⣾⣿⣿⣿⣿⣿⣿⣿⠁⠂⠀⠀⢲⣿⠟⠛⠋⠉⠙⠛⠓⠛⠒⠤⣤⣽⣷⣄⠀⠀⣾⠛⠛⠻";
                    enemyCharacter[13] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⡓⠒⣶⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣆⣀⣵⣶⣾⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠈⢦⠀⠘⣆⠀⠀";
                    enemyCharacter[14] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⠶⠾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢆⢄⣼⠀⠀";
                    enemyCharacter[15] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣿⠿⠿⢹⡆⠀⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠁⠀⠀";
                    enemyCharacter[16] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡇⠀⠀⠈⠁⠀⠀⠈⠉⠉⠉⠛⠛⠛⠛⠉⠉⠉⠉⠁⠀⠘⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[17] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";

                    break;
                case "Kirby":
                    enemyCharacter[0] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⠶⠚⠋⠉⠉⠉⠉⠉⠳⠤⣄⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ";
                    enemyCharacter[1] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⠶⠋⠀⣀⣀⠀⠀⠀⣀⣀⠀⠀⠀⠀⠀⠈⠻⣷⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ";
                    enemyCharacter[2] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⠤⠞⠁⠀⠀⣴⠃⣼⠀⠀⣰⡇⢸⡇⠀⠀⠀⠀⠀⠀⠉⠛⠒⠒⠒⠒⠤⣀⠀⠀⠀⠀⠀⠀⠀⠀ ";
                    enemyCharacter[3] = "⠀⠀⠀⠀⠀⠀⠀⠀⢀⡤⠚⠉⠀⡄⠀⠀⠀⢸⣿⣿⡿⠀⠀⣿⣿⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠲⡄⠀⠀⠀⠀⠀ ";
                    enemyCharacter[4] = "⠀⠀⠀⠀⠀⠀⠀⢠⠏⠁⠀⠀⡰⠁⠀⣀⡀⢸⣿⣿⠇⠀⠀⣿⣿⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⣄⠀⠀⠱⡀⠀⠀⠀⠀ ";
                    enemyCharacter[5] = "⠀⠀⠀⠀⠀⠀⢀⡟⠀⠀⣀⡀⡀⠀⢾⣯⣭⠟⠉⢋⣀⣀⣀⡨⠍⠁⠀⠀⣶⣶⡄⠀⠀⠀⠀⠀⠲⠯⢭⣅⣈⡀⠀⠀⠱⡄⠀⠀⠀ ";
                    enemyCharacter[6] = "⠀⠀⠀⠀⠀⢀⡾⠀⠀⠒⢺⢀⡇⠀⠀⠀⠀⠀⠀⠈⠻⢿⡿⠃⠀⠀⠀⠀⠀⠉⠉⠀⠀⠀⠀⠀⠰⡄⠀⠀⠀⠀⠀⠀⠀⠱⡄⠀⠀ ";
                    enemyCharacter[7] = "⠀⠀⠀⠀⣠⠞⠁⠀⠀⠀⠈⡎⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣶⡄⠀⠀⠀⠀⠀⠀⠙⣆⠀ ";
                    enemyCharacter[8] = "⠀⠀⢠⡞⠁⠀⢷⣄⠀⣴⣾⣿⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⠃⠙⢶⣤⡀⠀⠀⠀⠀⠘⠀ ";
                    enemyCharacter[9] = "⠀⠀⣾⠃⠀⠀⣈⣻⣿⣿⠟⠁⠹⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⠏⠀⠀⠀⢹⡏⢦⠀⠀⠀⠀⠀ ";
                    enemyCharacter[10] = "⠀⢠⡏⠀⠀⣰⣿⢠⣾⠟⠀⠀⠀⠘⢷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣤⡴⠋⠀⠀⠀⠀⠈⠻⣿⡄⠀⠀⠀⠀";
                    enemyCharacter[11] = "⠀⡼⠀⠀⢰⣿⠿⠛⠁⠀⠀⠀⠀⠀⠈⣿⠷⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⠖⠋⠉⠁⢸⡁⠀⠀⠀⠀⠀⠀⠀⣠⠃⠀⠀⠀⠀";
                    enemyCharacter[12] = "⢠⡇⠀⠀⠈⢧⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⠀⠀⠉⠛⠶⣦⣤⣀⣀⣶⣤⠞⠋⠁⠀⠀⠀⠀⠘⡇⠀⠀⠀⠀⠀⠀⣸⣿⢦⣤⡀⠀⠀";
                    enemyCharacter[13] = "⢸⣴⠀⣤⢶⣿⠀⠀⠀⠀⠀⠀⠀⠀⢰⠿⡆⠀⠀⠀⠀⠀⠈⣽⡟⠛⣧⡀⠀⠸⡄⠀⠀⠀⢀⡇⠀⠀⠀⠀⠀⠀⠹⣧⣴⠟⢇⢀⣀";
                    enemyCharacter[14] = "⠘⣯⣜⠁⠘⠿⠀⠀⠀⠀⠀⠀⠀⠀⠸⡄⣿⣄⠀⠀⠀⠀⣠⡿⠀⠀⠘⣷⡄⠀⠹⡆⠀⢀⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣾⠟";
                    enemyCharacter[15] = "⠀⠹⣿⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣟⣿⣧⡄⠀⢰⡿⠁⠀⠀⠀⠘⣷⣀⣠⢷⣽⣿⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠀⠀";
                    enemyCharacter[16] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⡛⠻⣿⣶⣿⠃⠀⠀⠀⠀⠀⠘⣿⣏⢀⣤⣼⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[17] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣟⡶⣮⣽⡏⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⡶⠟⢱⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    break;
                case "Breadbug":
                    enemyCharacter[0] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠠⠠⠠⠐⠄⠢⠠⡠⠠⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[1] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠄⠂⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠈⢂⠄⡁⠁⠂⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[2] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡠⢁⢀⢀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⠐⠄⠄⠀⠁⢂⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[3] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⠠⠉⠈⠀⠀⠀⠀⠑⠐⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠘⡄⠀⠀⠐⢄⠀⠀⠀⠀⠀";
                    enemyCharacter[4] = "⠀⠀⠀⠀⠀⠀⠀⠀⡀⠎⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠢⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠨⡀⠀⠀⠀⢢⠀⠀⠀⠀";
                    enemyCharacter[5] = "⠀⠀⠀⠀⠀⠀⡠⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠣⡠⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢑⠀⠀⠀⠀⢇⠀⠀⠀";
                    enemyCharacter[6] = "⠀⠀⠀⠀⠀⠀⡕⠀⡀⣄⠄⢤⡰⡐⠤⡀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⠄⠀⠀⠀⠘⡆⠀⠀";
                    enemyCharacter[7] = "⠀⠀⠀⠀⠀⠀⡂⢐⣷⡄⢁⠪⠂⠁⠁⠁⠁⢢⡀⠀⠀⠀⠀⠀⠀⠀⠘⡄⠀⠀⠀⠀⠀⠀⠀⠀⠨⠅⠀⠀⠀⠀⣗⠀⠀";
                    enemyCharacter[8] = "⠀⠀⠀⠀⠀⠀⠄⢀⠩⠁⠀⠀⠀⠀⠀⠀⠀⠻⡿⠢⡀⠀⠀⠀⠀⠀⠀⠈⡂⠀⠀⠀⠀⠀⠀⠀⠈⡂⠀⠀⠀⠀⣺⠀⠀";
                    enemyCharacter[9] = "⠀⠀⠀⠀⠀⡠⠊⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠑⠄⠀⠀⠀⠀⠀⠀⠘⠀⠀⠀⠀⠀⠀⠀⢐⠀⠀⠀⠀⢐⠸⠀⠀";
                    enemyCharacter[10] = "⠀⠀⠀⢀⠜⠀⠀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⡀⠀⠀⠀⠀⠀⠀⡁⠀⠀⠀⠀⠀⠀⠔⠀⠀⠀⠀⠄⢜⠀⠀";
                    enemyCharacter[11] = "⠀⠀⠀⢐⠀⠀⠀⠀⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠀⠀⠀⡀⠂⡰⠁⠀⠀";
                    enemyCharacter[12] = "⠀⠀⠀⠐⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⠀⠔⠀⠀⠀⠀";
                    enemyCharacter[13] = "⠀⠀⠀⠀⢁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⠤⠀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⡔⠉⠀⠀⠀⠀⠀";
                    enemyCharacter[14] = "⠀⠀⠀⠀⠀⠉⠢⣀⠀⠀⠀⠀⠀⠀⠀⡀⡄⠒⡁⡁⠄⠄⠅⢅⠤⠠⣀⢀⢀⢀⢀⢀⠀⢄⠠⠂⠃⠁⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[15] = "⠀⠀⠀⠀⠀⠀⠀⠀⠉⠐⠓⠚⠢⢑⠩⠄⠂⢁⢀⠄⠕⡀⠀⠠⠀⠀⠰⠀⠀⠰⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[16] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⠀⢉⠔⡡⠐⠁⠀⠠⠊⡠⠢⢈⠂⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[17] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠀⠀⠀⠀⠐⠅⠊⠀⠀⠀⠈⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    break;
                case "Vibe Checker":
                    enemyCharacter[0] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈";
                    enemyCharacter[1] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡼⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣉⣉⣙⠣⠄⠀⠀⠀⠉⠉⠉⠛⠶⢦⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[2] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⢀⣡⡴⠾⣿⡉⠛⢿⣦⠀⢀⣰⠶⠛⠛⠻⢶⣄⡙⢢⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[3] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣤⣤⡶⣶⣤⣀⠸⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢷⣿⢃⢴⣿⣿⣿⣶⡀⠹⣶⠟⣡⣾⣿⣿⣶⡄⠙⢷⡄⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[4] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡼⠋⢁⡴⢧⡀⢉⣛⣿⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⡏⠈⣿⣿⣿⣿⣿⣷⠀⠟⠀⣿⣿⣿⣿⣿⣿⠀⢸⣷⡀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[5] = "⠀⠀⠀⠀⠀⠀⠀⢀⣴⡟⠁⣰⡿⠁⠀⣹⠟⢋⣡⣿⢧⡀⠀⠀⠀⠀⠀⠀⠀⠀⠟⣷⡀⠸⣿⣿⣿⡿⠃⠀⣦⠀⠛⣿⣿⣿⣿⡏⠀⣼⡿⠁⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[6] = "⠀⠀⠀⠀⢀⣴⡾⠛⠉⡿⠸⡏⠀⢀⡾⠉⢉⣾⠯⣥⡈⠻⣧⠀⠀⠀⠀⠀⠀⠀⠸⣬⣿⡆⠀⠀⠁⠀⢀⣀⠘⢷⣤⡈⠉⠙⠃⣨⣾⡿⠁⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[7] = "⠀⠀⠀⣰⡏⠉⢇⡞⠶⢷⡀⠹⣄⠘⠀⣰⡟⠀⢀⡞⠉⠁⠺⣷⡀⠀⠀⠀⠀⠀⠀⠀⠙⢿⡷⣤⣴⣶⠞⠁⠀⠀⠙⠿⢾⣷⡿⠿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[8] = "⠀⠀⠀⣿⠠⠀⠈⠓⠀⠠⢷⣄⠘⢷⣀⠹⡄⢠⡼⠀⠀⠀⢀⣿⢻⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[9] = "⠀⠀⢀⣿⠀⠀⠀⠀⠀⠀⠰⡦⠀⠀⠻⣆⡑⠏⠀⠀⠀⠀⣼⣿⡍⠛⢿⣦⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[10] = "⠀⢠⣾⢻⣦⠀⠀⠀⠀⠀⠀⠈⠀⠀⠀⠚⠻⣦⣤⣤⣴⣿⣋⣹⣷⠀⢠⡈⢻⣿⣷⣦⣄⣤⣤⣄⣀⣤⣤⣤⣤⣤⣤⣤⣠⣤⣤⣤⣤⣤⣤⣤⣤⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[11] = "⢠⡟⠀⠘⢿⣆⡈⢷⣄⠀⠀⠀⠙⡄⠀⠛⠂⣀⠘⠠⠟⣿⣿⠁⣿⣀⣼⠟⠉⣀⠀⠸⣿⡟⣿⡿⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⣿⡿⠟⠃⠀⠀⠀⠀⠀";
                    enemyCharacter[12] = "⢸⠁⠀⠀⠀⠻⠧⣄⣿⣷⡀⠀⠀⠀⠀⠀⠀⠈⠱⠀⠈⠙⣿⣿⣿⣿⡿⠷⠂⠹⢧⠀⣾⣿⠉⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[13] = "⢸⠀⠀⠀⠀⠀⠀⠹⠿⣿⣻⣦⡀⠀⠀⠀⠀⠀⢀⡀⠀⠑⠾⣿⣿⡿⠸⠆⠠⠆⠀⠀⢸⢻⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⢣";
                    enemyCharacter[14] = "⡞⠀⢀⠀⠀⠀⠀⠀⠀⠐⠀⢙⣿⣦⡀⠀⠀⣴⠟⡁⠀⠀⣰⣿⡟⠓⢰⣆⡼⠦⢄⠀⠬⡷⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠴⢞⡵⠛";
                    enemyCharacter[15] = "⠇⠀⠘⠻⣦⣄⠄⠀⢠⡀⠀⠀⠛⠛⣷⣄⡀⠉⠀⠽⢀⣾⣿⠟⢀⣴⢾⡟⢧⡀⡀⠙⣆⣶⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⠜⢃⡴⠋⠀⠀";
                    enemyCharacter[16] = "⣄⠀⠀⠀⠉⠛⢷⣄⠀⠙⣄⠀⠀⠀⠙⣏⡛⢷⣄⣘⢻⣿⡏⠀⢾⠁⠸⣷⣈⣿⣤⠾⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣎⣵⠾⠋⠀⠀⠀⠀";
                    enemyCharacter[17] = "⠸⣦⡄⠀⠀⠀⠀⡙⢷⣄⠈⠀⠀⠀⣀⡞⠁⡇⠈⣹⡿⠋⢷⠀⢸⡆⢠⣾⡿⠋⠙⠷⢦⣄⣀⣀⡀⠀⠀⠀⠀⠀⣀⣀⠀⠀⣀⣠⣿⠷⠞⠋⠁⠀⠀⠀⠀⠀⠀";
                    break;
                case "Anti MrBeast":
                    enemyCharacter[0] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⣿⣿⣿⣿⣿⣿⣷⣶⣤⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[1] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[2] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[3] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[4] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠿⠿⣿⡿⡟⢻⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[5] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣭⣭⠉⠀⠁⠟⡿⠋⢿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[6] = "⠀⠀⠀⠀⠀⠀⡤⠀⠤⡀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⣿⣿⣿⡏⠀⢁⡿⠋⣩⣭⣍⣷⣦⠀⣴⣾⡷⢺⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[7] = "⠀⠀⠀⠀⠀⢸⣄⠀⠀⢧⢠⠔⠤⡄⠀⠀⠀⠀⢹⣿⣿⣿⣿⡇⠀⠀⠺⠿⠿⣟⣻⠟⠉⠀⡉⠛⠀⠀⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[8] = "⠀⠀⠀⠀⢀⡸⠁⣄⠀⢸⣼⠀⠀⢸⠀⠀⠀⠀⠸⣿⡻⣿⡟⠃⠀⠀⠀⠀⠀⠁⠀⢀⠀⠀⠙⠀⢠⠀⣱⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[9] = "⠀⠀⠀⠀⡞⠀⠀⠈⠂⣾⡏⠀⠀⣼⠀⠀⠀⠀⠀⠈⢻⡍⢹⡀⠀⠀⠀⠀⢠⠞⢀⡾⢷⣶⡿⣗⣼⣆⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    enemyCharacter[10] = "⠀⠀⠀⢰⠱⠿⠂⠀⠀⣿⠁⠀⠀⣹⠀⠀⠀⠀⠀⠀⠀⣿⡏⠃⠀⠀⠀⠀⠀⣰⣿⣵⣄⣟⣇⡭⣟⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⠒⡂⠀⠀⣼⠉";
                    enemyCharacter[11] = "⠀⠀⢠⠇⠂⠀⠀⠀⠀⠟⠀⠀⠀⡇⠀⠀⠀⠀⠀⠀⢀⣼⠷⠀⠀⠀⠀⠐⡆⣿⣿⣿⣯⣿⣾⡿⢹⠉⠒⠒⠤⢤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣯⢤⡇⠀⡰⠡⠤";
                    enemyCharacter[12] = "⠀⠀⡘⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡇⠀⠀⠀⠀⣠⡴⠋⠻⡀⠀⠀⠀⠀⣤⣴⣟⠉⢀⣽⣯⡿⠖⣼⠀⠸⡄⢢⠀⠀⠳⣄⠀⠀⠀⠀⠀⠀⢰⣇⠀⡇⢠⠏⣄⡜";
                    enemyCharacter[13] = "⠀⠀⡇⠐⠀⠀⠀⠀⠀⠀⠀⠀⠰⡇⠀⣀⣴⠊⠀⠀⠀⠀⠑⢄⠀⠀⠀⠈⢻⣿⣷⣾⣭⣭⣤⣶⠃⠀⠀⠁⠀⢣⢀⡇⠀⠱⡄⠀⠀⠀⠀⢸⡎⠁⣧⡿⠀⣴⡡";
                    enemyCharacter[14] = "⠀⣰⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡷⠋⠁⣄⠀⠀⠀⠀⠀⢀⠈⠑⢤⣀⠀⠈⠉⠉⠉⢛⡿⠉⠀⠀⠀⠀⠀⠀⠀⢀⠇⠆⠀⠈⢦⠀⠀⠀⣸⠁⠀⠉⠁⠛⢿⡁";
                    enemyCharacter[15] = "⡐⠁⣰⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠇⠀⠀⠈⠑⢀⡴⠊⠒⣄⠑⠦⣀⠈⠙⠤⠤⠒⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠃⢰⠀⠄⠀⠷⡄⢠⠟⠀⠀⠀⣀⠀⠀⠹";
                    enemyCharacter[16] = "⡇⣼⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠀⠀⢀⠞⠀⠀⠀⠈⠉⠒⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⠃⠀⠀⠀⠀⢘⡯⠄⠀⠀⠛⠿⠿⣦⣀";
                    enemyCharacter[17] = "⣠⣿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢦⠀⣠⠃⠀⠀⠠⠎⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡀⠀⠀⠀⠀⠀⠀⢙⡆⠤⠤⢤⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀⣹";
                    break;
                case "Broken Monday":
                    enemyCharacter[0] = "⢨⢎⢎⢎⢎⢎⢎⠮⡪⠪⠊⠊⠊⠊⠊⠪⠪⠪⠺⡜⣎⠵⣣⢫⢎⢮⡃";
                    enemyCharacter[1] = "⢸⢔⢕⠕⢕⠕⢁⠄⠠⠐⠀⠁⠐⠀⠂⠠⠀⡐⢀⢈⠈⠳⡱⡣⡫⢎⡣";
                    enemyCharacter[2] = "⢸⠪⡪⡳⢌⢆⠱⡠⡁⢄⠡⡈⢄⠡⡈⡐⢀⠢⢐⠤⣑⠑⡴⢬⡪⣚⠔";
                    enemyCharacter[3] = "⢸⡱⡹⡜⡕⡢⢣⢓⢜⠔⡆⢲⠠⣣⢂⢎⢢⠣⡣⡳⢌⢎⢪⠲⣍⠎⠁";
                    enemyCharacter[4] = "⢸⢔⠱⣎⢎⡪⡱⡱⡕⣍⢾⣳⣕⣾⣢⣷⣯⡕⡵⡱⡱⣡⢃⢏⠮⠂⡡";
                    enemyCharacter[5] = "⢸⡘⡆⠣⡸⢌⢎⢮⡺⣵⡿⣿⣯⣿⣽⣯⣿⣾⣫⢞⢜⢢⡳⣈⢃⠸⡕";
                    enemyCharacter[6] = "⠸⡜⡠⢋⢜⢕⡱⡱⣙⠜⡿⣻⣽⣿⣯⣿⠷⣓⣥⣣⠫⡢⡳⡈⢆⠹⡢";
                    enemyCharacter[7] = "⢪⢪⠘⡄⢳⢵⡾⡼⣿⡿⣶⠹⣿⢷⣿⣻⢍⣿⣽⢿⣱⣷⡝⢌⠪⡈⡇";
                    enemyCharacter[8] = "⢨⡣⣱⣜⣜⣯⣿⣷⡾⣶⣮⣸⣟⢿⣝⡿⣲⣶⣶⣷⣿⣽⡻⣢⣳⠀⣇";
                    enemyCharacter[9] = "⢸⢔⢹⡮⣞⢾⡾⣽⡿⣿⣽⢷⣏⢟⡼⣹⣟⣷⡿⣷⢿⡾⣝⡧⣿⢀⡇";
                    enemyCharacter[10] = "⠸⡢⣏⢾⣝⢯⣾⡻⣟⣯⣿⡗⡵⣹⡺⡢⣻⣽⣻⡻⣯⣻⣞⢵⣏⡶⡑";
                    enemyCharacter[11] = "⢸⡘⡷⣯⢮⣻⢮⡿⣹⣟⣾⣯⣎⠮⣣⢫⣾⡽⣯⡻⣽⣳⡝⣾⢮⣟⠆";
                    enemyCharacter[12] = "⠸⡸⣯⣻⢷⣯⣟⣽⢎⣟⢞⡷⡻⣎⢮⡻⡳⡻⣮⢳⣽⣮⣿⣽⣟⢾⡇";
                    enemyCharacter[13] = "⢈⢞⣵⢟⣿⣳⣿⣽⣯⢯⣳⢍⢮⡪⡮⢮⣜⣽⡺⣟⣷⢿⣾⣳⣟⢷⡃";
                    enemyCharacter[14] = "⠰⡨⢺⢯⡿⣽⡷⣿⢷⣟⣵⣟⣮⢾⡵⣷⣳⢽⣽⣟⣿⣻⡷⣯⢯⡻⢀";
                    enemyCharacter[15] = "⠨⡢⡁⡳⣻⣝⣿⣻⡿⣽⣮⣞⡽⣫⢟⢾⡵⣿⢾⣯⣿⡽⣯⡻⢕⠱⠄";
                    enemyCharacter[16] = "⢨⠂⡎⢰⠁⠯⡺⣷⣻⢿⣽⢯⣿⣻⣟⣿⣻⣟⣟⡷⡻⢞⠝⡨⠢⡑⢅";
                    enemyCharacter[17] = "⢐⠕⡨⢢⠙⢔⢌⠢⣝⢙⠞⡫⠓⡛⡚⡗⡻⡪⣋⢞⠽⣢⢣⢕⢕⢌⠢";
                    break;
            }
            if (enemyCharacter[0] != null) enemyWidth = enemyCharacter[0].Length;
            else enemyWidth = 0;
        }
        public static void definePlayerTitle(Character character)
        {
            switch (character.name)
            {
                case "Smurf Cat":
                    playerTitleWidth = 54;
                    playerTitle[0] = "                                                      ";
                    playerTitle[1] = " ___  __  __  __  __  ____  ____     ___    __   ____ ";
                    playerTitle[2] = "/ __)(  \\/  )(  )(  )(  _ \\( ___)   / __)  /__\\ (_  _)";
                    playerTitle[3] = "\\__ \\ )    (  )(__)(  )   / )__)   ( (__  /(__)\\  )(  ";
                    playerTitle[4] = "(___/(_/\\/\\_)(______)(_)\\_)(__)     \\___)(__)(__)(__) ";
                    break;
                case "Crewmate":
                    playerTitleWidth = 49;
                    playerTitle[0] = "   ___                                  _       ";
                    playerTitle[1] = "  / __\\ __ _____      ___ __ ___   __ _| |_ ___ ";
                    playerTitle[2] = " / / | '__/ _ \\ \\ /\\ / / '_ ` _ \\ / _` | __/ _ \\";
                    playerTitle[3] = "/ /__| | |  __/\\ V  V /| | | | | | (_| | ||  __/";
                    playerTitle[4] = "\\____/_|  \\___| \\_/\\_/ |_| |_| |_|\\__,_|\\__\\___|";
                    break;
                case "Saul Goodman":
                    playerTitleWidth = 54;
                    playerTitle[0] = "                                                      ";
                    playerTitle[1] = " __      __    ___   ___   ___   _       __    _      ";
                    playerTitle[2] = "( (`    / /`_ / / \\ / / \\ | | \\ | |\\/|  / /\\  | |\\ |  ";
                    playerTitle[3] = "_)_)o   \\_\\_/ \\_\\_/ \\_\\_/ |_|_/ |_|  | /_/--\\ |_| \\|  ";
                    playerTitle[4] = "                                                      ";
                    break;
            }
        }
        public static void defineEnemyTitle(Character character)
        {
            switch (character.name)
            {
                case "Shrek":
                    enemyTitleWidth = 24;
                    enemyTitle[0] = " __ _              _    ";
                    enemyTitle[1] = "/ _\\ |__  _ __ ___| | __";
                    enemyTitle[2] = "\\ \\| '_ \\| '__/ _ \\ |/ /";
                    enemyTitle[3] = "_\\ \\ | | | | |  __/   < ";
                    enemyTitle[4] = "\\__/_| |_|_|  \\___|_|\\_\\";
                    break;
                case "Kirby":
                    enemyTitleWidth = 30;
                    enemyTitle[0] = "                              ";
                    enemyTitle[1] = ".-. .-..-..----. .----..-.  .-.";
                    enemyTitle[2] = "| |/ / | || {}  }| {}  }\\ \\/ / ";
                    enemyTitle[3] = "| |\\ \\ | || .-. \\| {}  } }  {  ";
                    enemyTitle[4] = "`-' `-'`-'`-' `-'`----'  `--'  ";
                    break;
                case "Breadbug":

                    enemyTitleWidth = 48;
                    enemyTitle[0] = "                                                ";
                    enemyTitle[1] = " ____  ____  ____   __   ____  ____  _  _   ___ ";
                    enemyTitle[2] = "(  _ \\(  _ \\(  __) / _\\ (    \\(  _ \\/ )( \\ / __)";
                    enemyTitle[3] = " ) _ ( )   / ) _) /    \\ ) D ( ) _ () \\/ (( (_ \\";
                    enemyTitle[4] = "(____/(__\\_)(____)\\_/\\_/(____/(____/\\____/ \\___/";
                    break;
                case "Vibe Checker":
                    enemyTitleWidth = 58;
                    enemyTitle[0] = "       _ _              ___ _               _             ";
                    enemyTitle[1] = "/\\   /(_) |__   ___    / __\\ |__   ___  ___| | _____ _ __ ";
                    enemyTitle[2] = "\\ \\ / / | '_ \\ / _ \\  / /  | '_ \\ / _ \\/ __| |/ / _ \\ '__|";
                    enemyTitle[3] = " \\ V /| | |_) |  __/ / /___| | | |  __/ (__|   <  __/ |   ";
                    enemyTitle[4] = "  \\_/ |_|_.__/ \\___| \\____/|_| |_|\\___|\\___|_|\\_\\___|_|   ";
                    break;
                case "Anti MrBeast":
                    enemyTitleWidth = 41;
                    enemyTitle[0] = "    __  ___     ____                  __ ";
                    enemyTitle[1] = "   /  |/  /____/ __ )___  ____ ______/ /_";
                    enemyTitle[2] = "  / /|_/ / ___/ __  / _ \\/ __ `/ ___/ __/";
                    enemyTitle[3] = " / /  / / /  / /_/ /  __/ /_/ (__  ) /_  ";
                    enemyTitle[4] = "/_/  /_/_/  /_____/\\___/\\__,_/____/\\__/  ";
                    break;
                case "Broken Monday":
                    enemyTitleWidth = 41;
                    enemyTitle[0] = "  _____ |  |   _____\\_ |__              ";
                    enemyTitle[1] = " /     \\|  |  /     \\| __ \\             ";
                    enemyTitle[2] = "|  Y Y  \\  |_|  Y Y  \\ \\_\\ \\            ";
                    enemyTitle[3] = "| __|_|  /____/__|_|  /___ / /\\  /\\  /\\ ";
                    enemyTitle[4] = "      \\/           \\/    \\/  \\/  \\/  \\/ ";
                    break;

            }
        }

    }
}