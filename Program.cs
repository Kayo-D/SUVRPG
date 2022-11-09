namespace SUVRPG
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Gör detta till en metod i UI. Kalla på den direkt här istället MVH Christian
            string title = "Welcome to SUVRPG!\n";
            
            string[] options = { "NEW GAME", 
            "LOAD GAME", 
            "HIGHSCORE", 
            "QUIT"
            };

            Menu mainMenu = new Menu(title, options);
            int SelectedIndex = mainMenu.Run();

            switch (SelectedIndex)
            {
                case 0:
                    break;
                
                case 1:
                    break;
                
                case 2:
                    break;

                case 3:
                    Environment.Exit(0);
                    break;
            }

        }
    }
}