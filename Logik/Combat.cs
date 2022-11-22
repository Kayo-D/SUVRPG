using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
using System.Media;

namespace SUVRPG
{
    public class Combat
    {
        public static Player CurrentPlayer;
        public static Character CurrentEnemy;
        private static List<Character> EnemiesAtLvl1;
        private static List<Character> EnemiesAtLvl2;
        private static List<Character> EnemiesAtLvl3;
        private static List<Character> EnemyBoss;
        
        public Combat()
        {
            Bandit lostBandit = new Bandit("Lost Adventurer", "Poor guy seems lost and confused. He thinks you're a monster!", 15, 0, ConsoleColor.DarkBlue);
            Spider bigSpider = new Spider ("Bigger-Than-Average Spider", "Size do matters when it comes to hideous disgusting spiders that are staring hungrily at you.", 10, 0, ConsoleColor.DarkGreen, false);
            Minotaur youngMinotaur = new Minotaur("Young Minotaur", "A minotaur is part man and part bull. Well, this one is more part teenager, part bull. 'It's not a phase, mooooh-m.'", 6, 3, ConsoleColor.Magenta);

            Spider poisonSpider = new Spider ("Poison Spider", "This one looks angry... And hungry.", 40, 10, ConsoleColor.DarkGreen, true);
            Bandit battleScarredBandit = new Bandit ("Battle-scarred Bandit", "You see what you assume are battle scars all over his face. This one must have been in a lot of fights!", 60, 15, ConsoleColor.DarkGray);
            Minotaur minotaurGuard = new Minotaur("Minotaur Guard", "These mythical creatures guard the treasure of the cave. Real beef cakes.", 70, 20, ConsoleColor.Red);


            Bandit banditLeader = new Bandit ("Bandit-Leader", "It takes a lof of strength to become the leader of such a hideous group of bandits", 100, 40, ConsoleColor.DarkYellow);
            Minotaur minotaurChampion = new Minotaur("Minotaur Champion", "The Minotaur Champion has served the Dragon Lord well and been given a special rank of Champion. No extra salary or benefits though. Some extra overtime required. They should perhaps be in touch with a muu-union.", 140, 60, ConsoleColor.DarkBlue);
            Spider giantSpider = new Spider ("Giant freakin' Spider", "It's a huge freakin' spider and he's about to smash you with all of his eight legs", 160, 60, ConsoleColor.DarkGreen, true);
            Dragon youngDragon = new Dragon ("Young Dragon", "When a mommy drake and daddy drake love each other very much, they hug very hard and, uhm, well, here it is.", 150, 70, ConsoleColor.DarkCyan);

            Dragon dragonLord = new Dragon ("Dragon Lord", "The guardian of the treasure. The final boss. Also known as 'OPie - the not-so-friendly dragon'", 500, 200, ConsoleColor.DarkCyan);

            EnemiesAtLvl1 = new List<Character>() { lostBandit, bigSpider, youngMinotaur };
            EnemiesAtLvl2 = new List<Character>() { poisonSpider, battleScarredBandit, minotaurGuard };
            EnemiesAtLvl3 = new List<Character>() { banditLeader, minotaurChampion, giantSpider };
            EnemyBoss = new List <Character>() { dragonLord };
        }

        public static void RunCombat(LevelManager manager)
        {
            SoundPlayer Battleloop = new SoundPlayer(@"UI\Sound\Battleloop.wav");

            if (OperatingSystem.IsWindows())
            {           
                Battleloop.Load();
                Battleloop.PlayLooping();
            }
            Clear();
            Random random = new Random();

            if (manager.currentLevel == 1)
            {
                int randomNumber = random.Next(0, EnemiesAtLvl1.Count);
                CurrentEnemy = EnemiesAtLvl1[randomNumber]; 
            }
            else if (manager.currentLevel == 2)
            {
                int randomNumber = random.Next(0, EnemiesAtLvl2.Count);
                CurrentEnemy = EnemiesAtLvl2[randomNumber]; 
            }
            else if (manager.currentLevel == 3)
            {
                int randomNumber = random.Next(0, EnemiesAtLvl3.Count);
                CurrentEnemy = EnemiesAtLvl3[randomNumber];   
            }
            
            CombatUI.IntroCurrentEnemy();
            BattleCurrentEnemy();

            if (CurrentPlayer.IsDead)
            {
                CombatUI.RunGameOver();
                Battleloop.Stop();
            }
            else
            {
                CombatUI.WonBattle();
                Battleloop.Stop();
            }
        }

        public void BattleFinalBoss()
        {
            Clear();
            Random random = new Random();

            CurrentEnemy = EnemyBoss[0];

            CombatUI.IntroCurrentEnemy();
            BattleCurrentEnemy();

            if (CurrentPlayer.IsDead)
            {
                CombatUI.RunGameOver();
            }
            else
            {
                CombatUI.YouWon();
            }
        }

        public static void BattleCurrentEnemy()
        {
            while (!CurrentPlayer.IsDead && !CurrentEnemy.IsDead)
            {
                Clear();
                CurrentPlayer.DisplayHealthBar();
                CurrentEnemy.DisplayHealthBar();

                CurrentPlayer.Fight(CurrentEnemy);

                if (CurrentPlayer.IsDead || CurrentEnemy.IsDead)
                {
                    CurrentEnemy.Health = CurrentEnemy.MaxHealth;
                    break;
                }

                CombatUI.WaitForKey();
                Clear();
                
                CurrentPlayer.DisplayHealthBar();
                CurrentEnemy.DisplayHealthBar();   

                CurrentEnemy.Fight(CurrentPlayer);
                
                CombatUI.WaitForKey();
            }
        }
    }
}