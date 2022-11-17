//Made by Christian Vallvingskog

using static System.Console;
public class ShopUI
{
    public void DrawShopUI(int currentPlayerGold, int currentPlayerHP, int maxPlayerHP)
    {
        Clear();
        WriteLine("Current gold: " + currentPlayerGold);
        WriteLine("Current HP : " + currentPlayerHP + "/" + maxPlayerHP);
        WriteLine("Press B to buy a healing potion for 25 gold");
        WriteLine("The potion will restore 20HP");
        WriteLine("Press Q to go back");
    }
    public void DrawPlayerCantAffordUI()
    {
        Clear();
        WriteLine("You do not have enough gold for this purchase");
        WriteLine("Press any key to return");
    }
    public void DrawPlayerPurchaseUI(string itemBought)
    {
        Clear();
        WriteLine("Succesfully purchased a " + itemBought);
        WriteLine("Press any key to return");
    }
    public void DrawPlayerIsAlreadyMaxHP()
    {
        Clear();
        WriteLine("You are already at max hit points");
        WriteLine("Press any key to return");
    }
}