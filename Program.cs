namespace SUVRPG
{
    internal class Program
    {

        private static void Main(string[] args)
        {     

              //Testa inom dessa
            DB db = new();
            Player player = new("Izza","Elf","Likes IKEA", 30, 26, 25, 14, 6, ConsoleColor.Black);
            db.SavePlayer(player);
            //Testa inom dessa 

        //   MainMenu.Mainmenu();
        }
    }
}