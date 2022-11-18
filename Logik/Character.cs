using static System.Console;

public class Character
{
    public string name { get; set; }
    public int level { get; set; }
    public string characterDescription { get; set; }
    public int hitpoints { get; set; }
    public int maxhitpoints { get; set; }
    public ConsoleColor color { get; set; }
    public int armor { get; set; }
    public int attackdmg { get; set; }
    public string textArt { get; set; }
    public Random RandGenerator { get; set; }
    public bool IsDead { get => hitpoints <= 0; }
    public bool IsAlive { get => hitpoints > 0; }

    public Character()
    {

    }
    public void DisplayInfo()
    {
        BackgroundColor = color;
        Write($">>> {name} <<<");
        WriteLine($"\nLevel: {level}\n");
        ResetColor();
        ForegroundColor = color;
        WriteLine($"{textArt}");
        WriteLine($"Health: {hitpoints}");
        WriteLine("---");
        ResetColor();
    }

    public virtual void Attack(Character otherCharacter)
    {

    }

    public void TakeDamage(int damageAmount)
    {
        hitpoints -= damageAmount;
        if (hitpoints < 0)
        {
            hitpoints = 0;
        }
    }

    


}
