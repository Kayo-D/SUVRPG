using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace SUVRPG
{
    public static class MainMenu
    {
        public static void Mainmenu()
        {
            GameMechanics game = new GameMechanics();
            CharacterUI charCreation = new CharacterUI();
            
            string title = "Welcome to SUVRPG!\n";

            string[] options = { "NEW GAME",
            "LOAD GAME",
            "HIGHSCORE",
            "QUIT"};

            Menu mainMenu = new Menu(title, options);
            int SelectedIndex = mainMenu.Run();

            switch (SelectedIndex)
            {
                case 0:
                    game.GameLoop(charCreation.characterCreation(), game.StartNewGame());

                    break;

                case 1:
                    game.LoadGame();
                    break;

                case 2:
                    WriteLine("Highscores yo");
                    break;

                case 3:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}