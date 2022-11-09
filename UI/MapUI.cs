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
                    BackgroundColor = ConsoleColor.White;
                    Write("  ");
                }
                if (tileEngine.SelectTile(levelData, i, j, mapWidth) == new DoorTile().TileID)
                {
                    BackgroundColor = ConsoleColor.DarkGray;
                    Write("🚪");
                }
                if (tileEngine.SelectTile(levelData, i, j, mapWidth) == new EntryTile().TileID)
                {
                    BackgroundColor = ConsoleColor.Blue;
                    Write("🚪");
                }
                if (tileEngine.SelectTile(levelData, i, j, mapWidth) == new ExitTile().TileID)
                {
                    BackgroundColor = ConsoleColor.Green;
                    Write("🚪");
                }
                if (tileEngine.SelectTile(levelData, i, j, mapWidth) == new EnemyTile().TileID)
                {
                    BackgroundColor = ConsoleColor.Red;
                    Write("☠ ");
                }
                if (tileEngine.SelectTile(levelData, i, j, mapWidth) == new LootTile().TileID)
                {
                    BackgroundColor = ConsoleColor.Yellow;
                    Write("💸");
                }
                if (currentPlayerPosY == i && currentPlayerPosX == j)
                {
                    BackgroundColor = ConsoleColor.White;
                    Write("\b\b🚶");
                }
            }
            WriteLine("");
        }
        BackgroundColor = ConsoleColor.Black;
    }
}