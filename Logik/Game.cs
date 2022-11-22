using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Media;

namespace SUVRPG
{
    class Game
    {
        public LevelManager StartNewGame()
        {
            LevelManager manager = new();
            manager.SelectLevel(1);
            return manager;
        }
        
        public bool IsPlayerOnCorrectLevel(LevelManager manager, int levelCheck)
        {
            if (manager.currentLevel != levelCheck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int LevelCheck(LevelManager manager, int levelCheck, TileEngine engine, MapUI mapUI, Player CurrentPlayer)
        {
            if (IsPlayerOnCorrectLevel(manager, levelCheck))
            {
                ChangeLevel(manager.currentLevel, manager, engine, mapUI, CurrentPlayer);
                levelCheck = levelCheck + 1;
            }
            return levelCheck;
        }

        public void ChangeLevel(int newLevel, LevelManager manager, TileEngine engine, MapUI mapUI, Player CurrentPlayer)
        {
            manager.SelectLevel(newLevel);
            engine.SpawnPlayer(manager.playerStartPosX, manager.playerStartPosY);
            mapUI.UILevelLoad(manager.levelData, manager.mapHeight, manager.mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, CurrentPlayer);
        }

        public void GameLoop(Player player, LevelManager manager)
        {
            TileEngine engine = new();
            MapUI mapUI = new();
            ConsoleKeyInfo keyInput = new();
            Shop shop = new();
            int levelCheck = manager.currentLevel;
            engine.SpawnPlayer(manager.playerStartPosX, manager.playerStartPosY);
            mapUI.UILevelLoad(manager.levelData, manager.mapHeight, manager.mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
            if (OperatingSystem.IsWindows())
                {           
                    SoundPlayer Caveloop = new SoundPlayer(@"UI\Sound\Caveloop.wav");
                    Caveloop.Load();
                    Caveloop.PlayLooping();
                }
            while (true)
            {
                Console.CursorVisible = false;
                keyInput = Console.ReadKey();
                mapUI.PlayerMovement(keyInput, manager.levelData, manager.mapWidth, manager.mapHeight, engine, player);
                mapUI.DrawPlayer(engine.currentPlayerPosX,engine.currentPlayerPosY);
                engine.TileEvents(manager, engine, player, mapUI);
                levelCheck = LevelCheck(manager, levelCheck, engine, mapUI,player);
                if (keyInput.Key == ConsoleKey.S)
                {
                    player = shop.StartShop(player);
                    mapUI.UILevelLoad(manager.levelData, manager.mapHeight, manager.mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
                }
                if (keyInput.Key == ConsoleKey.M)
                {
                    SaveGameUI saveGameUI = new();
                    saveGameUI.OpenSaveGameUI(player,manager,engine);
                    mapUI.UILevelLoad(manager.levelData, manager.mapHeight, manager.mapWidth, engine.currentPlayerPosX, engine.currentPlayerPosY, player);
                }
                if(keyInput.Key == ConsoleKey.Q)
                {
                    Environment.Exit(0);
                    break;
                }
            }
        }
    }
}