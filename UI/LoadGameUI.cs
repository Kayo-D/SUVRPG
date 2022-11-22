using static System.Console;
namespace SUVRPG
{
    public class LoadGameUI
    {
        public void OpenLoadGameUI()
        {
            Clear();
            WriteLine("In order to load game search for your characters name. Write Q in order to go back.");
            SearchForLoadGame();
        }
        public void SearchForLoadGame()
        {
            DB db = new();
            string input;
            LoadedLevel loadedLevel = new();
            while (true)
            {
                input = ReadLine();
                SUVRPG.Player player = db.LoadPlayer(input);
                if (input.ToLower() == "q")
                {
                    break;
                }
                if (player.Name == "")
                {
                    WriteLine("Search didn't match anything in the database. Are you sure you entered correctly?");
                }
                else if (player.Name == input)
                {
                    WriteLine("Found player! Press any key to enter game.");
                    Console.ReadKey();
                    Game game = new();
                    LevelManager manager = new();
                    loadedLevel = db.LoadLevelMap(player);
                    manager.currentLevel = loadedLevel.currentLevel;
                    manager.levelData = loadedLevel.level;
                    manager.mapHeight = loadedLevel.mapHeight;
                    manager.mapWidth = loadedLevel.mapWidth;
                    manager.playerStartPosX = loadedLevel.playerStartPosX;
                    manager.playerStartPosY = loadedLevel.playerStartPosY;
                    Combat.CurrentPlayer = player;
                    game.GameLoop(player, manager);
                }
            }
        }
    }
}