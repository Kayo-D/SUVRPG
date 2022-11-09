public class LevelManager
{
    public int playerStartPosX;
    public int playerStartPosY;
    public int mapWidth;
    public int mapHeight;
    public string[,] levelData = new string[,] {};
    public void SelectLevel(int levelID)
    {
        if(levelID == 1)
        {
            Level1 lvl1 = new Level1();
            levelData = lvl1.mapData;
            playerStartPosX = lvl1.playerStartPosX;
            playerStartPosY = lvl1.playerStartPosY;
            mapWidth = lvl1.mapWidth;
            mapHeight = lvl1.mapHeight;
        }
        if(levelID == 2)
        {

        }
        if(levelID == 3)
        {

        }
    }
}