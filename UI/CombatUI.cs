using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace SUVRPG
{
    public static class CombatUI
    {
        public static void IntroCurrentEnemy()
        {
            ForegroundColor = Combat.CurrentEnemy.Color;
            WriteLine($"A new enemy approaches!");
            ResetColor();
            Combat.CurrentEnemy.DisplayInfo();
            WriteLine();
            Game.WaitForKey();
        }
        public static void RunGameOver()
        {
            Clear();
            if (Combat.CurrentPlayer.IsDead)
            {
                WriteLine(@$"Alas! {Combat.CurrentPlayer.Name}, you have met a sad fate. ");
            }

            WriteLine("Thanks for playing!");
        

            Game.WaitForKey();
            MainMenu.Mainmenu();

        }
    }


}