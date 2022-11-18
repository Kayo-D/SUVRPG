//Made by Christian Vallvingskog

public abstract class Level
{
    protected string[,] _mapData = new string[,] { };
    protected int _playerStartPosX;
    protected int _playerStartPosY;
    protected int _mapWidth;
    protected int _mapHeight;
    protected int _currentLevel;
    public abstract string[,] mapData { get; }
    public abstract int playerStartPosX { get; }
    public abstract int playerStartPosY { get; }
    public abstract int mapWidth { get; }
    public abstract int mapHeight { get; }
    public abstract int currentLevel { get; }
}