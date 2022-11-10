public class Shop
{
    ShopUI UI = new ShopUI();
    ConsoleKeyInfo keyInput;
    //Skicka in Player class här istället, skicka tillbaka player class när man ska tillbaka till spelet.
    //Temporärt skickar jag tillbaka gold så jag kan hantera loot
    public int StartShop(int currentPlayerGold, int currentPlayerHP, int maxPlayerHP)
    {
        while (true)
        {
            UI.DrawShopUI(currentPlayerGold, currentPlayerHP, maxPlayerHP);
            keyInput = Console.ReadKey();
            if (keyInput.Key == ConsoleKey.B)
            {
                if (CanPlayerAffordItem(currentPlayerGold, 25))
                {
                    currentPlayerGold = SetPlayerGold(currentPlayerGold, 25);
                    currentPlayerHP = BuyHealingPotion(currentPlayerGold, 25, currentPlayerHP, maxPlayerHP);
                    UI.DrawPlayerPurchaseUI("healing potion");
                    Console.ReadKey();
                }
                else
                {
                    UI.DrawPlayerCantAffordUI();
                    Console.ReadKey();
                }
            }
            if (keyInput.Key == ConsoleKey.Q)
            {
                //Skicka tillbaka Player class här med ändringarna gjorda
                return currentPlayerGold;
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
    public int SetPlayerGold(int currentPlayerGold, int cost)
    {
        currentPlayerGold = currentPlayerGold - cost;
        return currentPlayerGold;
    }
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
}