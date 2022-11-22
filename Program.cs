namespace SUVRPG
{
    internal class Program
    {
        private static void Main(string[] args)
        {     

            //Testa inom dessa

            DB dB = new DB();
            dB.LoadLevelMap(dB.LoadPlayer("Belle"));
            
            //Testa inom dessa 

            //MainMenu.Mainmenu();

        }
    }
}