using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace SUVRPG
{
    public class Bandit : Character
    {
        public Bandit(string name, string characterDescription, int health, int attackDmg, ConsoleColor color)
            : base(name, characterDescription, health, attackDmg, 0, color, ArtAssets.Bandit)
        {
            
        }
        
        private void MeeleStrike()
        {
            BackgroundColor = Color;
            Write($"{Name} ");
            ResetColor();
            Write($"strikes at you with his sword ");
            ResetColor();
        }

        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            WriteLine($"{Name} is fighting {otherCharacter.Name}! \n");
            ResetColor();

            MeeleStrike();
            int randPercent = RandGenerator.Next(1, 101);
            if (randPercent >= 60)
            {
                WriteLine("and HITS YOU!\n");
                otherCharacter.TakeDamage(2 + AttackDmg);
            }
            else 
            {
                WriteLine("but MISSES you! *phew*\n");
            }
        }
    }
}