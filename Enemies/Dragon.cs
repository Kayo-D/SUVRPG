using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace SUVRPG
{
    public class Dragon : Enemy
    {
        
        public Combat Combat = new();

        public Dragon(string _name, int _level, int _hitpoints, string _characterDescription, ConsoleColor _color, int _armor, int _attackdmg) 
            : base(_name, _level, _hitpoints, _characterDescription, _color, _armor, _attackdmg, EnemyArt.Dragon)
        {
            
        }

        private void Firebreath()
        {
            Console.Write("The dragon breathes fire on you ");
        }

        private void TailWhip()
        {
            System.Console.WriteLine("The dragon whips his spiky tail at you ");
        }
 
        public override void Attack(Character otherCharacter)
        {
            ForegroundColor = color;
            WriteLine($"{name} is fighting {otherCharacter.name}!");
            
            int randPercent = RandGenerator.Next(1, 101);
            if (randPercent <= 40)
            {
                Firebreath();
                if (randPercent <= 70)
                {
                    WriteLine("and burns you for 30 damage! Ouch, it burns!");
                    otherCharacter.TakeDamage(20 + attackdmg);
                }
                else
                {
                    WriteLine("but misses the attack!");
                }
            }
            else
            {
                TailWhip();
                if (randPercent <= 70)
                {
                    WriteLine("and wounds you for 10 damage.");
                    otherCharacter.TakeDamage(10 + attackdmg);
                }
                else
                {
                    WriteLine("but misses the attack!");
                }
            }
            ResetColor();
        }
    }
}