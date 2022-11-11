public class TileEventManager
{
    LootHandler loot = new();
    public void EnemyTileEvent(LevelManager manager, TileEngine engine, Player player)
    {
        engine.ChangeTileID(manager.levelData, engine.currentPlayerPosY, engine.currentPlayerPosX, manager.mapWidth, "1");
    }
    public int ExitTileEvent(int currentLevel)
    {
        currentLevel = currentLevel + 1;
        return currentLevel;
    }
    public void LootTileEvent(LevelManager manager, TileEngine engine, Player player)
    {
        engine.ChangeTileID(manager.levelData, engine.currentPlayerPosY, engine.currentPlayerPosX, manager.mapWidth, "1");
        player = loot.PickupLoot(manager, engine, player);
    }
}