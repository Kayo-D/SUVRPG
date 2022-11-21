using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUVRPG
{
public static class MainMenu
    {
        public static void Mainmenu()
        {
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
                    Game myGame = new Game();
                    
                    myGame.GameLoop(CreateCharacter.RunIntro(), myGame.StartNewGame());
                    break;

                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}