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
            WriteLine($"A new enemy approaches!\n");
            ResetColor();
            Combat.CurrentEnemy.DisplayInfo();
            WriteLine();
            Game.WaitForKey();
        }

        public static void WonBattle()
        {
            WriteLine(@$"Good job, {Combat.CurrentPlayer.Name}, you have bested the enemy. Now, if only the developers had time to implement loot..\n");
            Game.WaitForKey();
        }
        
        public static void RunGameOver()
        {
            Clear();
            if (Combat.CurrentPlayer.IsDead)
            {
                WriteLine(@$"Alas! {Combat.CurrentPlayer.Name}, you have met a sad fate. \n

This game was made by Christian, Isabella & Simon. Thank you for playing! \n");

            Game.WaitForKey();
            MainMenu.Mainmenu();
            }
        }
    }


}