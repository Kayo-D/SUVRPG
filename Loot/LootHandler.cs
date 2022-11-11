public class LootHandler
{
    //Testar bara med gold först
    public Player PickupLoot(LevelManager manager, TileEngine engine, Player player)
    {
        //Kolla vilken treasureclass vi kan välja på vilket beror på level

        //Randomiza en loot table med de treasure classes som är relevanta
        
        //Returnera spelaren
        //Testa gold pickup
        player.currentGold = player.currentGold + 5;
        return player;
    }
}