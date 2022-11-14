using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUVRPG
{
    public class Minotaur : Enemy
    {
        Combat Combat = new Combat();
        public Minotaur(string _name, int _hitpoints, int _armor, int _attackdmg, int _speed, int _level) 
            : base(_name, _hitpoints, _armor, _attackdmg, _speed, _level)
        {
            
        }

        private void MinoSmash()
        {
            System.Console.WriteLine("The minotaur smashes at you!");
            Combat.Attack(6);
        }
 
        public override void EnemyAttack()
        {
            base.EnemyAttack();
            MinoSmash();
        }

    }
}