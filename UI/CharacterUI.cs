using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUVRPG
{
    public class CharacterUI
    {
        public Player characterCreation()
        {
            Player character = new Player();
            ConsoleKey raceMenu = ConsoleKey.NoName;
            Console.Clear();

            Console.WriteLine("CHARACTER CREATION\n");
            Console.WriteLine("The name of your character: ");
            character.name = Console.ReadLine();
            
            while (true)
            {
                if (character.name == "")
                {
                    Console.WriteLine("Please enter a valid character name: ");
                    character.name = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            Console.Clear();
            Console.WriteLine("PLEASE ENTER YOUR CHOICE OF CHARACTER RACE:\n");
            Console.WriteLine("1# HUMAN");
            Console.WriteLine("2# ORC");
            Console.WriteLine("3# ELF");
            Console.WriteLine("4# DWARF");
            raceMenu = Console.ReadKey(true).Key;
            bool isInputCorrect = true;

            while (isInputCorrect)
            {
                switch (raceMenu)
                {
                    case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("You chose... HUMAN! Excellent choice.\n");
                    Console.WriteLine("Human: Well met!");
                    character.race = "Human";
                    break;

                    case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("You chose... ORC! I guess that will do.\n");
                    Console.WriteLine("Orc: Strength and honor!");
                    character.race = "Orc";
                    break;

                    case ConsoleKey.D3:
                    Console.Clear();
                    Console.WriteLine("You chose... ELF! I guess you know something about something.\n");
                    Console.WriteLine("Elf: Bal'a dash, malanore.");
                    character.race = "Elf";
                    break;

                    case ConsoleKey.D4:
                    Console.Clear();
                    Console.WriteLine("You chose... DWARF! I guess you feel short and spicy today!\n");
                    Console.WriteLine("Dwarf: Great tae meet ya.");
                    character.race = "Dwarf";
                    break;

                    default:
                    isInputCorrect = false;
                    Console.WriteLine("Please try again.");
                    break;                
                }
            }
            
            Console.WriteLine("ENTER CHARACTER INFO:\n ");
            character.characterDescription = Console.ReadLine();
            character.CharacterInfo(character.name, character.race, character.characterDescription);
            return character;
        }
    }
}