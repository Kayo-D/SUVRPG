using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace SUVRPG
{
    public class Dragon : Character
    {

        public Dragon(string _name, int _level, int _hitpoints, string _characterDescription, ConsoleColor _color, int _armor, int _attackdmg)
        {
        string name = _name;
        int level = _level;
        int hitpoints = _hitpoints;
        int maxhitpoints = _hitpoints;
        string characterDescription = _characterDescription;
        ConsoleColor color = _color;
        int armor = _armor;
        int attackdmg = _attackdmg;
        string textArt = EnemyArt.Dragon;
        RandGenerator = new Random();   
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