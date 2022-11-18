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
        Connection().Query($"INSERT INTO player (id, name, race, characterDescription, maxhitpoints, hitpoints, currentGold, attackdmg, armor) VALUES ({id}, '{name}', '{race}', {characterDescription}', {maxhitpoints}, {hitpoints}, {currentGold}, {attackdmg}, {armor});");
    }
    public LoadedLevel LoadLevelMap(string input)
    {
        LoadedLevel loadedLevel = new();
        var levelMapList = Connection().Query<LoadedLevel>($"SELECT currentlevel, mapData, playerStartPosX, playerStartPosY FROM leveldata;").ToList();

        foreach (LoadedLevel l in levelMapList)
        {
            if (input == l.currentlevel)
            {
                loadedLevel.currentlevel = l.currentlevel;
                loadedLevel.mapData = l.mapData;
                loadedLevel.playerStartPosX = l.playerStartPosX;
                loadedLevel.playerStartPosY = l.playerStartPosY;
            }
        }
        return loadedLevel;
    }
    public void SaveLevelMap(int currentLevel, string[,] mapData, int playerStartPosX, int playerStartPosY)
    {
        Connection().Query($"INSERT INTO leveldata (currentlevel, mapData, playerStartPosX, playerStartPosY) VALUES ({currentlevel}, '{mapData}', {playerStartPosX}, {playerStartPosY});");
    }
}