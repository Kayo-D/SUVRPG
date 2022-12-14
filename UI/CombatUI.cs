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
            CombatUI.WaitForKey();
        }

        public static void WonBattle()
        {
            WriteLine(@$"Good job, {Combat.CurrentPlayer.Name}, you have bested the enemy. Now, if only the developers had time to implement loot..
            
            ");
            CombatUI.WaitForKey();
        }

        public static void RunGameOver()
        {
            Clear();
            if (Combat.CurrentPlayer.IsDead)
            {
                WriteLine(@$"Alas! {Combat.CurrentPlayer.Name}, you have met a sad fate. 


This game was made by Christian, Isabell & Simon. Thank you for playing! 

");

            CombatUI.WaitForKey();
            MainMenu.Mainmenu();
            }
        }

        public static void YouWon()
        {
            Clear();
            WriteLine("Congratulations! You have slayed the beast and stolen the treasure!");
        }

        public static void WaitForKey()
        {
            WriteLine("Press any key to continue...\n");
            ReadKey(true);
        }
    }


}