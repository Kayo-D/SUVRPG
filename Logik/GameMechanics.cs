namespace SUVRPG
{
    public class GameMechanics
    {
        public static Player CurrentPlayer;

        public LevelManager StartNewGame()
        {
            LevelManager manager = new();
            manager.SelectLevel(1);
            return manager;
        }
        public LevelManager LoadGame()
        {
            LevelManager manager = new();
            manager = manager.LoadLevel();
            return manager;
        }
        // public Player CreateNewCharacter(string name, string race, string characterDescription)
        // {
        //     Player player = new(name, race, characterDescription, 30, ConsoleColor.Green, 0, 0);
        //     return player;
        // }

        // Get player from database
        // public Player LoadCharacter(/* DB database */)
        // {
        //     Player player = new();
        //     player = database.GetPlayerData();
        //     return player;
        // }

        public bool IsPlayerOnCorrectLevel(LevelManager manager, int levelCheck)
        {
            if (manager.currentLevel != levelCheck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int LevelCheck(LevelManager manager, int levelCheck, TileEngine engine, MapUI mapUI, Player player)
        {
            if (IsPlayerOnCorrectLevel(manager, levelCheck))
            {
                ChangeLevel(manager.currentLevel, manager, engine, mapUI, player);
                levelCheck = levelCheck + 1;
            }
            return levelCheck;
        }
        public void GameLoop(Player player, LevelManager manager)
        {
            TileEngine engine = new();
            MapUI mapUI = new();
            ConsoleKeyInfo keyInput = new();
            Shop shop = new();
            // DB db = new();
            int levelCheck = manager.currentLevel;
            engine.SpawnPlayer(manager.playerStartPosX, manager.playerStartPosY);
            mapUI.UILevelLoad(manager.levelData, manager.mapHeight, manager.mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
            while (true)
            {
                Console.CursorVisible = false;
                keyInput = Console.ReadKey();
                mapUI.PlayerMovement(keyInput, manager.levelData, manager.mapWidth, manager.mapHeight, engine, player);
                mapUI.DrawPlayer(engine.currentPlayerPosX,engine.currentPlayerPosY);
                engine.TileEvents(manager, engine, player, mapUI);
                levelCheck = LevelCheck(manager, levelCheck, engine, mapUI,player);
                if (keyInput.Key == ConsoleKey.S)
                {
                    player = shop.StartShop(player);
                    mapUI.UILevelLoad(manager.levelData, manager.mapHeight, manager.mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
                }
                if (keyInput.Key == ConsoleKey.M)
                {
                    //SaveGameUI saveGameUI = new();
                    //db.SavePlayer(player);
                    //db.SaveLevelMap();
                    //saveGameUI.OpenSaveGameUI();
                }
                if(keyInput.Key == ConsoleKey.Q)
                {
                    return;
                }
            }
        }
        public void ChangeLevel(int newLevel, LevelManager manager, TileEngine engine, MapUI mapUI, Player player)
        {
            manager.SelectLevel(newLevel);
            engine.SpawnPlayer(manager.playerStartPosX, manager.playerStartPosY);
            mapUI.UILevelLoad(manager.levelData, manager.mapHeight, manager.mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
        }
    }
}

