using static System.Console;

namespace SUVRPG
{
    public class Combat
    {
        private List<Character> EnemiesLvl1;
        private List<Character> EnemiesLvl2;
        private List<Character> EnemiesLvl3;
        private List<Character> EnemiesLvl4;
        public CombatUI CombatUI = new();
        private Character CurrentEnemy;
        public Random RandGenerator { get; set; }


        public void CreateEnemy()
        {
            
            // Level 1 enemies
            Bandit lostBandit = new Bandit ("Lost Bandit", 1, 10, "Poor guy seems lost and confused.", ConsoleColor.Red, 0, 2);
            Spider bigSpider = new Spider ("The Bigger-than-average Spider", 1, 10, "It's big, but you can probably still smash it with your shoe. It just takes a few more hits.", ConsoleColor.Red, 0, 2, false);


            // Level 2 enemies
            Spider poisonSpider = new Spider ("Poison Spider", 2, 20, "Oh gods, this one looks angry!", ConsoleColor.Red, 2, 4, true);
            Bandit battleScarredBandit = new Bandit ("Battle-Scarred Bandit", 2, 25, "He seems to have been in many fights before.", ConsoleColor.Red, 4, 6);
            Minotaur youngMinotaur = new Minotaur ("Young Minotaur", 2, 25, "The Minotaur is part man and part bull. Well, this one is young so part teenager, part bull. 'It's not a phase, Moooh-m!'", ConsoleColor.Red, 5, 5);

            // Level 3 enemies
            Minotaur minotaurGuard = new Minotaur ("Minotaur Guard", 3, 45, "These mythical creatures guard the treasure of the cave", ConsoleColor.Red, 6, 15);
            Bandit banditLeader = new Bandit ("Bandit Leader", 3, 40, "It takes a lof of strength to become the leader of such a hideous group of bandits", ConsoleColor.Red, 4, 10);
            Spider giantSpider = new Spider ("Giant Spider", 3, 60, "It's a giant spider towering over you.", ConsoleColor.Red, 5, 25, true);
            Minotaur minotaurChampion = new Minotaur ("Minotaur Champion", 3, 55, "The Minotaur Champion has served the Dragon Lord well and been given a special rank of Champion. No extra salary or benefits though. Some extra overtime required.", ConsoleColor.Red, 10, 20);
            Dragon youngDrake = new Dragon ("Young Drake", 3, 50, "The Dragon Lord has many consorts and when a mommy dragon and a daddy dragon hug for a very long time they sometimes get young drakes. Don't let their smaller size fool you though, they can easily eat you up.", ConsoleColor.Red, 6, 20);

            // Final boss (lvl 4)
            Dragon dragonLord = new Dragon ("Dragon Lord", 4, 100, "The guardian of the treasure. The Dragon Lord of whatever-this-cave-is-called.", ConsoleColor.DarkRed, 15, 40);

            // När du skapat fienden så lägg till den här nedan i listan. 
            EnemiesLvl1 = new List<Character>() { lostBandit, bigSpider };
            EnemiesLvl2 = new List<Character>() { poisonSpider, battleScarredBandit, youngMinotaur };
            EnemiesLvl3 = new List<Character>() { minotaurGuard, banditLeader, giantSpider, minotaurChampion, youngDrake };
            EnemiesLvl4 = new List<Character>() { dragonLord };
        }
        
        
        public void StartCombat(Player player, LevelManager manager)
        {
            if (manager.currentLevel == 1)
            {
                int randNum = RandGenerator.Next(0, 1);
                CurrentEnemy = EnemiesLvl1[randNum];
            }
            else if (manager.currentLevel == 2)
            {
                int randNum = RandGenerator.Next(0, 2);
                CurrentEnemy = EnemiesLvl2[randNum];
            }
            else if (manager.currentLevel == 3)
            {
                int randNum = RandGenerator.Next(0, 4);
                CurrentEnemy = EnemiesLvl3[randNum];
            }
            else
            {
                CurrentEnemy = EnemiesLvl4[0]; // Tänker att detta kan vara en egen metod sen. 
            }
            Battle(player, CurrentEnemy);
        }
        
        public void Battle(Player player, Character CurrentEnemy)
        {
            while (player.IsAlive && CurrentEnemy.IsAlive)
             {
                Clear();
                CombatUI.DisplayHealthBar(player);
                CombatUI.DisplayHealthBar(CurrentEnemy);
                WriteLine();

                player.Attack(CurrentEnemy);

                if (player.IsDead || CurrentEnemy.IsDead)
                {
                    break;
                }

                WriteLine();                
                CombatUI.NextRound();

                Clear();
                CombatUI.DisplayHealthBar(player);
                CombatUI.DisplayHealthBar(CurrentEnemy);
                WriteLine();

                CurrentEnemy.Attack(player);

                if (player.IsDead || CurrentEnemy.IsDead)
                {
                    break;
                }
                
                CombatUI.NextRound();
            }
        }
        
        // Denna ligger i Character.cs just nu men hade nog hellre velat ha den här. Flyttar den sen.

        // public void DealDamage(int damage)
        // {
        //     health -= damage;
        //     if (health < 0)
        //     {
        //         health = 0;
        //     }
        // }

        public void EndofCOmbat()
        {
            // Behövs denna? 
        }

        
    }
}