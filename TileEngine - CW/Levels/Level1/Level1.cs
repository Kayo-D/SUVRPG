public class Level1 : Level
{
    public override string[,] mapData
    {
        get
        {
            return _mapData = new string[,] {
        {"0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0,0,0"},
        {"0,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,2,0,0,0,1"}};
        }
    }
    public override int playerStartPosY
    {
        get
        {
            return _playerStartPosY = 0;
        }
    }
    public override int playerStartPosX
    {
        get
        {
            return _playerStartPosX = 0;
        }
    }
    public override int mapHeight 
    {
        get
        {
            return _playerStartPosY = 29;
        }
    }
    public override int mapWidth 
    {
        get
        {
            return _mapWidth = 23;
        }
    }
}