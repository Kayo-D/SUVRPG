//Made by Christian Vallvingskog

public class Shop
{
    ShopUI UI = new ShopUI();
    ConsoleKeyInfo keyInput;
    //Split this. Some should go to UI
    public Player StartShop(Player player)
    {
        while (true)
        {
            UI.DrawShopUI(player.currentGold, player.hitpoints, player.hitpointsMax);
            keyInput = Console.ReadKey();
            if (keyInput.Key == ConsoleKey.B)
            {
                if (CanPlayerAffordItem(player.currentGold, 25))
                {
                    if (IsPlayerAtMaxHitPoints(player.hitpoints, player.hitpointsMax) == false)
                    {
                        player.currentGold = SetPlayerGold(player.currentGold, 25);
                        player.hitpoints = BuyHealingPotion(player.currentGold, 25, player.hitpoints, player.hitpointsMax);
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
                return player;
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