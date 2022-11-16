using static System.Console;

namespace SUVRPG
{
    public class Combat
    {
        public Player CurrentPlayer;
        public Character CurrentEnemy;
        private List<Character> Enemies;

        public void CreateEnemy()
        {
            Bandit bandit = new Bandit ("Bandit", 1, 10, ConsoleColor.Red, 0, 2);

            Enemies = new List<Character>() { bandit };

            CurrentEnemy = bandit; // Detta ska sättas i StartCombat sen.

        }
        
        
        public void StartCombat()
        {
            // Metod som sätter CurrentEnemy. 
        }
        
        public void Battle()
        {
            while (CurrentPlayer.IsAlive && CurrentEnemy.IsAlive)
             {
                Clear();
                CurrentPlayer.DisplayHealthBar();
                CurrentEnemy.DisplayHealthBar();
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
                CurrentPlayer.DisplayHealthBar();
                CurrentEnemy.DisplayHealthBar();
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