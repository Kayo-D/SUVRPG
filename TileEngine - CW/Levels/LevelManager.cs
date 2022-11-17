//Made by Christian Vallvingskog

public class LevelManager
{
    public int playerStartPosX;
    public int playerStartPosY;
    public int mapWidth;
    public int mapHeight;
    public int currentLevel;
    public string[,] levelData = new string[,] { };
    public void SelectLevel(int levelID)
    {
        if (levelID == 1)
        {
            Level1 lvl1 = new Level1();
            levelData = lvl1.mapData;
            playerStartPosX = lvl1.playerStartPosX;
            playerStartPosY = lvl1.playerStartPosY;
            mapWidth = lvl1.mapWidth;
            mapHeight = lvl1.mapHeight;
            currentLevel = 1;
        }
        if (levelID == 2)
        {
            Level2 lvl2 = new Level2();
            levelData = lvl2.mapData;
            playerStartPosX = lvl2.playerStartPosX;
            playerStartPosY = lvl2.playerStartPosY;
            mapWidth = lvl2.mapWidth;
            mapHeight = lvl2.mapHeight;
            currentLevel = 2;
        }
        if (levelID == 3)
        {
            Level3 lvl3 = new Level3();
            levelData = lvl3.mapData;
            playerStartPosX = lvl3.playerStartPosX;
            playerStartPosY = lvl3.playerStartPosY;
            mapWidth = lvl3.mapWidth;
            mapHeight = lvl3.mapHeight;
            currentLevel = 3;
        }
    }
    //Get level from database
    public LevelManager LoadLevel(/* DB database */)
    {
        LevelManager manager = new();
        //manager.leveldata = database.GetLevelData();
        return manager;
    }
}