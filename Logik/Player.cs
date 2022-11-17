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

    public void AttackOne(Character Enemy)
    {
        Attack(attackdmg + smallAttack);
    }

    public void AttackTwo(Character Enemy)
    {
        Attack(attackdmg + bigAttack);
    }

    private void Attack(int damage)
    {
        // CurrentEnemy.hitpoints -= damage;
    }
}