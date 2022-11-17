using Dapper;
using MySqlConnector;
public class DB
{
    public MySqlConnection Connection()
    {
        MySqlConnection connection = new();
        connection = new MySqlConnection("Server=localhost;Database=suvrpg;Uid=root;");
        return connection;
    }
    public Player LoadPlayer(string input)
    {
        Player player = new Player();
        var playerList = Connection().Query<Player>($"SELECT id, name, race, characterDescription, maxhitpoints, hitpoints, currentGold, attackdmg, armor FROM player;").ToList();

        foreach (Player p in playerList)
        {
            if (input == p.name)
            {
                player.name = p.name;
                player.race = p.race;
                player.characterDescription = p.characterDescription;
                player.maxhitpoints = p.maxhitpoints;
                player.hitpoints = p.hitpoints;
                player.currentGold = p.currentGold;
                player.attackdmg = p.attackdmg;
                player.armor = p.armor;
            }
        }
        return player;
    }

    public void SavePlayer(Player player)
    {

    }

    public Level1 LoadLevelMap()
    {
        Level1 level1 = new();
        return level1;
    }

    public void SaveLevelMap(Level1 level1)
    {

    }
}