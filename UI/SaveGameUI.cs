using static System.Console;
namespace SUVRPG
{
    public class SaveGameUI
    {
        DB db = new();
        public void OpenSaveGameUI(Player player, LevelManager manager, TileEngine engine)
        {
            Clear();
            //Make this into a single transaction
            db.SavePlayer(player);
            db.SaveLevelMap(player.Name,manager.levelData,engine,manager.currentLevel);
            WriteLine("Succesfully saved game");
            WriteLine("In order to load game search for your characters name: " + player.Name);
            WriteLine("Press any key to go back");
            ReadKey();
        }
    }
}