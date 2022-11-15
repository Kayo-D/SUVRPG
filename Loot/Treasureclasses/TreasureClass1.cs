public class TreasureClass1 : TreasureClass
{
    Random rng = new Random();
    public Loot LootTable()
    {
        Loot returnedLoot = new Loot();
        Loot[] lootTable = new Loot[10]
        {
        FewCoins(),
        FewCoins(),
        FewCoins(),
        PouchOfCoins(),
        PouchOfCoins(),
        WeaponUp(),
        WeaponUp(),
        ArmorUp(),
        ArmorUp(),
        BigScore(),
        };
        returnedLoot = lootTable[rng.Next(10)];
        return returnedLoot;
    }
    public Loot FewCoins()
    {
        Loot loot = new();
        loot.gold = rng.Next(5) + 1;
        return loot;
    }
    public Loot PouchOfCoins()
    {
        Loot loot = new();
        loot.gold = rng.Next(10) + 15;
        return loot;
    }
    public Loot ArmorUp()
    {
        Loot loot = new();
        loot.armor = 1;
        return loot;
    }
    public Loot WeaponUp()
    {
        Loot loot = new();
        loot.weapon = 1;
        return loot;
    }
    public Loot BigScore()
    {
        Loot loot = new();
        loot = PouchOfCoins();
        loot = ArmorUp();
        loot = WeaponUp();
        return loot;
    }
}