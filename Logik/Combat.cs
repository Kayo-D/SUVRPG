using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace SUVRPG
{
    public class Combat
    {
        public static Player CurrentPlayer;
        public static Character CurrentEnemy;
        private static List<Character> Enemies;

        public Combat()
        {
            Dragon Drake1 = new Dragon("Dragon", "RaaaaawwwwwrRrrrR. 'ME BIG MEAN DRAGON'", 10, 0, ConsoleColor.Red);
            
            // Bandit lostBandit = new Bandit("Lost Adventurer", "Poor guy seems lost and confused. He thinks you're a monster!", 15, 0, ConsoleColor.DarkBlue);
            
            Enemies = new List<Character>() { Drake1 };
        }

        public static void RunCombat()
        {
            Clear();
            CurrentEnemy = Enemies[0]; 
            CombatUI.IntroCurrentEnemy();
            BattleCurrentEnemy();

            if (CurrentPlayer.IsDead)
            {
                CombatUI.RunGameOver();
            }
            else
            {
                // Loota något?
                WriteLine($"You defeated {CurrentEnemy.Name}! ");
                Game.WaitForKey();
            }
            
        }

        public static void BattleCurrentEnemy()
        {
            while (CurrentPlayer.IsAlive && CurrentEnemy.IsAlive)
            {
                Clear();
                CurrentPlayer.DisplayHealthBar();
                CurrentEnemy.DisplayHealthBar();
                WriteLine();

                CurrentPlayer.Fight(CurrentEnemy);

                if (CurrentPlayer.IsDead || CurrentEnemy.IsDead)
                {
                    CurrentEnemy.Health = CurrentEnemy.MaxHealth;
                    break;
                }

                WriteLine();                
                Game.WaitForKey();

                Clear();
                CurrentPlayer.DisplayHealthBar();
                CurrentEnemy.DisplayHealthBar();
                WriteLine();

                CurrentEnemy.Fight(CurrentPlayer);
                
                Game.WaitForKey();
            }
        }
    }
}