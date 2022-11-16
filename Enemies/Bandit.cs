using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace SUVRPG
{
    public class Bandit : Character
    {
        Combat Combat = new Combat();
        public Bandit(string _name, int _level, int _hitpoints, ConsoleColor _color, int _armor, int _attackdmg) 
            : base(_name, _level, _hitpoints, _color, _armor, _attackdmg)
        {
            
        }
        
        private void Charge()
        {
            System.Console.WriteLine("The bandit charges at you!");
            Combat.DealDamage(4);
        }
        private void Swordattack()
        {
            System.Console.WriteLine("The bandit swings his sword at you!");
            Combat.DealDamage(8);
        }
        // public override void EnemyInfo()
        // {
        //     System.Console.WriteLine($"You've encountered a {name}! It has {hitpoints} hitpoints.");
        // }
        public override void Attack(Character otherCharacter)
        {
            Charge();
            Swordattack();
        }
    }
}