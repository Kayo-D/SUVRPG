//Made by Christian Vallvingskog

public class TileEngine
{
    TileEventManager tileEventManager = new();
    public int currentPlayerPosX;
    public int currentPlayerPosY;
    //Change from string[,] to int[,]
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
    //Change from string[,] to int[,]
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
    //Use a bool on the tiles for this function instead.
    public bool CanPlayerStandOnTile(int selectedTileID)
    {
        if (selectedTileID == new FloorTile().TileID || selectedTileID == new DoorTile().TileID || selectedTileID == new LootTile().TileID || selectedTileID == new EnemyTile().TileID || selectedTileID == new ExitTile().TileID || selectedTileID == new BossTile().TileID)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //Change so it doesn't make a new tile just to get the TileID
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
}