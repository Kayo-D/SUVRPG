using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace SUVRPG
{
    public class Player : Character
    {
        public int CurrentGold { get; set; }

        private const int smallAttack = 2;
        private const int bigAttack = 5;
        
        public Player(){}
        public Player(string name, string race, string characterDescription, int maxhitpoints, int currentGold, int health, int attackDmg, int armor, ConsoleColor color)
            : base(name, characterDescription, health, attackDmg, armor, color, ArtAssets.Player)
            {
                Armor = armor;
                CurrentGold = currentGold;
            }

            private void Attack1(Character otherCharacter)
            {
                Write("You make a precise but light attack attack against your enemy ");
                int randPercent = RandGenerator.Next(1, 101);
                if (randPercent <= 90)
                {
                    WriteLine("and it hits!");
                    otherCharacter.TakeDamage(AttackDmg + smallAttack);
                }
                else
                {
                    WriteLine("but it misses. ");
                }
            }

            private void Attack2(Character otherCharacter)
            {
                Write("You make a great (albeit rather ambitious) swing ");
                int randPercent = RandGenerator.Next(1, 101);
                if (randPercent <= 50)
                {
                    WriteLine("and it's A PERFECT HIT! \n");
                    otherCharacter.TakeDamage(AttackDmg + bigAttack);
                }
                else
                {
                    WriteLine("but it MISSES the target completely.\n");
                }
            }
    
            public override void Fight(Character otherCharacter)
            {
                WriteLine("----------------------------\n");
                ForegroundColor = Color;
                WriteLine($"       ----- It's YOUR turn to FIGHT!!  ----- \n");

                WriteLine($"   You are facing a {otherCharacter.Name}! What would you like to do? \n");
                WriteLine($"   [1] Light attack (90% chance for {2 + AttackDmg} dmg)");
                WriteLine($"   [2] Heavy attack (50% chance for {5 + AttackDmg} dmg)");
                // WriteLine($"[3] Run away (And lose your chance to fight this monster)");
                ResetColor();
                
                ConsoleKeyInfo keyInfo = ReadKey(true);
                if (keyInfo.Key == ConsoleKey.D1)
                {
                    Clear();
                    Combat.CurrentPlayer.DisplayHealthBar();
                    Combat.CurrentEnemy.DisplayHealthBar();
                    WriteLine("---------------------------------\n");
                    Attack1(otherCharacter);
                }
                else if (keyInfo.Key == ConsoleKey.D2)
                {
                    Clear();
                    Combat.CurrentPlayer.DisplayHealthBar();
                    Combat.CurrentEnemy.DisplayHealthBar();
                    WriteLine("--------------------\n");
                    Attack2(otherCharacter);
                }
                // else if (keyInfo.Key == ConsoleKey.D3)
                // {
                //     return;
                // }
                else
                {
                    WriteLine("That's not a valid move! Try again!");
                    Fight(otherCharacter);
                    return;
                }
                ResetColor();
            }
    }
}