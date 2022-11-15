using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUVRPG
{
    public class Spider : Enemy
    {
        Combat Combat = new Combat();
        public Spider(bool _hasPoisonSting, string _name, int _hitpoints, int _armor, int _attackdmg, int _speed, int _level) 
            : base(_name, _hitpoints, _armor, _attackdmg, _speed, _level)
        {
            bool HasPoisonSting = _hasPoisonSting;
        }

        private void SpiderBite()
        {
            System.Console.WriteLine("The spider bites you");
            Combat.Attack(3);
        }
 
        public override void EnemyAttack()
        {
            base.EnemyAttack();
            SpiderBite();
        }

    }
}