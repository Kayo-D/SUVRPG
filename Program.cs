﻿namespace SUVRPG
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string title = "Welcome to SUVRPG!";
            
            string[] options = { "NEW GAME", 
            "LOAD GAME", 
            "HIGHSCORE", 
            "QUIT"
            };

            Menu mainMenu = new Menu(title, options);
            int SelectedIndex = mainMenu.Run();

            switch (SelectedIndex)
            {
                case 0:
                    break;
                
                case 1:
                    break;
                
                case 2:
                    break;
                
                case 3:
                    break;

                case 4:
                    Environment.Exit(0);
                    break;
            }

        }
    }
}