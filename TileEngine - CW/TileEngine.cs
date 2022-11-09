public class TileEngine
{
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
                        xAxis = string.Join(",",tempArray1);
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
    public bool ShouldWeMovePlayerToNewLevel(int selectedTileID)
    {
        if (selectedTileID == 6)
        {
            return true;
        }
        return false;
    }
    public void TileEvent(string[,] levelData, int currentPlayerPosY, int currentPlayerPosX, int mapWidth)
    {
        int currenTileID = SelectTile(levelData, currentPlayerPosY, currentPlayerPosX, mapWidth);
        if (currenTileID == 4 || currenTileID == 5 || currenTileID == 6)
        {
            ChangeTileID(levelData, currentPlayerPosY, currentPlayerPosX, mapWidth, "1");
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