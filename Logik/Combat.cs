using static System.Console;

namespace SUVRPG
{
    public class Combat
    {
        private List<Character> Enemies;
        public CombatUI CombatUI = new();

        public void CreateEnemy()
        {
            Bandit bandit = new Bandit ("Bandit", 1, 10, ConsoleColor.Red, 0, 2);

            Enemies = new List<Character>() { bandit };

            //CurrentEnemy = bandit; // Detta ska sättas i StartCombat sen.

        }
        
        
        public void StartCombat()
        {
            // Metod som sätter CurrentEnemy. 
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