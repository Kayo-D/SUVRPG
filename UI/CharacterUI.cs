using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUVRPG
{
    public class CharacterUI
    {
        public static Player characterCreation()
        {
            ConsoleKey menuKeys = ConsoleKey.NoName;
            Console.Clear();
            Player character = new Player();

            Console.WriteLine("CHARACTER CREATION\n");
            Console.WriteLine("The name of your character: ");
            string name = Console.ReadLine();
            
            while (true)
            {
                if (name == "")
                {
                    Console.WriteLine("Please enter a valid character name: ");
                    name = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("PLEASE ENTER YOUR CHOICE OF CHARACTER RACE:\n");
            Console.WriteLine("1# HUMAN");
            Console.WriteLine("2# ORC");
            Console.WriteLine("3# ELF");
            Console.WriteLine("4# DWARF");
            string race = Console.ReadLine();

            switch (menuKeys)
            {
                case ConsoleKey.D1:
                Console.Clear();
                Console.WriteLine("You chose... HUMAN! Excellent choice.");
                Console.WriteLine("Human: Well met!");
                break;

                case ConsoleKey.D2:
                Console.Clear();
                Console.WriteLine("You chose... ORC! I guess that will do.");
                Console.WriteLine("Orc: Strength and honor!");
                break;

                case ConsoleKey.D3:
                Console.Clear();
                Console.WriteLine("You chose... ELF! I guess you know something about something.");
                Console.WriteLine("Elf: Bal'a dash, malanore.");
                break;

                case ConsoleKey.D4:
                Console.Clear();
                Console.WriteLine("You chose... DWARF! I guess you feel short and spicy today!");
                Console.WriteLine("Dwarf: Great tae meet ya.");
                break;

                default:
                break;
            }

            Console.WriteLine("ENTER CHARACHTER ATTRIBUTES:\n ");
            string characterDescription = Console.ReadLine();
            character.CharacterInfo(name, race, characterDescription);

            return character;
        }
    }
}