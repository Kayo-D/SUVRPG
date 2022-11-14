using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUVRPG
{
    public class Dragon : Enemy
    {
        
        Combat Combat = new Combat();

        public Dragon(string _name, int _hitpoints, int _armor, int _attackdmg, int _speed, int _level) 
            : base(_name, _hitpoints, _armor, _attackdmg, _speed, _level)
        {
    
        }

        // public override void EnemyInfo()
        // {
        //     System.Console.WriteLine($"You've encountered a {name}! It has {hitpoints} hitpoints.");
        // }

        private void Firebreath()
        {
            Console.WriteLine("The dragon breathes fire on you!");
            Combat.Attack(20);
        }

        private void TailWhip()
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