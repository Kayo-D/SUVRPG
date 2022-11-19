//Made by Christian Vallvingskog

namespace SUVRPG
{
    public class LootHandler
    {
        //Make a AddLootToPlayer method in the Player class and call it here instead
        public Player PickupLootLevel1(LevelManager manager, TileEngine engine, Player CurrentPlayer, MapUI ui)
        {
            TreasureClass1 tc1 = new();
            TreasureClass2 tc2 = new();
            Random rng = new Random();
            Loot addLootToPlayer = new();
            if (rng.Next(10) > 8)
            {
                addLootToPlayer = tc2.LootTable();
            }
            else
            {
                addLootToPlayer = tc1.LootTable();
            }
            CurrentPlayer.Armor = addLootToPlayer.armor + CurrentPlayer.Armor;
            CurrentPlayer.AttackDmg = addLootToPlayer.weapon + CurrentPlayer.AttackDmg;
            CurrentPlayer.CurrentGold = addLootToPlayer.gold + CurrentPlayer.CurrentGold;
            ui.DrawPickups(addLootToPlayer);
            Console.ReadKey();
            return CurrentPlayer;
        }
        public Player PickupLootLevel2(LevelManager manager, TileEngine engine, Player CurrentPlayer, MapUI ui)
        {
            TreasureClass2 tc2 = new();
            TreasureClass3 tc3 = new();
            Random rng = new Random();
            Loot addLootToPlayer = new();
            if (rng.Next(10) > 8)
            {
                addLootToPlayer = tc3.LootTable();
            }
            else
            {
                addLootToPlayer = tc2.LootTable();
            }
            CurrentPlayer.Armor = addLootToPlayer.armor + CurrentPlayer.Armor;
            CurrentPlayer.AttackDmg = addLootToPlayer.weapon + CurrentPlayer.AttackDmg;
            CurrentPlayer.CurrentGold = addLootToPlayer.gold + CurrentPlayer.CurrentGold;
            ui.DrawPickups(addLootToPlayer);
            Console.ReadKey();
            return CurrentPlayer;
        }
        public Player PickupLootLevel3(LevelManager manager, TileEngine engine, Player CurrentPlayer, MapUI ui)
        {
            TreasureClass3 tc3 = new();
            Random rng = new Random();
            Loot addLootToPlayer = new();
            addLootToPlayer = tc3.LootTable();
            CurrentPlayer.Armor = addLootToPlayer.armor + CurrentPlayer.Armor;
            CurrentPlayer.AttackDmg = addLootToPlayer.weapon + CurrentPlayer.AttackDmg;
            CurrentPlayer.CurrentGold = addLootToPlayer.gold + CurrentPlayer.CurrentGold;
            ui.DrawPickups(addLootToPlayer);
            Console.ReadKey();
            return CurrentPlayer;
        }
    }
}