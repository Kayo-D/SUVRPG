using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace SUVRPG
{
    public class Minotaur : Character
    {
        public Combat Combat = new();

        public Minotaur(string _name, int _level, int _hitpoints, string _characterDescription, ConsoleColor _color, int _armor, int _attackdmg)
        {   
        string name = _name;
        int level = _level;
        int hitpoints = _hitpoints;
        int maxhitpoints = _hitpoints;
        string characterDescription = _characterDescription;
        ConsoleColor color = _color;
        int armor = _armor;
        int attackdmg = _attackdmg;
        string textArt = EnemyArt.Minotaur;
        RandGenerator = new Random();   
        }

        private void MinoSmash()
        {
            BackgroundColor = color;
            Write($"{name} ");
            ResetColor();
            WriteLine($"smashes at you ");
            ResetColor();
        }
 
        public override void Attack(Character otherCharacter)
        {
            ForegroundColor = color;
            WriteLine($"{name} is fighting {otherCharacter.name}!");
            ResetColor();

            MinoSmash();
            int randPercent = RandGenerator.Next(1, 101);
            if (randPercent >= 60)
            {
                WriteLine("and hits you hard!");
                otherCharacter.TakeDamage(5 + attackdmg);
            }
            else 
            {
                WriteLine("but misses you!");
            }
        }

    }
}