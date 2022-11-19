using static System.Console;
namespace SUVRPG
{
    public class SaveGameUI
    {
        public void OpenSaveGameUI(Player player)
        {
            Clear();
            WriteLine("Succesfully saved game");
            WriteLine("In order to load game search for your characters name: " + player.Name);
            WriteLine("Press any key to go back");
            ReadKey();
        }
    }
}