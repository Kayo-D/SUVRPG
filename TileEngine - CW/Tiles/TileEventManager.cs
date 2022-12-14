//Made by Christian Vallvingskog
using System.Media;

namespace SUVRPG
{
    public class TileEventManager
    {
        LootHandler loot = new();
        
        public void EnemyTileEvent(LevelManager manager, TileEngine engine, Player player)
        {
            Combat combat = new Combat();
            engine.ChangeTileID(manager.levelData, engine.currentPlayerPosY, engine.currentPlayerPosX, manager.mapWidth, "1");
            Combat.RunCombat(manager);
            if (OperatingSystem.IsWindows())
                {           
                    SoundPlayer Caveloop = new SoundPlayer(@"UI\Sound\Caveloop.wav");
                    Caveloop.Load();
                    Caveloop.PlayLooping();
                }
        }
        public void BossTileEvent(LevelManager manager, TileEngine engine, Player player)
        {
            Combat combat = new Combat();
            engine.ChangeTileID(manager.levelData, engine.currentPlayerPosY, engine.currentPlayerPosX, manager.mapWidth, "1");
            combat.BattleFinalBoss();
                if (OperatingSystem.IsWindows())
                {           
                    SoundPlayer Caveloop = new SoundPlayer(@"UI\Sound\Caveloop.wav");
                    Caveloop.Load();
                    Caveloop.PlayLooping();
                }
        }
        public int ExitTileEvent(int currentLevel)
        {
            currentLevel = currentLevel + 1;
            return currentLevel;
        }
        public void LootTileEvent(LevelManager manager, TileEngine engine, Player player, MapUI ui)
        {
            engine.ChangeTileID(manager.levelData, engine.currentPlayerPosY, engine.currentPlayerPosX, manager.mapWidth, "1");
            if (manager.currentLevel == 1)
            {
                player = loot.PickupLootLevel1(manager, engine, player, ui);
            }
            else if (manager.currentLevel == 2)
            {
                player = loot.PickupLootLevel2(manager, engine, player, ui);
            }
            else if (manager.currentLevel == 3)
            {
                player = loot.PickupLootLevel3(manager, engine, player, ui);
            }
        }
    }
}