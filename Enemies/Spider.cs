using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace SUVRPG
{
    public class Spider : Character
    {
        bool hasPoisonSting = false;
        
        public Combat Combat = new();

        public Spider(string _name, int _level, int _hitpoints, string _characterDescription, ConsoleColor _color, int _armor, int _attackdmg, bool _hasPoisonSting) 
            : base(_name, _level, _hitpoints, _characterDescription, _color, _armor, _attackdmg)
        {
            bool hasPoisonSting = _hasPoisonSting;
        }

        private void SpiderBite()
        {
            BackgroundColor = color;
            Write($"{name} ");
            ResetColor();
            WriteLine($"bites you ");
            ResetColor();
        }
 
        public override void Attack(Character otherCharacter)
        {
            ForegroundColor = color;
            WriteLine($"{name} is fighting {otherCharacter.name}!");
            ResetColor();

            SpiderBite();
            int randPercent = RandGenerator.Next(1, 101);
            if (randPercent >= 40)
            {
                WriteLine("and hits you!");
                otherCharacter.TakeDamage(2 + attackdmg);
                if (hasPoisonSting == true)
                {
                    WriteLine("The spider had a poison sting. You are poisoned and take 2 extra damage");
                    otherCharacter.TakeDamage(2);
                }
            }
            else 
            {
                WriteLine("but it just tickles!");
            }
        }

    }
}