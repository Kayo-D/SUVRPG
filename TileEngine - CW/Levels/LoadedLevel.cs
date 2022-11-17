//Made by Christian Vallvingskog

public class LoadedLevel : Level
{
    public override string[,] mapData
    {
        get
        {
            return _mapData = new string[,] {};
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
            return _mapHeight;
        }
    }
    public override int mapWidth 
    {
        get
        {
            return _mapWidth;
        }
    }
}