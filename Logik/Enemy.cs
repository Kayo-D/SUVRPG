using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace SUVRPG
{
    public class Enemy : Character
    {
        protected int level;
        protected string name;
        
        public Enemy(string _name, int _hitpoints, int _armor, int _attackdmg, int _speed, int _level)
        {
            string name = _name;
            int hitpoints = _hitpoints;
            int armor = _armor;
            int attackdmg = _attackdmg;
            int speed = _speed;
            int level = _level;
        }
        public virtual void EnemyAttack()
        {
            
        }
        // private List<Enemy> Enemies;

        public void EnemyInfo()
        {
            Write($"--- {name} ---");
            WriteLine($"\nLevel: {level}\n");
            WriteLine($"Health: {hitpoints}");
            WriteLine("---");

        }



        //         private List<Enemy> Enemies;

        // public void EnemyTest()
        // {
        //     // Enemy enemy = new Enemy("", 0, 0, 0, 0, 0);
        //     // enemy.CreateEnemy();
        //     // enemy.EnemyInfo();
        //     Console.Clear();
            
        //     Dragon dragonlord = new Dragon("Dragonlord", 200, 10, 30, 60, 5);
        //     Bandit bandit = new Bandit("Bandit", 20, 0, 2, 5, 2);

        //     Enemies = new List<Enemy>() { dragonlord, bandit };

        //     foreach (Enemy enemy in Enemies)
        //     {
        //         System.Console.WriteLine(Enemies.Count);
        //         enemy.EnemyInfo();
        //     }
        // }

    }
}