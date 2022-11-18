using static System.Console;

//Denna klassen ska egentligen vara abstrakt
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
    
    // Enemy
    public Character(string _name, int _level, int _hitpoints, string _characterDescription, ConsoleColor _color, int _armor, int _attackdmg, string _textArt)
    {
        string name = _name;
        int level = _level;
        int hitpoints = _hitpoints;
        int maxhitpoints = _hitpoints;
        string characterDescription = _characterDescription;
        ConsoleColor color = _color;
        int armor = _armor;
        int attackdmg = _attackdmg;
        string textArt = _textArt;
        RandGenerator = new Random();   
    }

    // Player
    public Character(string _name, string _characterDescription, int _hitpoints, ConsoleColor _color, int _armor, int _attackdmg)
    {
        string name = _name;
        string characterDescription = _characterDescription;
        int hitpoints = _hitpoints;
        int maxhitpoints = _hitpoints;
        ConsoleColor color = _color;
        int armor = _armor;
        int attackdmg = _attackdmg;
        RandGenerator = new Random();   
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
