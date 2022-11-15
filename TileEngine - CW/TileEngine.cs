public class TileEngine
{
    TileEventManager tileEventManager = new();
    public int currentPlayerPosX;
    public int currentPlayerPosY;
    public int SelectTile(string[,] levelData, int selectedTileYPos, int selectedTileXPos, int mapWidth)
    {
        string xAxis;
        int selectedTileID;
        for (int y = 0; y < levelData.Length; y++)
        {
            xAxis = levelData[y, 0];
            for (int j = 0; j < mapWidth; j++)
            {
                string[] tempArray1 = new string[xAxis.Length];
                tempArray1 = xAxis.Split(",").ToArray();
                for (int x = 0; x < tempArray1.Length; x++)
                {
                    if (y == selectedTileYPos && x == selectedTileXPos)
                    {
                        selectedTileID = int.Parse(tempArray1[x]);
                        return selectedTileID;
                    }
                }
            }
        }
        return 0;
    }
    public string[,] ChangeTileID(string[,] levelData, int selectedTileYPos, int selectedTileXPos, int mapWidth, string newTileID)
    {
        string xAxis;
        for (int y = 0; y < levelData.Length; y++)
        {
            xAxis = levelData[y, 0];
            for (int j = 0; j < mapWidth; j++)
            {
                string[] tempArray1 = new string[xAxis.Length];
                tempArray1 = xAxis.Split(",").ToArray();
                for (int x = 0; x < tempArray1.Length; x++)
                {
                    if (y == selectedTileYPos && x == selectedTileXPos)
                    {
                        tempArray1[x] = newTileID;
                        xAxis = string.Join(",", tempArray1);
                        levelData[y, 0] = xAxis;
                        return levelData;
                    }
                }
            }
        }
        return levelData;
    }
    public bool CanPlayerStandOnTile(int selectedTileID)
    {
        if (selectedTileID == 1 || selectedTileID == 2 || selectedTileID == 4 || selectedTileID == 5 || selectedTileID == 6)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void TileEvents(LevelManager manager, TileEngine engine, Player player, MapUI ui)
    {
        int currenTileID = SelectTile(manager.levelData, currentPlayerPosY, currentPlayerPosX, manager.mapWidth);
        if (currenTileID == new LootTile().TileID)
        {
            tileEventManager.LootTileEvent(manager, engine, player, ui);
            Console.Clear();
            ui.UILevelLoad(manager.levelData, manager.mapHeight, manager.mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
        }
        if (currenTileID == new EnemyTile().TileID)
        {
            tileEventManager.EnemyTileEvent(manager, engine, player);
            Console.Clear();
            ui.UILevelLoad(manager.levelData, manager.mapHeight, manager.mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
        }
        if (currenTileID == new ExitTile().TileID)
        {
            manager.currentLevel = tileEventManager.ExitTileEvent(manager.currentLevel);
            Console.Clear();
        }
    }
    public void SpawnPlayer(int playerStartPosX, int playerStartPosY)
    {
        currentPlayerPosX = playerStartPosX;
        currentPlayerPosY = playerStartPosY;
    }
    public void PlayerMovement(ConsoleKeyInfo keyInput, string[,] currentLevelData, int mapWidth)
    {
        int collisionDetector;
        switch (keyInput.Key)
        {
            case ConsoleKey.UpArrow:
                collisionDetector = currentPlayerPosY - 1;
                if (CanPlayerStandOnTile(SelectTile(currentLevelData, collisionDetector, currentPlayerPosX, mapWidth)))
                {
                    currentPlayerPosY = currentPlayerPosY - 1;
                }
                break;
            case ConsoleKey.LeftArrow:
                collisionDetector = currentPlayerPosX - 1;
                if (CanPlayerStandOnTile(SelectTile(currentLevelData, currentPlayerPosY, collisionDetector, mapWidth)))
                {
                    currentPlayerPosX = currentPlayerPosX - 1;
                }
                break;
            case ConsoleKey.RightArrow:
                collisionDetector = currentPlayerPosX + 1;
                if (CanPlayerStandOnTile(SelectTile(currentLevelData, currentPlayerPosY, collisionDetector, mapWidth)))
                {
                    currentPlayerPosX = currentPlayerPosX + 1;
                }
                break;
            case ConsoleKey.DownArrow:
                collisionDetector = currentPlayerPosY + 1;
                if (CanPlayerStandOnTile(SelectTile(currentLevelData, collisionDetector, currentPlayerPosX, mapWidth)))
                {
                    currentPlayerPosY = currentPlayerPosY + 1;
                }
                break;
            default:
                break;
        }
    }
}