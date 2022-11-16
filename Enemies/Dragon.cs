using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace SUVRPG
{
    public class Dragon : Character
    {
        
        Combat Combat = new Combat();

        public Dragon(string _name, int _level, int _hitpoints, ConsoleColor _color, int _armor, int _attackdmg) 
            : base(_name, _level, _hitpoints, _color, _armor, _attackdmg)
        {
            
        }

        // public override void EnemyInfo()
        // {
        //     System.Console.WriteLine($"You've encountered a {name}! It has {hitpoints} hitpoints.");
        // }

        private void Firebreath()
        {
            Console.Write("The dragon breathes fire on you ");
            int randPercent = RandGenerator.Next(1, 101);
            if (randPercent <= 30)
            {
                WriteLine("and burns you for 30 damage!");
                Combat.DealDamage(20);
            }
            else
            {
                WriteLine("but misses the attack!");
            }

        }

        private void TailWhip()
        {
            System.Console.WriteLine("The dragon whips his spiky tail at you ");
            int randPercent = RandGenerator.Next(1, 101);
            if (randPercent <= 60)
            {
                WriteLine("and wounds you for 10 damage.");
                Combat.DealDamage(10);
            }
            else
            {
                WriteLine("but misses the attack!");
            }
    
        }
 
        public override void Attack(Character otherCharacter)
        {
            ForegroundColor = color;
            WriteLine($"{name} is fighting {otherCharacter.name}!");
            
            int randPercent = RandGenerator.Next(1, 101);
            if (randPercent <= 40)
            {
                Firebreath();
            }
            else
            {
                TailWhip();
            }
            
            Write($"{name} bites at {otherCharacter.name} and ");
            if (randPercent <= 40)
            {
                WriteLine("hits for 4 damage!");
                otherCharacter.TakeDamage(4);
            }
            else
            {
                WriteLine("misses...");
            }
            ResetColor();
        }
    }
}