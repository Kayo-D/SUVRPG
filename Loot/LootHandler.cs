public class LootHandler
{
    public Player PickupLoot(LevelManager manager, TileEngine engine, Player player, MapUI ui)
    {
        TreasureClass1 tc = new();
        Loot addLootToPlayer = new();
        addLootToPlayer = tc.LootTable();
        player.armor = addLootToPlayer.armor + player.armor;
        player.attackdmg = addLootToPlayer.weapon + player.attackdmg;
        player.currentGold = addLootToPlayer.gold + player.currentGold;
        ui.DrawPickups(addLootToPlayer);
        Console.ReadKey();
        return player;
    }
}