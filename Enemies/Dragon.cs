using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUVRPG
{
    public class Dragon : Enemy
    {
        public Dragon(int _enemyLevel, string _name, string _characterDescription, int _hitpoints, int _armor, int _attackdmg, int _speed) : base(_name, _characterDescription, _hitpoints, _armor, _attackdmg, _speed)
        {
            int EnemyLevel = _enemyLevel;
        }

        public void DisplayEnemyInfo()
        {

        }

        public override void EnemyAttack()
        {
            base.EnemyAttack();
        }
    }
}