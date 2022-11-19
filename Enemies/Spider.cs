using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace SUVRPG
{
    public class Spider : Character
    {
        bool HasPoisonSting;

        public Spider(string name, string characterDescription, int health, int attackDmg, ConsoleColor color, bool hasPoisonSting)
            : base(name, characterDescription, health, attackDmg, color, ArtAssets.Spider)
        {
            HasPoisonSting = hasPoisonSting;
        }

        private void SpiderBite()
        {
            BackgroundColor = Color;
            Write($"{Name} ");
            ResetColor();
            WriteLine($"bites you ");
            ResetColor();
        }
 
        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            WriteLine($"{Name} is fighting {otherCharacter.Name}!");
            ResetColor();

            SpiderBite();
            int randPercent = RandGenerator.Next(1, 101);
            if (randPercent >= 40)
            {
                WriteLine("and hits you!");
                otherCharacter.TakeDamage(2 + AttackDmg);
                if (HasPoisonSting == true)
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