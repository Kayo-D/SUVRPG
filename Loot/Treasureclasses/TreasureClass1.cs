public class TreasureClass1 : TreasureClass
{
    Random rng = new Random();
    public Loot LootTable()
    {
        Loot returnedLoot = new Loot();
        int[] lootTable = new int[10];
        int fewCoins = FewCoins();
        int pouchOfCoins = PouchOfCoins();
        int armorUp = 1;
        int weaponUp = 1;
        

        returnedLoot.armor = 0;
        returnedLoot.weapon = 0;
        returnedLoot.gold = 0;
        return returnedLoot;
    }
    public int FewCoins()
    {
        int random = rng.Next(5) + 1;
        return random;
    }
    public int PouchOfCoins()
    {
        int random = rng.Next(10) + 15;
        return random;
    }
}