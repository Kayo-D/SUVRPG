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
            Write($"viciously chomps down ");
        }

        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            WriteLine($"{Name} is fighting {otherCharacter.Name}!\n");
            
            int randPercent = RandGenerator.Next(1, 101);
            Bite();
            if (randPercent <= 80)
            {
                WriteLine($"and TAKES A BITE OF YOU!\n");
                otherCharacter.TakeDamage(4 + AttackDmg);
            }
            else
            {
                WriteLine("but MISS...");
            }
            ResetColor();
            
        }
    }
}