//Made by Christian Vallvingskog

namespace SUVRPG
{
    public class Shop
    {
        ShopUI UI = new ShopUI();
        ConsoleKeyInfo keyInput;
        //Split this. Some should go to UI
        public Player StartShop(Player CurrentPlayer)
        {
            while (true)
            {
                UI.DrawShopUI(CurrentPlayer.CurrentGold, CurrentPlayer.Health, CurrentPlayer.MaxHealth);
                keyInput = Console.ReadKey();
                if (keyInput.Key == ConsoleKey.B)
                {
                    if (CanPlayerAffordItem(CurrentPlayer.CurrentGold, 25))
                    {
                        if (IsPlayerAtMaxHitPoints(CurrentPlayer.Health, CurrentPlayer.MaxHealth) == false)
                        {
                            CurrentPlayer.CurrentGold = SetPlayerGold(CurrentPlayer.CurrentGold, 25);
                            CurrentPlayer.Health = BuyHealingPotion(CurrentPlayer.CurrentGold, 25, CurrentPlayer.Health, CurrentPlayer.MaxHealth);
                            UI.DrawPlayerPurchaseUI("healing potion");
                            Console.ReadKey();
                        }
                        else
                        {
                            UI.DrawPlayerIsAlreadyMaxHP();
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        UI.DrawPlayerCantAffordUI();
                        Console.ReadKey();
                    }
                }
                if (keyInput.Key == ConsoleKey.Q)
                {
                    return CurrentPlayer;
                }
            }
        }
        public int BuyHealingPotion(int currentPlayerGold, int cost, int currentPlayerHP, int maxPlayerHP)
        {
            if (currentPlayerHP <= maxPlayerHP)
            {
                currentPlayerHP = currentPlayerHP + 20;
                if (currentPlayerHP > maxPlayerHP)
                {
                    currentPlayerHP = maxPlayerHP;
                }
            }
            return currentPlayerHP;
        }
        //This should be in the Player class
        public int SetPlayerGold(int currentPlayerGold, int cost)
        {
            currentPlayerGold = currentPlayerGold - cost;
            return currentPlayerGold;
        }
        //This should be in the Player class
        public bool CanPlayerAffordItem(int currentPlayerGold, int cost)
        {
            if (currentPlayerGold >= cost)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //This should be in the Player class
        public bool IsPlayerAtMaxHitPoints(int currentPlayerHP, int maxPlayerHP)
        {
            if (currentPlayerHP == maxPlayerHP)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}