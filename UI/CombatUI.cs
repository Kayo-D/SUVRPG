using static System.Console;

namespace SUVRPG
{
    public class CombatUI
    {
        public ConsoleColor color { get; set; }
        public void StartFight()
        {
            WriteLine("Fight is starting!");
        }

        public void CombatScreen()
        {

        }


        public void YouWinScreen()
        {

        }

        public void YouLoseScreen()
        {

        }
        public void DisplayHealthBar(Character character)
        {
            ForegroundColor = color;
            WriteLine($"{character.name}'s Health:");
            ResetColor();
            Write("[");
            BackgroundColor = ConsoleColor.Green;
            for (int i = 0; i < character.hitpoints; i++)
            {
                Write(" ");
            }
            BackgroundColor = ConsoleColor.Black;
            for (int i = character.hitpoints; i < character.maxhitpoints; i++)
            {
                Write(" ");
            }
            ResetColor();
            WriteLine($"] {character.hitpoints}/{character.maxhitpoints}");

        }

        public void PlayerCombatMenu(Player player, Character CurrentEnemy)
        {
            string title = "It's your turn to fight! What do you want to do?\n";

            string[] options = { $"ATTACK 1 ({player.attackdmg + 2} DMG AND 90% CHANCE TO HIT)",
            $"ATTACK 2 ({player.attackdmg + 4} DMG 50% CHANCE TO HIT)",
            "RUN AWAY"};

            Menu playerCombatMenu = new Menu(title, options);

            int SelectedIndex = playerCombatMenu.Run();

            switch (SelectedIndex)
            {
                case 0:
                    player.AttackOne(CurrentEnemy);
                    break;;

                case 1:
                    player.AttackTwo(CurrentEnemy);
                    break;

                case 2:
                    Console.WriteLine("You run away!");
                    break;
            }

        }

        public static void GameOver(Player player)
        {
            Clear();
            if (!player.IsAlive)
            {
                WriteLine($"Alas! {player.name}, you have met a sad fate. ");
                WriteLine(@"
                
                ");
                CombatUI.NextRound();
                MainMenu.Mainmenu();
            }
        }

        public static void NextRound()
        {
            WriteLine("Press any key to continue to the next round! \n");
            ReadKey(true);
        }
    }
}