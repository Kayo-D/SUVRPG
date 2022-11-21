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
        private const int bigAttack = 4;
        
        public Player(){}
        public Player(string name, string race, string characterDescription, int maxhitpoints, int currentGold, int health, int attackDmg, int armor, ConsoleColor color)
            : base(name, characterDescription, health, attackDmg, armor, color, ArtAssets.Player)
            {
                Armor = armor;
                CurrentGold = 0;
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
                    WriteLine("and it's a perfect hit!");
                    otherCharacter.TakeDamage(AttackDmg + bigAttack);
                }
                else
                {
                    WriteLine("and it misses the target completely.");
                }
            }
    
            public override void Fight(Character otherCharacter)
            {
//                 ForegroundColor = Color;
//                 string title = $@"--- It's YOUR turn to FIGHT!!  ---

// You are facing a {otherCharacter.Name}! What do you want to do?
//                  ";
                
//                 string[] options = { $"ATTACK 1 ({AttackDmg + smallAttack} DMG AND 90% CHANCE TO HIT)",
//                 $"ATTACK 2 ({AttackDmg + bigAttack} DMG 50% CHANCE TO HIT)",
//                 "RUN AWAY"};

//                 Menu playerCombatMenu = new Menu(title, options);
                
//                 int SelectedIndex = playerCombatMenu.Run();

//                 switch (SelectedIndex)
//             {
//                 case 0:
//                     Attack1(otherCharacter);
//                     break;;

//                 case 1:
//                     Attack2(otherCharacter);
//                     break;

//                 case 2:
//                     Console.WriteLine("You run away!");
//                     break;
//             }

//             ResetColor();
                
                ForegroundColor = Color;
                WriteLine("------- YOUR TURN -------");
                WriteLine($@"You are facing a {otherCharacter.Name}. What would you like to do?
                
                (1) First attack (90% chance for {2 + AttackDmg} dmg)
                (2) Second attack (50% chance for {4 + AttackDmg} dmg)");
                ResetColor();
                
                ConsoleKeyInfo keyInfo = ReadKey(true);
                if (keyInfo.Key == ConsoleKey.D1)
                {
                    Attack1(otherCharacter);
                }
                else if (keyInfo.Key == ConsoleKey.D2)
                {
                    Attack2(otherCharacter);
                }
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