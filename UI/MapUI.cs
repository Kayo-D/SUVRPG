using static System.Console;
public class MapUI
{
    TileEngine tileEngine = new TileEngine();
    LevelManager manager = new LevelManager();
    public void UILevelUpdate(string[,] levelData, int mapHeight, int mapWidth, int currentPlayerPosX, int currentPlayerPosY, Player player)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //Kommer behöva flytta denna clear ifall vi vill ha text ovanför kartan.
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
        WriteLine("");
        DrawShopButton();
        DrawCharacterInfo(player);
    }
    public void DrawShopButton()
    {
        WriteLine("Press S to enter the shop");
    }
    public void DrawCharacterInfo(Player player)
    {
        WriteLine("You have : " + player.currentGold + " gold. Your hitpoints are : " + player.hitpoints + "/" + player.hitpointsMax);
    }
    public void DrawPickups(Loot loot)
    {
        Clear();
        WriteLine("You picked up : " + loot.gold + " gold, +" + loot.weapon + " weapon +" + loot.armor + " armor.");
        WriteLine("Press any key to continue");
    }
}