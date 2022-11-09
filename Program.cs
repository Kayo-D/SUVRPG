namespace SUVRPG
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Vill ni testköra kod så gör det inom dessa kommentarer. Se till att ta bort allt inom dem innan ni pushar
            //Testa inom dessa

            //Testa inom dessa
            //Gör detta till en metod i MenuUI. Kalla på den direkt här istället MVH Christian
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