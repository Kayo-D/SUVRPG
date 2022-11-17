using static System.Console;

public class Player : Character
{
    public string race { get; set; }
    public int currentGold;
    public int hitpointsMax;

    private const int smallAttack = 2;
    private const int bigAttack = 4;

    public Player()
    {

    }
    
    public Player(string _name, int _hitpoints, ConsoleColor _color, int _armor, int _attackdmg)
        : base(_name, _hitpoints, _color, _armor, _attackdmg)
        {
            currentGold = 0;

        }
    
    public void CharacterInfo(string name, string race, string characterDescription)
    {

    }

    public void AttackOne(Character CurrentEnemy)
    {
        Write("You make a precise but light attack attack against your enemy ");
                int randPercent = RandGenerator.Next(1, 101);
                if (randPercent <= 90)
                {
                    WriteLine("and it hits!");
                    CurrentEnemy.TakeDamage(attackdmg + smallAttack);
                }
                else
                {
                    WriteLine("but it misses. ");
                }

    }

    public void AttackTwo(Character CurrentEnemy)
    {
        Write("You make a great (albeit rather ambitious) swing ");
        int randPercent = RandGenerator.Next(1, 101);
        if (randPercent <= 50)
        {
            WriteLine("and it's a perfect hit!");
            CurrentEnemy.TakeDamage(attackdmg + bigAttack);
        }
        else
        {
            WriteLine("and it misses the target completely.");
        }
    }
}
        
    
