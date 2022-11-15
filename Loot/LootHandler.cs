public class LootHandler
{
    public Player PickupLootLevel1(LevelManager manager, TileEngine engine, Player player, MapUI ui)
    {
        TreasureClass1 tc1 = new();
        TreasureClass2 tc2 = new();
        Random rng = new Random();
        Loot addLootToPlayer = new();
        if(rng.Next(10) > 8)
        {
            addLootToPlayer = tc2.LootTable();
        }
        else
        {
            addLootToPlayer = tc1.LootTable();
        }
        player.armor = addLootToPlayer.armor + player.armor;
        player.attackdmg = addLootToPlayer.weapon + player.attackdmg;
        player.currentGold = addLootToPlayer.gold + player.currentGold;
        ui.DrawPickups(addLootToPlayer);
        Console.ReadKey();
        return player;
    }
    public Player PickupLootLevel2(LevelManager manager, TileEngine engine, Player player, MapUI ui)
    {
        TreasureClass1 tc1 = new();
        TreasureClass2 tc2 = new();
        Random rng = new Random();
        Loot addLootToPlayer = new();
        if(rng.Next(10) < 8)
        {
            addLootToPlayer = tc2.LootTable();
        }
        else
        {
            addLootToPlayer = tc1.LootTable();
        }
        player.armor = addLootToPlayer.armor + player.armor;
        player.attackdmg = addLootToPlayer.weapon + player.attackdmg;
        player.currentGold = addLootToPlayer.gold + player.currentGold;
        ui.DrawPickups(addLootToPlayer);
        Console.ReadKey();
        return player;
    }
}