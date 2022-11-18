//Made by Christian Vallvingskog

public class LoadedLevel : Level
{
    public override string[,] mapData
    {
        get
        {
            return _mapData = new string[,] { };
        }
    }
    public override int playerStartPosY
    {
        get
        {
            return _playerStartPosY;
        }
    }
    public override int playerStartPosX
    {
        get
        {
            return _playerStartPosX;
        }
    }
    public override int mapHeight
    {
        get
        {
            return _mapHeight = 29;
        }
    }
    public override int mapWidth
    {
        get
        {
            return _mapWidth = 23;
        }
    }
    public override int currentLevel
    {
        get
        {
            return _currentLevel;
        }
    }
}