public class TileEventManager
{
    LootHandler loot = new();
    public void EnemyTileEvent(LevelManager manager, TileEngine engine, MapUI mapUI)
    {
        engine.ChangeTileID(manager.levelData, engine.currentPlayerPosY, engine.currentPlayerPosX, manager.mapWidth, "1");
    }
    public int ExitTileEvent(int currentLevel)
    {
        currentLevel = currentLevel + 1;
        return currentLevel;
    }
    public void LootTileEvent(LevelManager manager, TileEngine engine, MapUI mapUI)
    {
        engine.ChangeTileID(manager.levelData, engine.currentPlayerPosY, engine.currentPlayerPosX, manager.mapWidth, "1");
        mapUI.currentPlayerGold = loot.PickupLoot(manager, engine, mapUI.currentPlayerGold) + mapUI.currentPlayerGold;
    }
}