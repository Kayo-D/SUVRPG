public class TileEngine
{
    public LevelManager currentLevel = new LevelManager();
    public int currentPlayerPosX;
    public int currentPlayerPosY;
    public int SelectTile(string[,] levelData, int selectedTileYPos, int selectedTileXPos, int mapWidth)
    {
        string xAxis;
        int selectedTileID;
        for (int i = 0; i < levelData.Length; i++)
        {
            xAxis = levelData[i, 0];
            for (int j = 0; j < mapWidth; j++)
            {
                string[] tempArray1 = new string[xAxis.Length];
                tempArray1 = xAxis.Split(",").ToArray();
                for (int k = 0; k < tempArray1.Length; k++)
                {
                    if (i == selectedTileYPos && k == selectedTileXPos)
                    {
                        selectedTileID = int.Parse(tempArray1[k]);
                        if (selectedTileID == 0)
                        {
                            return 0;
                        }
                        if (selectedTileID == 1)
                        {
                            return 1;
                        }
                    }
                }
            }
        }
        return 0;
    }
    public bool CanPlayerStandOnTile(int selectedTileID)
    {
        if (selectedTileID == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void SpawnPlayer(int playerStartPosX, int playerStartPosY)
    {
        currentPlayerPosX = playerStartPosX;
        currentPlayerPosY = playerStartPosY;
    }
    public void PlayerPositionUpdate(ConsoleKeyInfo keyInput)
    {
        int collisionDetector;
        switch (keyInput.Key)
        {
            case ConsoleKey.UpArrow:
                collisionDetector = currentPlayerPosY - 1;
                if (CanPlayerStandOnTile(SelectTile(currentLevel.levelData, collisionDetector, currentPlayerPosX, currentLevel.mapWidth)))
                {
                    currentPlayerPosY = currentPlayerPosY - 1;
                    break;
                }
                break;
            case ConsoleKey.LeftArrow:
                collisionDetector = currentPlayerPosX - 1;
                if (CanPlayerStandOnTile(SelectTile(currentLevel.levelData, currentPlayerPosY, collisionDetector, currentLevel.mapWidth)))
                {
                    currentPlayerPosX = currentPlayerPosX - 1;
                    break;
                }
                break;
            case ConsoleKey.RightArrow:
                collisionDetector = currentPlayerPosX + 1;
                if (CanPlayerStandOnTile(SelectTile(currentLevel.levelData, currentPlayerPosY, collisionDetector, currentLevel.mapWidth)))
                {
                    currentPlayerPosX = currentPlayerPosX + 1;
                    break;
                }
                break;
            case ConsoleKey.DownArrow:
                collisionDetector = currentPlayerPosY + 1;
                if (CanPlayerStandOnTile(SelectTile(currentLevel.levelData, collisionDetector, currentPlayerPosX, currentLevel.mapWidth)))
                {
                    currentPlayerPosY = currentPlayerPosY + 1;
                    break;
                }
                break;
            default:
                break;
        }
    }
}