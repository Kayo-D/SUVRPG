public class Shop
{
    ShopUI UI = new ShopUI();
    ConsoleKeyInfo keyInput;
    public void StartShop(int currentPlayerGold, int currentPlayerHP, int maxPlayerHP)
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
                }
            }
            if (keyInput.Key == ConsoleKey.Escape)
            {
                return;
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