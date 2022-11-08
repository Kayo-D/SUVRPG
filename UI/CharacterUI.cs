using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUVRPG
{
    public class CharacterUI
    {
        public static void characterCreation()
        {
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
            Console.WriteLine("- HUMAN");
            Console.WriteLine("- ORC");
            Console.WriteLine("- ELF");
            Console.WriteLine("- DWARF");
            string race = Console.ReadLine();

            string characterDescription = Console.ReadLine();
            character.CharacterInfo(name, race, characterDescription);
        }
    }
}