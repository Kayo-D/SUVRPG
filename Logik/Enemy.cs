using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUVRPG
{
    public class Enemy : Character
    {
        public Enemy(string _name, string _characterDescription, int _hitpoints, int _armor, int _attackdmg, int _speed)
        {
            string name = _name;
            string characterDescription = _characterDescription;
            int hitpoints = _hitpoints;
            int armor = _armor;
            int attackdmg = _attackdmg;
            int speed = _speed;
        }

        public virtual void EnemyAttack()
        {
            Console.WriteLine("The enemy is attacking!");
        }
    }
}