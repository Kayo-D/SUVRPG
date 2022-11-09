namespace SUVRPG
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Vill ni testköra kod så gör det inom dessa kommentarer. Se till att ta bort allt inom dem innan ni pushar
            //Testa inom dessa
            TileEngine engine = new TileEngine();
            MapUI mapui = new MapUI();
            LevelManager manager = new LevelManager();
            ConsoleKeyInfo keyInput = new ConsoleKeyInfo();
            manager.SelectLevel(1);
            engine.SpawnPlayer(manager.playerStartPosX, manager.playerStartPosY);
            mapui.UILevelUpdate(manager.levelData, manager.mapHeight, manager.mapWidth,engine.currentPlayerPosX,engine.currentPlayerPosY);
            while (true)
            {
                keyInput = Console.ReadKey();
                engine.PlayerMovement(keyInput, manager.levelData, manager.mapWidth);
                mapui.UILevelUpdate(manager.levelData, manager.mapHeight, manager.mapWidth,engine.currentPlayerPosX,engine.currentPlayerPosY);
            }
            //Testa inom dessa
            //Gör detta till en metod i MenuUI. Kalla på den direkt här istället MVH Christian
            string title = "Welcome to SUVRPG!\n";

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
                    Environment.Exit(0);
                    break;
            }

        }
    }
}