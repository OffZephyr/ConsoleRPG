﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class CutsceneData : baseData // IMAGE , TEXT1 , TEXT2 , TEXT3
    {
        public static string[] frameImage = new string[Console.WindowHeight];
        public static int frameImageWidth;
        public static int frameImageHeight;
        public static string[,] INTRO = new string[,]
        {
            { "ShrekHead" , "In a NOT so distant land" , "Located in the Windows Console" , "A Terrible Threat appeared..." , "yellow" },
            { "Destruction" , "It caused Destruction and Chaos" , "And everyone had lost HOPE" , "Until one day..." , "red"},
            { "Hero" , "A Brave HERO appeared beyond the horizon" , "A HERO able to save everyone and SLAIN THE BEAST" , "And that HERO was YOU..." , "cyan"}
        };
        public static string[,] PERFECTEND = new string[,]
        {
            { "Hero" , "The adventure was difficult" , "And the fight even more" , "But our hero DEFEATED the BEAST at last!" , "yellow" },
            { "SealAway" , "Our HERO used the artifacts" , "to SEAL the BEAST AWAY" , "And make sure it never comes back..." , "lightyellow" },
            { "city" , "The land of the Windows Console was at peace again" , "And everyone's lives went back to normal" , "All of this, thanks to YOU..." , "green" }
        };
        public static string[,] BADEND = new string[,]
        {
            { "Hero" , "The adventure was difficult" , "And the fight even more" , "But our hero DEFEATED the BEAST at last!" , "yellow" },
            { "city" , "The land of the Windows Console was at peace again" , "And everyone's lives went back to normal" , "But for how long...?" , "green" },
            { "ShrekHead" , "After all of this..." , "The BEAST wasn't fully gone..." , "and still lurked in the shadows of the Windows Console." , "dark" }
        };
        public static string[,] SECRETEND = new string[,]
        {
            { "Leave" , "The hero decided to leave" , "And everyone died" , "THE END" , "white" },
        };


        public static void imageData(string name)
        {
            switch (name)
            {
                case "ShrekHead":
                    frameImage[0] = "⢀⡴⠑⡄⠀⠀⠀⠀⠀⠀⠀⣀⣀⣤⣤⣤⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ";
                    frameImage[1] = "⠸⡇⠀⠿⡀⠀⠀⠀⣀⡴⢿⣿⣿⣿⣿⣿⣿⣿⣷⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ";
                    frameImage[2] = "⠀⠀⠀⠀⠑⢄⣠⠾⠁⣀⣄⡈⠙⣿⣿⣿⣿⣿⣿⣿⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀ ";
                    frameImage[3] = "⠀⠀⠀⠀⢀⡀⠁⠀⠀⠈⠙⠛⠂⠈⣿⣿⣿⣿⣿⠿⡿⢿⣆⠀⠀⠀⠀⠀⠀⠀ ";
                    frameImage[4] = "⠀⠀⠀⢀⡾⣁⣀⠀⠴⠂⠙⣗⡀⠀⢻⣿⣿⠭⢤⣴⣦⣤⣹⠀⠀⠀⢀⢴⣶⣆ ";
                    frameImage[5] = "⠀⠀⢀⣾⣿⣿⣿⣷⣮⣽⣾⣿⣥⣴⣿⣿⡿⢂⠔⢚⡿⢿⣿⣦⣴⣾⠁⠸⣼⡿ ";
                    frameImage[6] = "⠀⢀⡞⠁⠙⠻⠿⠟⠉⠀⠛⢹⣿⣿⣿⣿⣿⣌⢤⣼⣿⣾⣿⡟⠉⠀⠀⠀⠀⠀ ";
                    frameImage[7] = "⠀⣾⣷⣶⠇⠀⠀⣤⣄⣀⡀⠈⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀ ";
                    frameImage[8] = "⠀⠉⠈⠉⠀⠀⢦⡈⢻⣿⣿⣿⣶⣶⣶⣶⣤⣽⡹⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀ ";
                    frameImage[9] = "⠀⠀⠀⠀⠀⠀⠀⠉⠲⣽⡻⢿⣿⣿⣿⣿⣿⣿⣷⣜⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀ ";
                    frameImage[10] = "⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣷⣶⣮⣭⣽⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀ ";
                    frameImage[11] = "⠀⠀⠀⠀⠀⠀⣀⣀⣈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⠀⠀⠀⠀⠀⠀⠀ ";
                    frameImage[12] = "⠀⠀⠀⠀⠀⠀⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀ ";
                    frameImage[13] = "⠀⠀⠀⠀⠀⠀⠀⠹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀ ";
                    frameImage[14] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠛⠻⠿⠿⠿⠿⠛⠉             ";
                    frameImageHeight = 15;
                    break;
                case "Destruction":
                    frameImage[0] = "                                 ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⠔⠊⠉⠉⠑⠢⡀⠀⠀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[1] = "                                 ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣴⠒⠉⢀⣠⣤⣈⠁⠀⠀⢘⣦⣼⡿⣿⣞⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[2] = "                                 ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡿⣷⡄⣿⢯⣈⣹⡆⠄⠐⣇⢈⡴⠛⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[3] = "                                 ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⡿⣃⠸⣿⣯⣿⠽⠀⠀⠈⠋⢳⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[4] = "                                 ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⠀⠀⠀⡙⣦⠀⠀⠀⠀⠀⠀⠀⠘⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[5] = "                                 ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⢿⡓⠿⠟⠛⠉⢳⡀⠀⠀⠀⠀⠀⠀⠙⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[6] = "                                 ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡆⣄⣀⣀⣀⣀⣀⠁⠀⠀⠀⠀⠀⠀⠀⠘⣆⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[7] = "                                 ⠀⠀⠀⠀⠀⠀⠀⢀⡀⠀⠀⠀⠀⠀⣷⡿⠛⠉⠉⠉⠀⠀⠀⠀⢀⡆⠐⠀⠀⠀⢹⣿⣹⡷⢤⣀⣀⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[8] = "                                 ⠀⠀⠀⠀⠀⣠⡾⠋⠈⠉⠁⠈⠉⠉⠙⡷⢄⣀⠦⠴⠊⠀⠒⣨⠍⠂⠀⠀⠀⠀⠀⣿⣿⣿⣠⣿⡿⠛⠉⠉⠓⠢⢤⣀⡤⠤⠄⠀⠀⠀⣀⣀⣤⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[9] = "                                 ⢀⣴⣊⣍⠁⣿⠀⠀⠀⠀⠀⠀⠀⠀⢰⣷⣤⠤⠤⣄⣀⣾⡝⠁⠀⠀⠀⠀⠀⠀⢰⣿⣿⣿⣿⡿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⠿⠿⠷⠄⢀⣀⣀⠀⠀⠀⠀⠀⠀";
                    frameImage[10] = "⠀⠀⠀⠀⠀⠀⢱⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢱⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢱⣆⢟⡴⠻⣶⣤⣤⡤⢤⣴⣤⣀⣼⢱⣆⣿⠛⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⢱⣆⣿⣿⣿⡟⠁⠀⢠⠀⠀⠀⠀⠀⢱⣆⠀⠀⠀⠀⠀⣿⡏⠀⠀⠀⠀⠀⢱⣆⣺⢽⣽⣦⣀⠀";
                    frameImage[11] = "⠀⠀⠀⠀⠀⠀⠈⣿⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣷⡀⠉⠀⠀⠀⠀⠀⠀⠀⠀⣿⠈⣿⣷⡀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⠈⣿⣷⡀⡟⠁⠀⠀⠀⢧⡀⠀⢀⣀⠈⣿⣷⡀⠀⠀⠀⣿⡗⡄⠀⠀⠀⢀⠈⣿⣷⡀⣎⠻⣮⡷";
                    frameImage[12] = "⠀⠀⠀⠀⠀⠀⢸⣿⣿⣷⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣷⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣷⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣷⣧⠀⠀⠀⢀⣠⣾⣿⣿⣿⢸⣿⣿⣷⣧⠂⠀⠀⢲⣿⠟⠛⠋⠉⢸⣿⣿⣷⣧⠤⣤⣽⣷⣄⠀⠀⣾⠛⢸⣿⣿⣷⣧⣆⠱⣼";
                    frameImage[13] = "⠀⠀⠀⠀⡀⢠⣿⡟⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⡀⢠⣿⡟⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⡀⢠⣿⡟⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⡀⢠⣿⡟⣿⣿⣿⡇⣶⣶⣿⣿⣿⣿⡀⢠⣿⡟⣿⣿⣿⡇⣵⣶⣾⣿⠀⠀⡀⢠⣿⡟⣿⣿⣿⡇⠀⠈⠉⠈⢦⠀⡀⢠⣿⡟⣿⣿⣿⡇⣤⡾";
                    frameImage[14] = "⠀⠀⠀⠀⣳⣼⣿⡏⢸⣿⣿⣿⢀⠀⠀⠀⠀⠀⣳⣼⣿⡏⢸⣿⣿⣿⢀⠀⠀⠀⠀⠀⣳⣼⣿⡏⢸⣿⣿⣿⢀⠀⠀⠀⠀⠀⣳⣼⣿⡏⢸⣿⣿⣿⢀⠻⣿⣿⣿⣿⣳⣼⣿⡏⢸⣿⣿⣿⢀⣿⣿⣿⠀⠀⣳⣼⣿⡏⢸⣿⣿⣿⢀⠀⠀⠀⠈⢆⣳⣼⣿⡏⢸⣿⣿⣿⢀⠀";
                    frameImage[15] = "⠀⠀⠀⣰⣿⣿⡿⠁⢸⣿⣿⡟⣼⡆⠀⠀⠀⣰⣿⣿⡿⠁⢸⣿⣿⡟⣼⡆⠀⠀⠀⣰⣿⣿⡿⠁⢸⣿⣿⡟⣼⡆⠀⠀⠀⣰⣿⣿⡿⠁⢸⣿⣿⡟⣼⡆⣿⣿⣿⣰⣿⣿⡿⠁⢸⣿⣿⡟⣼⡆⣿⡿⠀⣰⣿⣿⡿⠁⢸⣿⣿⡟⣼⡆⠀⠀⠀⣰⣿⣿⡿⠁⢸⣿⣿⡟⣼⡆";
                    frameImage[16] = "⢰⢀⣾⣿⣿⠟⠀⠀⣾⢿⣿⣿⣿⣿⢰⢀⣾⣿⣿⠟⠀⠀⣾⢿⣿⣿⣿⣿⢰⢀⣾⣿⣿⠟⠀⠀⣾⢿⣿⣿⣿⣿⢰⢀⣾⣿⣿⠟⠀⠀⣾⢿⣿⣿⣿⣿⢰⢀⣾⣿⣿⠟⠀⠀⣾⢿⣿⣿⣿⣿⢰⢀⣾⣿⣿⠟⠀⠀⣾⢿⣿⣿⣿⣿⢰⢀⣾⣿⣿⠟⠀⠀⣾⢿⣿⣿⣿⣿";
                    frameImage[17] = "⢸⣿⣿⣿⡏⠀⠀⠀⠃⠸⣿⣿⣿⡿⢸⣿⣿⣿⡏⠀⠀⠀⠃⠸⣿⣿⣿⡿⢸⣿⣿⣿⡏⠀⠀⠀⠃⠸⣿⣿⣿⡿⢸⣿⣿⣿⡏⠀⠀⠀⠃⠸⣿⣿⣿⡿⢸⣿⣿⣿⡏⠀⠀⠀⠃⠸⣿⣿⣿⡿⢸⣿⣿⣿⡏⠀⠀⠀⠃⠸⣿⣿⣿⡿⢸⣿⣿⣿⡏⠀⠀⠀⠃⠸⣿⣿⣿⡿";
                    frameImageHeight = 18;
                    break;
                case "Hero":
                    frameImage[0] = "⠀⠀⠀⠀⠀⠀⠀⣠⣶⣿⣶⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[1] = "⠀⠀⠀⠀⠀⠀⣼⣿⣿⣿⣿⣿⣷⡄⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[2] = "⠀⠀⠀⠀⢀⣾⣿⣿⣿⣿⣿⣿⣿⣷⡄⠀⠀⠀⠀⠀⠀";
                    frameImage[3] = "⠀⠀⢀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡀⠀⠀⠀⠀";
                    frameImage[4] = "⢀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⠀⠀⠀";
                    frameImage[5] = "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡀⠀";
                    frameImage[6] = "⠘⠿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⠀";
                    frameImage[7] = "⠀⠀⠀⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠋⣁⣀⠄";
                    frameImage[8] = "⠀⠀⠀⠀⢿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠛⠋⢁⢰⣿⡷⠀";
                    frameImage[9] = "⠀⠀⠀⠀⠀⠉⠻⠻⠟⣿⣿⣿⣤⣄⡀⣾⣼⣿⣿⣧⣀";
                    frameImage[10] = "⠀⠀⠀⠀⠀⠀⠀⣰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿";
                    frameImage[11] = "⠀⠀⠀⠀⠀⣠⣾⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿";
                    frameImage[12] = "⠀⠀⣀⣴⣾⣟⠁⣿⣿⣿⣿⣿⣿⣿⣦⠈⢿⣷⣍⡀⠀";
                    frameImage[13] = "⠀⢰⣿⠿⢻⣟⠀⣿⣿⣿⣿⣿⣿⣿⣷⡤⠸⢿⣿⣿⡆";
                    frameImage[14] = "⠀⠀⡿⠀⠀⠀⠈⠻⣿⣿⣿⣿⣿⣿⣟⣠⣀⠀⠙⠿⠅";
                    frameImage[15] = "⠀⠀⠀⠀⠀⠀⠀⠀⠘⢿⣿⣿⣿⣿⣿⣿⣿⣆⠀⠀⠀";
                    frameImage[16] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⣿⣿⠛⠋⣹⣿⣿⣿⡆⠀⠀";
                    frameImage[17] = "⠀⠀⠀⠀⣠⣾⣿⣿⣾⣿⣿⡏⠀⠘⠿⣿⣿⣿⡇⠀⠀";
                    frameImage[18] = "⠀⠀⠀⠀⠹⠿⠿⢿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImageHeight = 19;
                    break;
                case "SealAway":
                    frameImage[0] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡠⠖⠊⠉⠙⠒⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀          ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⠔⠊⠉⠉⠑⠢⡀⠀⠀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[1] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠎⠁⠀⠀⠀⠀⠀⠀⠱⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀          ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣴⠒⠉⢀⣠⣤⣈⠁⠀⠀⢘⣦⣼⡿⣿⣞⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[2] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡰⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⢣⠀⠀⠀⠀⠀⠀⠀⠀⠀          ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡿⣷⡄⣿⢯⣈⣹⡆⠄⠐⣇⢈⡴⠛⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[3] = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡴⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠳⡀⠀⠀⠀⠀⠀⠀⠀          ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⡿⣃⠸⣿⣯⣿⠽⠀⠀⠈⠋⢳⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[4] = "⠀⠀⠀⠀⠀⠀⠀⠀⢀⠴⠊⠀⠀⠤⠤⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢄⠀⠀⠀⠀⠀⠀          ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⠀⠀⠀⡙⣦⠀⠀⠀⠀⠀⠀⠀⠘⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[5] = "⠀⠀⠀⠀⠀⠀⢀⡔⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠑⢄⠀⠀⠀⠀     ██   ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⢿⡓⠿⠟⠛⠉⢳⡀⠀⠀⠀⠀⠀⠀⠙⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[6] = "⠀⠀⠀⠀⢀⠔⠃⠀⠀⠀⠀⠀⢀⣀⣀⣀⡠⠠⡠⡠⠠⡀⣀⣀⣀⡀⠀⠀⠀⠑⢄⠀⠀ ██       ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡆⣄⣀⣀⣀⣀⣀⠁⠀⠀⠀⠀⠀⠀⠀⠘⣆⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[7] = "⠀⠀⠀⡠⠋⣀⡤⠔⠲⡪⠙⡙⡅⢃⠀⠀⠀⠀⠏⢅⠀⢀⡇⠀⡐⡌⠋⢱⠲⠤⣀⢣⠀      ██  ⠀⠀⠀⠀⠀⠀⠀⠀⢀⡀⠀⠀⠀⠀⠀⣷⡿⠛⠉⠉⠉⠀⠀⠀⠀⢀⡆⠐⠀⠀⠀⢹⣿⣹⡷⢤⣀⣀⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[8] = "⠀⠀⠀⣇⠾⠄⠌⢆⠤⣀⣑⠵⠜⠒⠑⠉⠉⠉⠉⠁⠉⠉⠉⠉⠉⠒⠽⠁⣀⠄⠤⢳⡇          ⠀⠀⠀⠀⠀⠀⣠⡾⠋⠈⠉⠁⠈⠉⠉⠙⡷⢄⣀⠦⠴⠊⠀⠒⣨⠍⠂⠀⠀⠀⠀⠀⣿⣿⣿⣠⣿⡿⠛⠉⠉⠓⠢⢤⣀⡤⠤⠄⠀⠀⠀⣀⣀⣤⣀⡀⠀⠀⠀⠀⠀";
                    frameImage[9] = "⠀⠀⠀⠻⣤⢄⠤⠠⢹⠁⠀⠀⠀⠀⠀⢀⣤⣶⣦⡀⠀⠀⠀⠀⠀⠀⠀⡗⡑⣐⣒⠞⠀          ⠀⢀⣴⣊⣍⠁⣿⠀⠀⠀⠀⠀⠀⠀⠀⢰⣷⣤⠤⠤⣄⣀⣾⡝⠁⠀⠀⠀⠀⠀⠀⢰⣿⣿⣿⣿⡿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⠿⠿⠷⠄⢀⣀⣀⠀";
                    frameImage[10] = "⠀⢀⠀⠀⠀⠑⢦⠤⣐⣣⠀⠀⠀⠀⠀⠸⠿⣿⠿⠗⠀⠀⠀⠀⡀⢠⣾⠉⠉⠀⠀⠀⠀          ⠀⢯⣠⣾⢟⡴⠻⣶⣤⣤⡤⢤⣴⣤⣀⣼⣿⣿⣿⠛⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⣠⣾⣿⣿⣿⡟⠁⠀⢠⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⡏⠀⠀⠀⠀⠀⠀⠐⣺";
                    frameImage[11] = "⠀⠀⢹⢔⠢⡄⠈⠢⣄⠀⠣⡀⠀⠀⠀⠀⠁⠈⠀⠀⠀⣀⣀⣀⣐⡔⡇⠀⠀⠀⠀⠀⠀          ⠀⠀⠠⣥⣯⠏⠉⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⣿⡟⠁⠀⠀⠀⢧⡀⠀⢀⣀⢢⡀⠀⠀⠀⠀⠀⣿⡗⡄⠀⠀⠀⢀⣄⡀⠈";
                    frameImage[12] = "⠀⠀⡾⠙⠁⢇⢀⠀⠀⠉⠉⠙⢆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠀⠉⢀⠇⠀⠀⠀⠀⠀⠀          ⠀⠀⠀⠈⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⣿⣧⠀⠀⠀⠀⠀⢀⣠⣾⣿⣿⣿⣿⣿⣿⣿⠁⠂⠀⠀⢲⣿⠟⠛⠋⠉⠙⠛⠓⠛⠒⠤⣤⣽⣷⣄⠀⠀⣾⠛⠛⠻⣷";
                    frameImage[13] = "⠀⢀⣸⠀⡆⢘⢻⣄⢄⡦⠀⠀⢀⡉⡖⠤⠄⠀⣀⠠⠄⡀⢦⠤⠔⠊⠀⠀⠀⠀⠀⠀⠀          ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⡓⠒⣶⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣆⣀⣵⣶⣾⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠈⢦⠀⠘⣆⠀⠀⠈";
                    frameImage[14] = "⢠⠊⠑⠳⣇⢸⠀⠙⢿⡇⠤⠒⡳⢮⢕⠈⠂⠀⢰⣈⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀          ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⠶⠾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢆⢄⣼⠀⠀⠀";
                    frameImage[15] = "⡎⠁⠀⠀⠀⠻⡀⠀⣔⣿⠗⠁⠀⠀⠉⠫⢦⣄⠊⢦⢱⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀          ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣿⠿⠿⢹⡆⠀⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠁⠀⠀⠀";
                    frameImage[16] = "⢫⠀⢰⠉⡤⡄⢱⢀⠟⠁⢀⡴⠄⢀⠀⠀⠀⠈⢳⡌⢆⠙⢄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀          ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡇⠀⠀⠈⠁⠀⠀⠈⠉⠉⠉⠛⠛⠛⠛⠉⠉⠉⠉⠁⠀⠘⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[17] = "⠀⠓⠬⠦⠽⠕⡗⠁⡠⠛⠡⡧⠀⠀⠉⠒⠒⠀⠀⠹⡺⡢⡀⠈⢦⡀⠀⠀⠀⠀⠀⠀⠀          ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[18] = "⠀⠀⢀⣠⠤⠚⠀⡜⠁⢠⠮⡀⠀⠀⠀⠀⠀⠀⠀⠀⢣⠇⠈⢢⠂⠈⠲⢄⠀⠀⠀⠀⠀          ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImage[19] = "⠀⢖⣊⠀⠀⠀⢀⠂⣀⣸⣂⠓⠢⣀⠀⠀⠀⠀⠀⡄⠈⡎⠀⡇⢰⢄⡀⠀⠹⡀⠀⠀⠀          ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
                    frameImageHeight = 20;
                    break;
                case "city":
                    frameImage[0] = "                                   .''.                   ";
                    frameImage[1] = "       .''.      .        *''*    :_\\/_:     .            ";
                    frameImage[2] = "      :_\\/_:   _\\(/_  .:.*_\\/_*   : /\\ :  .'.:.'.         ";
                    frameImage[3] = "  .''.: /\\ :    /)\\   ':'* /\\ *  : '..'.  -=:o:=-         ";
                    frameImage[4] = " :_\\/_:'.:::.  | ' *''*    * '.\'/.'_\\(/_ '.':'.'         ";
                    frameImage[5] = " : /\\ : :::::  =  *_\\/_*     -= o =- /)\\     '  *         ";
                    frameImage[6] = "  '..'  ':::' === * /\\ *     .'/.\'.  ' ._____            ";
                    frameImage[7] = "      *        |   *..*         :       |.   |' .---'|    ";
                    frameImage[8] = "        *      |     _           .--'|  ||   | _|    |    ";
                    frameImage[9] = "        *      |  .-'|       __  |   |  |    ||      |    ";
                    frameImage[10] = "     .-----.   |  |' |  ||  |  | |   |  |    ||      |    ";
                    frameImage[11] = " ___'       ' /'\\ |  '-.''.    '-'   '-.'    '`      |____";
                    frameImage[12] = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
                    frameImage[13] = "                       ~-~-~-~-~-~-~-~-~-~   /|           ";
                    frameImage[14] = "          )      ~-~-~-~-~-~-~-~  /|~       /_|\\          ";
                    frameImage[15] = "        _-H-__  -~-~-~-~-~-~     /_|\\    -~======-~       ";
                    frameImage[16] = "~-\\XXXXXXXXXX/~     ~-~-~-~     /__|_\\ ~-~-~-~            ";
                    frameImage[17] = "~-~-~-~-~-~    ~-~~-~-~-~-~    ========  ~-~-~-~          ";
                    frameImage[18] = "      ~-~~-~-~-~-~-~-~-~-~-~-~-~ ~-~~-~-~-~-~             ";
                    frameImage[19] = "                        ~-~~-~-~-~-~                      ";
                    frameImageHeight = 20;
                    break;
            }
            frameImageWidth = frameImage[0].Length;

        }
    }
}
