using static System.Console;
public class MapUI
{
    TileEngine tileEngine = new TileEngine();
    LevelManager manager = new LevelManager();
    public void UILevelUpdate()
    {
        Clear();
        for (int i = 0; i < manager.mapHeight; i++)
        {
            for (int j = 0; j < manager.mapWidth; j++)
            {
                if (tileEngine.SelectTile(manager.levelData, i, j, manager.mapWidth) == new WallTile().TileID)
                {
                    BackgroundColor = ConsoleColor.DarkGray;
                    Write("  ");
                }
                if (tileEngine.SelectTile(manager.levelData, i, j, manager.mapWidth) == new FloorTile().TileID)
                {
                    if (tileEngine.currentPlayerPosY == i && tileEngine.currentPlayerPosX == j)
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
                if (tileEngine.SelectTile(manager.levelData, i, j, manager.mapWidth) == new ExitTile().TileID)
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