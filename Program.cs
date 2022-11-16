namespace SUVRPG
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Vill ni testköra kod så gör det inom dessa kommentarer. Se till att ta bort allt inom dem innan ni pushar
            //Testa inom dessa

            Combat combat = new Combat();
            combat.CreateEnemy();
            combat.CurrentEnemy.DisplayInfo();
            

            //Testa inom dessa
            
            
            // MainMenu.Mainmenu();
        }
    }
}