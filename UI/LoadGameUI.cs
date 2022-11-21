using static System.Console;
namespace SUVRPG
{
    public class LoadGameUI
    {
        public void OpenLoadGameUI()
        {
            Clear();
            WriteLine("In order to load game search for your characters name. Write Q in order to go back.");
            SearchForLoadGame();
        }
        public void SearchForLoadGame()
        {
            //DB db = new();
            string input;
            Player player = new("", "", 0, 0, 0, ConsoleColor.Black);
            LoadedLevel loadedLevel = new();
            while (player.Name == "")
            {
                input = ReadLine();
                //player = db.LoadPlayer(input);
                //loadedLevel = db.LoadLevelMap(input);
                if (input.ToLower() == "q")
                {
                    break;
                }
                if (player.Name == "")
                {
                    WriteLine("Search didn't match anything in the database. Are you sure you entered correctly?");
                }
            }
        }
    }
}