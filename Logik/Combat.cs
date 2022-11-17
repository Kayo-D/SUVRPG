using static System.Console;

namespace SUVRPG
{
    public class Combat
    {
        private List<Character> EnemiesLvl1;
        private List<Character> EnemiesLvl2;
        private List<Character> EnemiesLvl3;
        private List<Character> EnemiesLvl4;
        private List<Character> EnemiesLvl5;
        public CombatUI CombatUI = new();

        public void CreateEnemy()
        {
            Bandit lostBandit = new Bandit ("Lost Bandit", 1, 10, "Poor guy seems lost and confused.", ConsoleColor.Red, 0, 2);
            Spider bigSpider = new Spider ("Big Freakin' Spider", 1, 10, "It's big, but you can probably still smash it with your shoe. It just takes a few more hits.", ConsoleColor.Red, 0, 2, false);

            Spider poisonSpider = new Spider ("Poison Spider", 2, 20, "Oh gods, this one looks angry!", ConsoleColor.Red, 2, 4, true);
            Bandit battleScarredBandit = new Bandit ("Battle-Scarred Bandit", 2, 25, "He seems to have been in many fights before.", ConsoleColor.Red, 4, 6);
            Minotaur youngMinotaur = new Minotaur ("Young Minotaur", 2, 25, "The Minotaur is part man and part bull. Well, this one is young so part teenager, part bull. 'It's not a phase, Moooh-m!'", ConsoleColor.Red, 5, 5);

            Minotaur minotaurGuard = new Minotaur ("Minotaur Guard", 3, 45, "These mythical creatures guard the treasure of the cave", ConsoleColor.Red, 6, 15);
            Bandit banditLeader = new Bandit ("Bandit Leader", 3, 40, "It takes a lof of strength to become the leader of such a hideous group of bandits", ConsoleColor.Red, 4, 10);

            Spider giantSpider = new Spider ("Giant Spider", 4, 60, "It's a giant spider towering over you.", ConsoleColor.Red, 5, 25, true);
            Minotaur minotaurChampion = new Minotaur ("Minotaur Champion", 4, 55, "The Minotaur Champion has served the Dragon Lord well and been given a special rank of Champion. No extra salary or benefits though.", ConsoleColor.Red, 10, 20);
            Dragon youngDrake = new Dragon ("Young Drake", 4, 50, "The Dragon Lord has many consorts and when a mommy dragon and a daddy dragon hug for a very long time they sometimes get young drakes. Don't let their smaller size fool you though, they can easily eat you up.", ConsoleColor.Red, 6, 20);

            Dragon dragonLord = new Dragon ("Dragon Lord", 5, 100, "The guardian of the treasure. The Dragon Lord of whatever-this-cave-is-called.", ConsoleColor.DarkRed, 15, 40);

            EnemiesLvl1 = new List<Character>() { lostBandit, bigSpider };
            EnemiesLvl2 = new List<Character>() { poisonSpider, battleScarredBandit, youngMinotaur };
            EnemiesLvl3 = new List<Character>() { minotaurGuard, banditLeader };
            EnemiesLvl4 = new List<Character>() { giantSpider, minotaurChampion, youngDrake };
            EnemiesLvl5 = new List<Character>() { dragonLord };
        }
        
        
        public void StartCombat()
        {
            // Metod som sätter CurrentEnemy?
        }
        
        public void Battle(Player CurrentPlayer, Character CurrentEnemy)
        {
            while (CurrentPlayer.IsAlive && CurrentEnemy.IsAlive)
             {
                Clear();
                CombatUI.DisplayHealthBar(CurrentPlayer);
                CombatUI.DisplayHealthBar(CurrentEnemy);
                WriteLine();

                CurrentPlayer.Attack(CurrentEnemy);

                if (CurrentPlayer.IsDead || CurrentEnemy.IsDead)
                {
                    break;
                }

                WriteLine();                
                WriteLine("Press any key to continue...\n");
                ReadKey(true);

                Clear();
                CombatUI.DisplayHealthBar(CurrentPlayer);
                CombatUI.DisplayHealthBar(CurrentEnemy);
                WriteLine();

                CurrentEnemy.Attack(CurrentPlayer);
                
                WriteLine("Press any key to continue...\n");
                ReadKey(true);
            }
        }
        
        public void DealDamage(int damage)
        {
            
        }


        public void CalculateHP()
        {

        }

        public void EndofCOmbat()
        {

        }

        
    }
}