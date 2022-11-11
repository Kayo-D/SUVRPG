using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUVRPG
{
    public class Dragon : Enemy
    {
        
        Combat Combat = new Combat();
        public Dragon(int _enemyLevel, string _name, string _characterDescription, int _hitpoints, int _armor, int _attackdmg, int _speed) : base(_name, _characterDescription, _hitpoints, _armor, _attackdmg, _speed)
        {
            int EnemyLevel = _enemyLevel;
        }

        public void DisplayEnemyInfo()
        {

        }

        public void Firebreath()
        {
            Console.WriteLine("The dragon breathes fire on you!");
            Combat.Attack(20);
        }

        public void TailWhip()
        {
            System.Console.WriteLine("The dragon whips his spiky tail at you!");
            Combat.Attack(10);
        }

        public override void EnemyAttack()
        {
            base.EnemyAttack();
            Firebreath();
            TailWhip();
        }
    }
}