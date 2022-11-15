public class TreasureClass2 : TreasureClass
{
    Random rng = new Random();
    public Loot LootTable()
    {
        Loot returnedLoot = new Loot();
        Loot[] lootTable = new Loot[10]
        {
        PouchOfCoins(),
        PouchOfCoins(),
        PouchOfCoins(),
        SackOfCoins(),
        SackOfCoins(),
        WeaponUp(),
        DoubleWeaponUp(),
        ArmorUp(),
        DoubleArmorUp(),
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
    public Loot SackOfCoins()
    {
        Loot loot = new();
        loot.gold = rng.Next(25) + 50;
        return loot;
    }
    public Loot ArmorUp()
    {
        Loot loot = new();
        loot.armor = 1;
        return loot;
    }
    public Loot DoubleArmorUp()
    {
        Loot loot = new();
        loot.armor = 2;
        return loot;
    }
    public Loot WeaponUp()
    {
        Loot loot = new();
        loot.weapon = 1;
        return loot;
    }
    public Loot DoubleWeaponUp()
    {
        Loot loot = new();
        loot.weapon = 2;
        return loot;
    }
    public Loot BigScore()
    {
        Loot loot = new();
        loot.gold = loot.gold = rng.Next(25) + 50;
        loot.armor = loot.armor = 2;
        loot.weapon = loot.weapon = 2;
        return loot;
    }
}