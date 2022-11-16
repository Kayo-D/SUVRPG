namespace SUVRPG
{
    public class GameMechanics
    {
        
        public void StartGameTest()
        {
            TileEngine engine = new TileEngine();
            Player player = new Player("Simon", 20, ConsoleColor.Green, 0, 0); // Ta bort detta sen 
            Shop shop = new Shop();
            LevelManager manager = new LevelManager();
            ConsoleKeyInfo keyInput = new ConsoleKeyInfo();
            MapUI mapUI = new MapUI();
            manager.SelectLevel(1);
            int levelCheck = manager.currentLevel;
            player.currentGold = 0;
            player.hitpoints = 30;
            player.hitpointsMax = 30;
            engine.SpawnPlayer(manager.playerStartPosX, manager.playerStartPosY);
            Console.Clear();
            mapUI.UILevelLoad(manager.levelData, manager.mapHeight, manager.mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
            while (true)
            {
                keyInput = Console.ReadKey();
                engine.PlayerMovement(keyInput, manager.levelData, manager.mapWidth);
                engine.TileEvents(manager, engine, player, mapUI);
                if (manager.currentLevel != levelCheck)
                {
                    manager.SelectLevel(manager.currentLevel);
                    engine.SpawnPlayer(manager.playerStartPosX, manager.playerStartPosY);
                    levelCheck = levelCheck + 1;
                    Console.Clear();
                    mapUI.UILevelLoad(manager.levelData, manager.mapHeight, manager.mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
                }
                if (keyInput.Key == ConsoleKey.S)
                {
                    player = shop.StartShop(player);
                    Console.Clear();
                    mapUI.UILevelLoad(manager.levelData, manager.mapHeight, manager.mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
                }
                mapUI.UIPlayerUpdate(manager.levelData, manager.mapHeight, manager.mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
            }
        }
    }
}

