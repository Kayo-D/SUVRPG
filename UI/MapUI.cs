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
    public void DrawBossTile()
    {
        BackgroundColor = ConsoleColor.Red;
        Write("🐲");
        BackgroundColor = ConsoleColor.Black;
    }
    public void DrawLootTile()
    {
        BackgroundColor = ConsoleColor.Yellow;
        Write("💸");
        BackgroundColor = ConsoleColor.Black;
    }
    public void DrawPlayer(int currentPlayerPosX, int currentPlayerPosY)
    {
        Console.SetCursorPosition(currentPlayerPosX * 2 + 2, currentPlayerPosY);
        BackgroundColor = ConsoleColor.White;
        Write("\b\b🚶");
        BackgroundColor = ConsoleColor.Black;
    }
    public void ClearPlayerFromMap(string[,] levelData, int mapHeight, int mapWidth, int currentPlayerPosX, int currentPlayerPosY, Player player)
    {
        Console.SetCursorPosition(currentPlayerPosX * 2 + 2, currentPlayerPosY);
        //Make a method for this
        if (tileEngine.SelectTile(levelData, currentPlayerPosX, currentPlayerPosY, mapWidth) == new WallTile().TileID)
        {
            DrawWallTile();
        }
        if (tileEngine.SelectTile(levelData, currentPlayerPosX, currentPlayerPosY, mapWidth) == new FloorTile().TileID)
        {
            DrawFloorTile();
        }
        if (tileEngine.SelectTile(levelData, currentPlayerPosX, currentPlayerPosY, mapWidth) == new DoorTile().TileID)
        {
            DrawDoorTile();
        }
        if (tileEngine.SelectTile(levelData, currentPlayerPosX, currentPlayerPosY, mapWidth) == new EntryTile().TileID)
        {
            DrawEntryTile();
        }
        if (tileEngine.SelectTile(levelData, currentPlayerPosX, currentPlayerPosY, mapWidth) == new ExitTile().TileID)
        {
            DrawExitTile();
        }
        if (tileEngine.SelectTile(levelData, currentPlayerPosX, currentPlayerPosY, mapWidth) == new EnemyTile().TileID)
        {
            DrawEnemyTile();
        }
        if (tileEngine.SelectTile(levelData, currentPlayerPosX, currentPlayerPosY, mapWidth) == new LootTile().TileID)
        {
            DrawLootTile();
        }
    }
    public void UILevelLoad(string[,] levelData, int mapHeight, int mapWidth, int currentPlayerPosX, int currentPlayerPosY, Player player)
    {
        Console.Clear();
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        for (int i = 0; i < mapHeight; i++)
        {
            for (int j = 0; j < mapWidth; j++)
            {
                //Fix so it doesn't create a new tile just to get the TileID
                //Make a method for this
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
                if (tileEngine.SelectTile(levelData, i, j, mapWidth) == new BossTile().TileID)
                {
                    DrawBossTile();
                }
                if (currentPlayerPosY == i && currentPlayerPosX == j)
                {
                    DrawPlayer(currentPlayerPosX, currentPlayerPosY);
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
        WriteLine("You have : " + player.currentGold + " gold. Your hitpoints are : " + player.hitpoints + "/" + player.maxhitpoints + ". You have a +" + player.attackdmg + " weapon and a +" + player.armor + " armor,");
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
    public void UIPlayerUpdate(string[,] levelData, int mapHeight, int mapWidth, int currentPlayerPosX, int currentPlayerPosY, Player player)
    {
        Console.CursorVisible = false;
        Console.SetCursorPosition(0, currentPlayerPosY - 1);
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < mapWidth; j++)
            {
                //Make a method for this
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
                if (tileEngine.SelectTile(levelData, currentPlayerPosY - 1 + i, j, mapWidth) == new BossTile().TileID)
                {
                    DrawBossTile();
                }
            }
            WriteLine("");
        }
        DrawPlayer(currentPlayerPosX, currentPlayerPosY);
    }
    //Move collisiondetection into its own method
    public void PlayerMovement(ConsoleKeyInfo keyInput, string[,] currentLevelData, int mapWidth, int mapHeight, TileEngine engine, Player player)
    {
        int collisionDetector;
        ClearPlayerFromMap(currentLevelData, mapHeight, mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
        switch (keyInput.Key)
        {
            case ConsoleKey.UpArrow:
                collisionDetector = engine.currentPlayerPosY - 1;
                if (engine.CanPlayerStandOnTile(engine.SelectTile(currentLevelData, collisionDetector, engine.currentPlayerPosX, mapWidth)))
                {
                    engine = MovePlayerUp(engine);
                }
                break;
            case ConsoleKey.LeftArrow:
                collisionDetector = engine.currentPlayerPosX - 1;
                if (engine.CanPlayerStandOnTile(engine.SelectTile(currentLevelData, engine.currentPlayerPosY, collisionDetector, mapWidth)))
                {
                    engine = MovePlayerLeft(engine);
                }
                break;
            case ConsoleKey.RightArrow:
                collisionDetector = engine.currentPlayerPosX + 1;
                if (engine.CanPlayerStandOnTile(engine.SelectTile(currentLevelData, engine.currentPlayerPosY, collisionDetector, mapWidth)))
                {
                    engine = MovePlayerRight(engine);
                }
                break;
            case ConsoleKey.DownArrow:
                collisionDetector = engine.currentPlayerPosY + 1;
                if (engine.CanPlayerStandOnTile(engine.SelectTile(currentLevelData, collisionDetector, engine.currentPlayerPosX, mapWidth)))
                {
                    engine = MovePlayerDown(engine);
                }
                break;
            default:
                break;
        }
    }
    public TileEngine MovePlayerUp(TileEngine engine)
    {
        engine.currentPlayerPosY = engine.currentPlayerPosY - 1;
        return engine;
    }
    public TileEngine MovePlayerLeft(TileEngine engine)
    {
        engine.currentPlayerPosX = engine.currentPlayerPosX - 1;
        return engine;
    }
    public TileEngine MovePlayerRight(TileEngine engine)
    {
        engine.currentPlayerPosX = engine.currentPlayerPosX + 1;
        return engine;
    }
    public TileEngine MovePlayerDown(TileEngine engine)
    {
        engine.currentPlayerPosY = engine.currentPlayerPosY + 1;
        return engine;
    }
}