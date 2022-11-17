//Made by Christian Vallvingskog

using static System.Console;
public class MapUI
{
    TileEngine tileEngine = new TileEngine();
    LevelManager manager = new LevelManager();
    //Should maybe place all DrawTile functions in their respective Tile class
    public void DrawWallTile()
    {
        BackgroundColor = ConsoleColor.DarkGray;
        Write("  ");
        BackgroundColor = ConsoleColor.Black;
    }
    public void DrawFloorTile()
    {
        BackgroundColor = ConsoleColor.White;
        Write("  ");
        BackgroundColor = ConsoleColor.Black;
    }
    public void DrawDoorTile()
    {
        BackgroundColor = ConsoleColor.DarkGray;
        Write("🚪");
        BackgroundColor = ConsoleColor.Black;
    }
    public void DrawEntryTile()
    {
        BackgroundColor = ConsoleColor.Blue;
        Write("🚪");
        BackgroundColor = ConsoleColor.Black;
    }
    public void DrawExitTile()
    {
        BackgroundColor = ConsoleColor.Green;
        Write("🚪");
        BackgroundColor = ConsoleColor.Black;
    }
    public void DrawEnemyTile()
    {
        BackgroundColor = ConsoleColor.Red;
        Write("☠ ");
        BackgroundColor = ConsoleColor.Black;
    }
    public void DrawLootTile()
    {
        BackgroundColor = ConsoleColor.Yellow;
        Write("💸");
        BackgroundColor = ConsoleColor.Black;
    }
    public void DrawPlayer()
    {
        BackgroundColor = ConsoleColor.White;
        Write("\b\b🚶");
        BackgroundColor = ConsoleColor.Black;
    }
    public void UILevelLoad(string[,] levelData, int mapHeight, int mapWidth, int currentPlayerPosX, int currentPlayerPosY, Player player)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        for (int i = 0; i < mapHeight; i++)
        {
            for (int j = 0; j < mapWidth; j++)
            {
                //Fix so it doesn't create a new tile just to get the TileID
                if (tileEngine.SelectTile(levelData, i, j, mapWidth) == new WallTile().TileID)
                {
                    DrawWallTile();
                }
                if (tileEngine.SelectTile(levelData, i, j, mapWidth) == new FloorTile().TileID)
                {
                    DrawFloorTile();
                }
                if (tileEngine.SelectTile(levelData, i, j, mapWidth) == new DoorTile().TileID)
                {
                    DrawDoorTile();
                }
                if (tileEngine.SelectTile(levelData, i, j, mapWidth) == new EntryTile().TileID)
                {
                    DrawEntryTile();
                }
                if (tileEngine.SelectTile(levelData, i, j, mapWidth) == new ExitTile().TileID)
                {
                    DrawExitTile();
                }
                if (tileEngine.SelectTile(levelData, i, j, mapWidth) == new EnemyTile().TileID)
                {
                    DrawEnemyTile();
                }
                if (tileEngine.SelectTile(levelData, i, j, mapWidth) == new LootTile().TileID)
                {
                    DrawLootTile();
                }
                if (currentPlayerPosY == i && currentPlayerPosX == j)
                {
                    DrawPlayer();
                }
            }
            WriteLine("");
        }
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
        WriteLine("You have : " + player.currentGold + " gold. Your hitpoints are : " + player.hitpoints + "/" + player.hitpointsMax + ". You have a +" + player.attackdmg + " weapon and a +" + player.armor + " armor,");
    }
    public void DrawPickups(Loot loot)
    {
        Clear();
        if (loot.gold != 0 && loot.armor != 0 && loot.weapon != 0)
        {
            WriteLine("You scored big! Found : " + loot.gold + " gold, +" + loot.weapon + " weapon and +" + loot.armor + " armor.");
        }
        //These next two else if are not currently in use. Keep them for new/altered loot
        else if (loot.gold != 0 && loot.armor != 0)
        {
            WriteLine("You found : " + loot.gold + " gold and +" + loot.armor + " armor.");
        }
        else if (loot.gold != 0 && loot.weapon != 0)
        {
            WriteLine("You found : " + loot.gold + " gold and +" + loot.weapon + " weapon.");
        }
        else if (loot.armor != 0)
        {
            WriteLine("You found : +" + loot.armor + " armor.");
        }
        else if (loot.weapon != 0)
        {
            WriteLine("You found : +" + loot.weapon + " weapon.");
        }
        else if (loot.gold != 0)
        {
            WriteLine("You found : " + loot.gold + " gold");
        }
        WriteLine("Press any key to continue");
    }
    //Will turn obsolete with an updated UIPlayerUpdate
    public void ClearConsoleAroundPlayer(int currentPlayerPosY)
    {
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, currentPlayerPosY - 1);
        Console.Write(new string(' ', Console.BufferWidth));
        Console.SetCursorPosition(0, currentPlayerPosY);
        Console.Write(new string(' ', Console.BufferWidth));
        Console.SetCursorPosition(0, currentPlayerPosY + 1);
        Console.Write(new string(' ', Console.BufferWidth));
        Console.SetCursorPosition(0, currentLineCursor);
    }
    //Turn it into two methods. One that removes playerIcon from the map. One that adds playerIcon to the map
    public void UIPlayerUpdate(string[,] levelData, int mapHeight, int mapWidth, int currentPlayerPosX, int currentPlayerPosY, Player player)
    {
        Console.CursorVisible = false;
        ClearConsoleAroundPlayer(currentPlayerPosY);
        Console.SetCursorPosition(0, currentPlayerPosY - 1);
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < mapWidth; j++)
            {
                if (tileEngine.SelectTile(levelData, currentPlayerPosY - 1 + i, j, mapWidth) == new WallTile().TileID)
                {
                    DrawWallTile();
                }
                if (tileEngine.SelectTile(levelData, currentPlayerPosY - 1 + i, j, mapWidth) == new FloorTile().TileID)
                {
                    DrawFloorTile();
                }
                if (tileEngine.SelectTile(levelData, currentPlayerPosY - 1 + i, j, mapWidth) == new DoorTile().TileID)
                {
                    DrawDoorTile();
                }
                if (tileEngine.SelectTile(levelData, currentPlayerPosY - 1 + i, j, mapWidth) == new EntryTile().TileID)
                {
                    DrawEntryTile();
                }
                if (tileEngine.SelectTile(levelData, currentPlayerPosY - 1 + i, j, mapWidth) == new ExitTile().TileID)
                {
                    DrawExitTile();
                }
                if (tileEngine.SelectTile(levelData, currentPlayerPosY - 1 + i, j, mapWidth) == new EnemyTile().TileID)
                {
                    DrawEnemyTile();
                }
                if (tileEngine.SelectTile(levelData, currentPlayerPosY - 1 + i, j, mapWidth) == new LootTile().TileID)
                {
                    DrawLootTile();
                }
            }
            WriteLine("");
        }
        Console.SetCursorPosition(currentPlayerPosX * 2 + 2, currentPlayerPosY);
        DrawPlayer();
    }
}