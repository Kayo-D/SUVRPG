using static System.Console;
public class ShopUI
{
    public void DrawShopUI(int currentPlayerGold, int currentPlayerHP, int maxPlayerHP)
    {
        Clear();
        WriteLine("Current gold: " + currentPlayerGold + " ");
        WriteLine("Current HP : " + currentPlayerHP + "/" + maxPlayerHP);
        WriteLine("Press B to buy a healing potion for 25 gold");
        WriteLine("The potion will restore 20HP");
        WriteLine("Press ESC to go back");
    }
}