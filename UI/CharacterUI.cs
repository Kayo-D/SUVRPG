using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUVRPG
{
    public class CreateACharacterUI
    {
        public static void characterCreation()
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

            Console.WriteLine("ENTER CHARACHTER ATTRIBUTES:\n ");
            string characterDescription = Console.ReadLine();
            character.CharacterInfo(name, race, characterDescription);
        }
    }
}