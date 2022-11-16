public class TreasureClass3 : TreasureClass
{
    Random rng = new Random();
    public Loot LootTable()
    {
        Loot returnedLoot = new Loot();
        Loot[] lootTable = new Loot[10]
        {
        SackOfCoins(),
        SackOfCoins(),
        PilesOfCoins(),
        PilesOfCoins(),
        GoldHoard(),
        DoubleWeaponUp(),
        TripleWeaponUp(),
        DoubleArmorUp(),
        TripleArmorUp(),
        BigScore(),
        };
        returnedLoot = lootTable[rng.Next(10)];
        return returnedLoot;
    }
    public Loot SackOfCoins()
    {
        Loot loot = new();
        loot.gold = rng.Next(25) + 50;
        return loot;
    }
    public Loot PilesOfCoins()
    {
        Loot loot = new();
        loot.gold = rng.Next(150) + 150;
        return loot;
    }
    public Loot GoldHoard()
    {
        Loot loot = new();
        loot.gold = rng.Next(150) + 250;
        return loot;
    }
    public Loot DoubleArmorUp()
    {
        Loot loot = new();
        loot.armor = 2;
        return loot;
    }
    public Loot TripleArmorUp()
    {
        Loot loot = new();
        loot.armor = 3;
        return loot;
    }
    public Loot DoubleWeaponUp()
    {
        Loot loot = new();
        loot.weapon = 2;
        return loot;
    }
    public Loot TripleWeaponUp()
    {
        Loot loot = new();
        loot.weapon = 3;
        return loot;
    }
    public Loot BigScore()
    {
        Loot loot = new();
        loot.gold = loot.gold = rng.Next(150) + 250;
        loot.armor = loot.armor = 4;
        loot.weapon = loot.weapon = 4;
        return loot;
    }
}