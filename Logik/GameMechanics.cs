namespace SUVRPG
{
    public class GameMechanics
    {
        public void StartGameTest()
        {
            TileEngine engine = new TileEngine();
            Player player = new Player();
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


        private List<Enemy> Enemies;

        public void EnemyTest()
        {
            // Enemy enemy = new Enemy("", 0, 0, 0, 0, 0);
            // enemy.CreateEnemy();
            // enemy.EnemyInfo();
            Console.Clear();

            Dragon dragonlord = new Dragon("Dragonlord", 200, 10, 30, 60, 5);
            Bandit bandit = new Bandit("Bandit", 20, 0, 2, 5, 2);

            Enemies = new List<Enemy>() { dragonlord, bandit };

            foreach (Enemy enemy in Enemies)
            {
                System.Console.WriteLine(Enemies.Count);
                enemy.EnemyInfo();
            }

        }



    }
}

