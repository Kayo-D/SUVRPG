//Made by Christian Vallvingskog

namespace SUVRPG
{
    public class TileEngine
    {
        TileEventManager tileEventManager = new();
        public int currentPlayerPosX;
        public int currentPlayerPosY;
        //Change from string[,] to int[,]
        public Tile SelectTile(string[,] levelData, int selectedTileYPos, int selectedTileXPos, int mapWidth)
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
                            int selectTileID = int.Parse(tempArray1[x]);
                            if(selectTileID == 0)
                            {
                                return new WallTile();
                            }
                            else if (selectTileID == 1)
                            {
                                return new FloorTile();
                            }
                            else if (selectTileID == 2)
                            {
                                return new DoorTile();
                            }
                            else if (selectTileID == 3)
                            {
                                return new EntryTile();
                            }
                            else if (selectTileID == 4)
                            {
                                return new LootTile();
                            }
                            else if (selectTileID == 5)
                            {
                                return new EnemyTile();
                            }
                            else if (selectTileID == 6)
                            {
                                return new ExitTile();
                            }
                            else if (selectTileID == 7)
                            {
                                return new BossTile();
                            }
                        }
                    }
                }
            }
            ErrorTile error = new();
            return error;
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
        public bool CanPlayerStandOnTile(Tile selectedTile)
        {
            if (selectedTile.canPlayerStandOnTile == true)
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
            Tile selectedTile = SelectTile(manager.levelData, currentPlayerPosY, currentPlayerPosX, manager.mapWidth);
            if (selectedTile.TileID == 4)
            {
                tileEventManager.LootTileEvent(manager, engine, player, ui);
                Console.Clear();
                ui.UILevelLoad(manager.levelData, manager.mapHeight, manager.mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
            }
            if (selectedTile.TileID == 5)
            {
                tileEventManager.EnemyTileEvent(manager, engine, player);
                Console.Clear();
                ui.UILevelLoad(manager.levelData, manager.mapHeight, manager.mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
            }
            if (selectedTile.TileID == 6)
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
}