using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace SUVRPG
{
    class Dragon : Character
    {

        public Dragon(string name, string characterDescription, int health, int attackDmg, ConsoleColor color)
            : base(name, characterDescription, health, attackDmg, 0, color, ArtAssets.Dragon)
        {
            
        }

        public void Bite()
        {
            BackgroundColor = Color;
            Write($"{Name} ");
            ResetColor();
            WriteLine($"viciously chomps down!");
        }

        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            WriteLine($"{Name} is fighting {otherCharacter.Name}!");
            
            int randPercent = RandGenerator.Next(1, 101);
            Write($"{Name} bites at {otherCharacter.Name} and ");
            if (randPercent <= 50)
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