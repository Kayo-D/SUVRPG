using static System.Console;

namespace SUVRPG
{
    public class CombatUI
    {
        public void StartFight()
        {
            WriteLine("Fight is starting!");
        }

        public void CombatScreen()
        {

        }

        // Denna ligger just nu i Character men ska ligga här sen.
        // public void DisplayHealthBar()
        // {
        //     Character Character = new Character();
            
        //     ForegroundColor = Character.color;
        //     WriteLine($"{Character.name}'s Health:");
        //     ResetColor();
        //     Write("[");
        //     BackgroundColor = ConsoleColor.Green;
        //     for (int i = 0; i < Character.hitpoints; i++)
        //     {
        //         Write(" ");
        //     }
        //     BackgroundColor = ConsoleColor.Black;
        //     for (int i = Character.hitpoints; i < Character.maxhitpoints; i++)
        //     {
        //         Write (" ");
        //     }
        //     ResetColor();
        //     WriteLine($"] {Character.hitpoints}/{Character.maxhitpoints}");
            
        // }

        public void YouWinScreen()
        {

        }

        public void YouLoseScreen()
        {

        }
    }
}