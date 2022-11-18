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
            currentLevel = lvl1.currentLevel;
        }
        if (levelID == 2)
        {
            Level2 lvl2 = new Level2();
            levelData = lvl2.mapData;
            playerStartPosX = lvl2.playerStartPosX;
            playerStartPosY = lvl2.playerStartPosY;
            mapWidth = lvl2.mapWidth;
            mapHeight = lvl2.mapHeight;
            currentLevel = lvl2.currentLevel;
        }
        if (levelID == 3)
        {
            Level3 lvl3 = new Level3();
            levelData = lvl3.mapData;
            playerStartPosX = lvl3.playerStartPosX;
            playerStartPosY = lvl3.playerStartPosY;
            mapWidth = lvl3.mapWidth;
            mapHeight = lvl3.mapHeight;
            currentLevel = lvl3.currentLevel;
        }
        if (levelID == 4)
        {
            LoadedLevel loadlvl = new LoadedLevel();
            levelData = loadlvl.mapData;
            playerStartPosX = loadlvl.playerStartPosX;
            playerStartPosY = loadlvl.playerStartPosY;
            mapWidth = loadlvl.mapWidth;
            mapHeight = loadlvl.mapHeight;
            currentLevel = loadlvl.currentLevel;
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