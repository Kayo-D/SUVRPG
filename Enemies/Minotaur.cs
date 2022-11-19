using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace SUVRPG
{
    public class Minotaur : Character
    {
        public Minotaur(string name, string characterDescription, int health, int attackDmg, ConsoleColor color)
            : base(name, characterDescription, health, attackDmg, color, ArtAssets.Minotaur)
        {
            
        }

        private void MinoSmash()
        {
            BackgroundColor = Color;
            Write($"{Name} ");
            ResetColor();
            WriteLine($"smashes at you ");
            ResetColor();
        }
 
        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            WriteLine($"{Name} is fighting {otherCharacter.Name}!");
            ResetColor();

            MinoSmash();
            int randPercent = RandGenerator.Next(1, 101);
            if (randPercent >= 60)
            {
                WriteLine("and hits you hard!");
                otherCharacter.TakeDamage(5 + AttackDmg);
            }
            else 
            {
                WriteLine("but misses you!");
            }
        }

    }
}