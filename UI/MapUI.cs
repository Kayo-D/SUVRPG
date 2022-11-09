using static System.Console;
public class MapUI
{
    TileEngine tileEngine = new TileEngine();
    LevelManager manager = new LevelManager();
    public void UILevelUpdate(string[,] levelData, int mapHeight, int mapWidth, int currentPlayerPosX, int currentPlayerPosY)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Clear();
        for (int i = 0; i < mapHeight; i++)
        {
            for (int j = 0; j < mapWidth; j++)
            {
                if (tileEngine.SelectTile(levelData, i, j, mapWidth) == new WallTile().TileID)
                {
                    BackgroundColor = ConsoleColor.DarkGray;
                    Write("  ");
                }
                if (tileEngine.SelectTile(levelData, i, j, mapWidth) == new FloorTile().TileID)
                {
                    if (currentPlayerPosY == i && currentPlayerPosX == j)
                    {
                        BackgroundColor = ConsoleColor.White;
                        Write("🚶");
                    }
                    else
                    {
                        BackgroundColor = ConsoleColor.White;
                        Write("  ");
                    }
                }
                if (tileEngine.SelectTile(levelData, i, j, mapWidth) == new ExitTile().TileID)
                {
                    BackgroundColor = ConsoleColor.Blue;
                    Write("🚪");
                }
            }
            WriteLine("");
        }
        BackgroundColor = ConsoleColor.Black;
    }
}