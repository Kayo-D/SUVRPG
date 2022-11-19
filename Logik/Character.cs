using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace SUVRPG
{
    public class Character
    {
        public string Name { get; protected set; }
        public string CharacterDescription { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int AttackDmg { get; set; }
        public int Armor { get; set; }
        public string TextArt { get; protected set; }
        public ConsoleColor Color { get; protected set; }
        public Random RandGenerator { get; protected set; }
        public bool IsDead { get => Health <= 0; }
        public bool IsAlive { get => Health > 0; }


        public Character(string name, string characterDescription, int health, int attackDmg, int armor, ConsoleColor color, string textArt)
        {
            Name = name;
            CharacterDescription = characterDescription;
            Health = health;
            MaxHealth = health;
            AttackDmg = attackDmg;
            Armor = armor;
            Color = color;
            TextArt = textArt;
            RandGenerator = new Random();            
        }

        public void DisplayInfo()
        {
            
            BackgroundColor = Color;
            WriteLine($"--- {Name} ---");
            ResetColor();
            ForegroundColor = Color; 
            Write($"{CharacterDescription}\n");
            ForegroundColor = Color;
            WriteLine($"\n{TextArt}\n");
            WriteLine($"Health: {Health}");
            WriteLine("---");
            ResetColor();
        }

        public virtual void Fight(Character otherCharacter)
        {
            WriteLine("Enemy is fighting!");
        }

        public void TakeDamage(int damageAmount)
        {
            Health -= damageAmount - Armor;
            if (Health < 0)
            {
                Health = 0;
            }
        }

        public void DisplayHealthBar()
        {

            ForegroundColor = Color;
            WriteLine($"{Name}'s Health:");
            ResetColor();
            Write("[");
            BackgroundColor = ConsoleColor.Green;
            for (int i = 0; i < Health; i++)
            {
                Write(" ");
            }
            BackgroundColor = ConsoleColor.Black;
            for (int i = Health; i < MaxHealth; i++)
            {
                Write (" ");
            }
            ResetColor();
            WriteLine($"] {Health}/{MaxHealth}");
            
        }
    }
}