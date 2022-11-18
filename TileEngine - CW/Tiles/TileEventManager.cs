//Made by Christian Vallvingskog

public class TileEventManager
{
    LootHandler loot = new();
    
    public void EnemyTileEvent(LevelManager manager, TileEngine engine, Player player)
    {
        SUVRPG.Combat combat = new();
        engine.ChangeTileID(manager.levelData, engine.currentPlayerPosY, engine.currentPlayerPosX, manager.mapWidth, "1");
        combat.StartCombat(player, manager);
    }
    public void BossTileEvent(LevelManager manager, TileEngine engine, Player player)
    {
        SUVRPG.Combat combat = new();
        engine.ChangeTileID(manager.levelData, engine.currentPlayerPosY, engine.currentPlayerPosX, manager.mapWidth, "1");
        //combat.StartCombat(player, manager);
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