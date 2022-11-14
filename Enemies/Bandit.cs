using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUVRPG
{
    public class Bandit : Enemy
    {
        Combat Combat = new Combat();
        public Bandit(string _name, int _hitpoints, int _armor, int _attackdmg, int _speed, int _level) 
            : base(_name, _hitpoints, _armor, _attackdmg, _speed, _level)
        {
            
        }
        
        private void Charge()
        {
            System.Console.WriteLine("The bandit charges at you!");
            Combat.Attack(4);
        }
        private void Swordattack()
        {
            System.Console.WriteLine("The bandit swings his sword at you!");
            Combat.Attack(8);
        }
        // public override void EnemyInfo()
        // {
        //     System.Console.WriteLine($"You've encountered a {name}! It has {hitpoints} hitpoints.");
        // }
        public override void EnemyAttack()
        {
            base.EnemyAttack();
            Charge();
            Swordattack();
        }
    }
}