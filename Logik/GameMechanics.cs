namespace SUVRPG
{
    public class GameMechanics
    {
        public LevelManager StartNewGame()
        {
            LevelManager manager = new();
            manager.SelectLevel(1);
            return manager;
        }
        public Player CreateNewCharacter()
        {
            CharacterUI playerUI = new();
            Player player = new();
            return player = playerUI.characterCreation();
        }
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
        public int GoToNextLevel(LevelManager manager, int levelCheck, TileEngine engine, MapUI mapUI, Player player)
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
            int levelCheck = manager.currentLevel;
            engine.SpawnPlayer(manager.playerStartPosX, manager.playerStartPosY);
            mapUI.UILevelLoad(manager.levelData, manager.mapHeight, manager.mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
            while (true)
            {
                keyInput = Console.ReadKey();
                engine.PlayerMovement(keyInput, manager.levelData, manager.mapWidth);
                engine.TileEvents(manager, engine, player, mapUI);
                levelCheck = GoToNextLevel(manager, levelCheck, engine, mapUI,player);
                if (keyInput.Key == ConsoleKey.S)
                {
                    player = shop.StartShop(player);
                    mapUI.UILevelLoad(manager.levelData, manager.mapHeight, manager.mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
                }
                mapUI.UIPlayerUpdate(manager.levelData, manager.mapHeight, manager.mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
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

