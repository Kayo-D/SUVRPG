using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace SUVRPG
{
    public class CreateCharacter
    {        
        public static Player RunIntro()
        {
            string race = "";
            ConsoleKey raceMenu = ConsoleKey.NoName;
            Console.Clear();

            Console.WriteLine("CHARACTER CREATION\n");
            WriteLine("--------------------\n");
            Console.Write("Enter the name of your character: ");
            string name = ReadLine();

            while (true)
            {
                if (name == "")
                {
                    Console.Write("Please enter a valid character name: ");
                    name = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            WriteLine("\n--------------------\n");
            // Console.Clear();
            WriteLine($"{name}, huh? What a .... Lovely name!\n");
            Console.WriteLine("And finally, pick what race you identify as:\n");
            Console.WriteLine("[1] HUMAN");
            Console.WriteLine("[2] ORC");
            Console.WriteLine("[3] ELF");
            Console.WriteLine("[4] DWARF");
            raceMenu = Console.ReadKey(true).Key;
            bool isInputCorrect = false;

            while (isInputCorrect == false)
            {
                switch (raceMenu)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("You chose... HUMAN! Excellent choice.\n");
                        Console.WriteLine("Human: Well met!");
                        Console.WriteLine("Press any key to continue");
                        race = "Human";
                        isInputCorrect = true;
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("You chose... ORC! I guess that will do.\n");
                        Console.WriteLine("Orc: Strength and honor!");
                        Console.WriteLine("Press any key to continue");
                        race = "Orc";
                        isInputCorrect = true;
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("You chose... ELF! I guess you know something about something.\n");
                        Console.WriteLine("Elf: Bal'a dash, malanore.");
                        Console.WriteLine("Press any key to continue");
                        race = "Elf";
                        isInputCorrect = true;
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("You chose... DWARF! I guess you feel short and spicy today!\n");
                        Console.WriteLine("Dwarf: Great tae meet ya.");
                        Console.WriteLine("Press any key to continue");
                        race = "Dwarf";
                        isInputCorrect = true;
                        Console.ReadKey();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Please try again.");
                        Console.WriteLine("PLEASE ENTER YOUR CHOICE OF CHARACTER RACE:\n");
                        Console.WriteLine("1# HUMAN");
                        Console.WriteLine("2# ORC");
                        Console.WriteLine("3# ELF");
                        Console.WriteLine("4# DWARF");
                        raceMenu = Console.ReadKey(true).Key;
                        break;
                }
            }

            // Console.WriteLine("ENTER CHARACTER INFO:\n "); //
            // string characterDescription = Console.ReadLine();
            Clear();

            Combat.CurrentPlayer = new Player(name, race, "", 20, 0, 30, 0, 0, ConsoleColor.Green);

            // Write("Greetings, ");
            // Combat.CurrentPlayer.DisplayInfo();
            // Write("Click any key to start your adventure...")
            // ReadKey(true);

            TextPrologue(name);

            return Combat.CurrentPlayer;


        }
    

        public static void TextPrologue(string name)
        {
                    string introText = @$"You've waited for this moment your whole life, {name}! ...

Since you were young you've been told about the treasures below whatever-it's-called-mountain. 

You scoff at the legends about the ancient dragon lord that guards the treasure room or how the mountain is supposedly home to an army of minotaurs. 

The only thing that matters to you...

Is the loot.


";
            

            for (int i = 0; i < introText.Length; i++)
            {
                Write(introText[i]);
                Thread.Sleep(30);
                if (KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Spacebar || keyInfo.Key == ConsoleKey.Enter)
                    {
                        Write(introText.Substring(i + 1));
                        break;
                    }
                }
            }

            CombatUI.WaitForKey();
        }
    }

}