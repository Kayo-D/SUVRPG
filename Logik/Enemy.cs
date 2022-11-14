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
        
        public Enemy(string _name, int _hitpoints, int _armor, int _attackdmg, int _speed, int _level)
            : base(_name, _hitpoints, _armor, _attackdmg, _speed, _level)
        {

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

    }
}