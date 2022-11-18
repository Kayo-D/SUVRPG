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
        Console.SetCursorPosition(currentPlayerPosX * 2, currentPlayerPosY);
        BackgroundColor = ConsoleColor.White;
        Write("🚶");
        BackgroundColor = ConsoleColor.Black;
    }
    public void ClearPlayerFromMap(string[,] levelData, int mapHeight, int mapWidth, int currentPlayerPosX, int currentPlayerPosY, Player player)
    {
        Console.SetCursorPosition(currentPlayerPosX * 2, currentPlayerPosY);
        //Make a method for this
        if (tileEngine.SelectTile(levelData, currentPlayerPosY, currentPlayerPosY, mapWidth).TileID == 0)
        {
            DrawWallTile();
        }
        else if (tileEngine.SelectTile(levelData, currentPlayerPosY, currentPlayerPosX, mapWidth).TileID == 1)
        {
            DrawFloorTile();
        }
        else if (tileEngine.SelectTile(levelData, currentPlayerPosY, currentPlayerPosX, mapWidth).TileID == 2)
        {
            DrawDoorTile();
        }
        else if (tileEngine.SelectTile(levelData, currentPlayerPosY, currentPlayerPosX, mapWidth).TileID == 3)
        {
            DrawEntryTile();
        }
        else if (tileEngine.SelectTile(levelData, currentPlayerPosY, currentPlayerPosX, mapWidth).TileID == 4)
        {
            DrawLootTile();
        }
        else if (tileEngine.SelectTile(levelData, currentPlayerPosY, currentPlayerPosX, mapWidth).TileID == 5)
        {
            DrawEnemyTile();
        }
        else if (tileEngine.SelectTile(levelData, currentPlayerPosY, currentPlayerPosX, mapWidth).TileID == 6)
        {
            DrawExitTile();
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
                //Make a method for this
                if (tileEngine.SelectTile(levelData, i, j, mapWidth).TileID == 0)
                {
                    DrawWallTile();
                }
                if (tileEngine.SelectTile(levelData, i, j, mapWidth).TileID == 1)
                {
                    DrawFloorTile();
                }
                if (tileEngine.SelectTile(levelData, i, j, mapWidth).TileID == 2)
                {
                    DrawDoorTile();
                }
                if (tileEngine.SelectTile(levelData, i, j, mapWidth).TileID == 3)
                {
                    DrawEntryTile();
                }
                if (tileEngine.SelectTile(levelData, i, j, mapWidth).TileID == 4)
                {
                    DrawLootTile();
                }
                if (tileEngine.SelectTile(levelData, i, j, mapWidth).TileID == 5)
                {
                    DrawEnemyTile();
                }
                if (tileEngine.SelectTile(levelData, i, j, mapWidth).TileID == 6)
                {
                    DrawExitTile();
                }
                if (tileEngine.SelectTile(levelData, i, j, mapWidth).TileID == 7)
                {
                    DrawBossTile();
                }
            }
            WriteLine("");
        }
        DrawPlayer(currentPlayerPosX, currentPlayerPosY);
        Console.SetCursorPosition(0, mapHeight);
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
    //Move collisiondetection into its own method
    public void PlayerMovement(ConsoleKeyInfo keyInput, string[,] currentLevelData, int mapWidth, int mapHeight, TileEngine engine, Player player)
    {
        int collisionDetector;
        switch (keyInput.Key)
        {
            case ConsoleKey.UpArrow:
                collisionDetector = engine.currentPlayerPosY - 1;
                if (engine.CanPlayerStandOnTile(engine.SelectTile(currentLevelData, collisionDetector, engine.currentPlayerPosX, mapWidth)))
                {
                    ClearPlayerFromMap(currentLevelData, mapHeight, mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
                    engine = MovePlayerUp(engine);
                }
                break;
            case ConsoleKey.LeftArrow:
                collisionDetector = engine.currentPlayerPosX - 1;
                if (engine.CanPlayerStandOnTile(engine.SelectTile(currentLevelData, engine.currentPlayerPosY, collisionDetector, mapWidth)))
                {
                    ClearPlayerFromMap(currentLevelData, mapHeight, mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
                    engine = MovePlayerLeft(engine);
                }
                break;
            case ConsoleKey.RightArrow:
                collisionDetector = engine.currentPlayerPosX + 1;
                if (engine.CanPlayerStandOnTile(engine.SelectTile(currentLevelData, engine.currentPlayerPosY, collisionDetector, mapWidth)))
                {
                    ClearPlayerFromMap(currentLevelData, mapHeight, mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
                    engine = MovePlayerRight(engine);
                }
                break;
            case ConsoleKey.DownArrow:
                collisionDetector = engine.currentPlayerPosY + 1;
                if (engine.CanPlayerStandOnTile(engine.SelectTile(currentLevelData, collisionDetector, engine.currentPlayerPosX, mapWidth)))
                {
                    ClearPlayerFromMap(currentLevelData, mapHeight, mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
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