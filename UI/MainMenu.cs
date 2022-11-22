using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Media;

namespace SUVRPG
{
    public static class MainMenu
    {
        public static void Mainmenu()
        {
            string title = @"

.▄▄ · ▄• ▄▌ ▌ ▐·    ▄▄▄   ▄▄▄· ▄▄ • 
▐█ ▀. █▪██▌▪█·█▌    ▀▄ █·▐█ ▄█▐█ ▀ ▪
▄▀▀▀█▄█▌▐█▌▐█▐█•    ▐▀▀▄  ██▀·▄█ ▀█▄
▐█▄▪▐█▐█▄█▌ ███     ▐█•█▌▐█▪·•▐█▄▪▐█
 ▀▀▀▀  ▀▀▀ . ▀      .▀  ▀.▀   ·▀▀▀▀ 
                                                    
";

            string[] options = { "NEW GAME",
            "LOAD GAME",
            // "HALL OF FAME",
            "QUIT"};

            SoundPlayer Menuloop = new SoundPlayer(@"UI\Sound\Menuloop.wav");

            if (OperatingSystem.IsWindows())
            {           
                Menuloop.Load();
                Menuloop.PlayLooping();
            }

            Menu mainMenu = new Menu(title, options);
            int SelectedIndex = mainMenu.Run();
            switch (SelectedIndex)
            {
                case 0:
                    Game myGame = new Game();

                    myGame.GameLoop(CreateCharacter.RunIntro(), myGame.StartNewGame());
                    Menuloop.Stop();
                    break;

                case 1:
                    LoadGameUI loadUI = new();
                    loadUI.OpenLoadGameUI();
                    break;

                case 2:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}