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
    public SUVRPG.Player LoadPlayer(string input)
    {
        SUVRPG.Player player = new SUVRPG.Player("", "", "", 0, 0, 0, 0, 0, ConsoleColor.Green);
        var playerList = Connection().Query<SUVRPG.Player>("SELECT name, race, characterDescription, maxhitpoints, currentGold, hitpoints, attackdmg, armor FROM player;");
        foreach (SUVRPG.Player p in playerList)
        {
            if (input == p.Name)
            {
                player = new SUVRPG.Player(p.Name, p.Race, p.CharacterDescription, p.MaxHealth, p.CurrentGold, p.Health, p.AttackDmg, p.Armor, ConsoleColor.Green);
            }
        }
        return player;
    } 
    public void SavePlayer(SUVRPG.Player player)
    {
        Connection().Query($"INSERT INTO player (name, characterDescription, hitpoints, maxhitpoints, armor, attackdmg, race, currentGold) VALUES ('{player.Name}', '{player.CharacterDescription}', '{player.Health}', '{player.MaxHealth}', '{player.Armor}', '{player.AttackDmg}', '{player.Race}', '{player.CurrentGold}');");
    }

    public LoadedLevel LoadLevelMap(SUVRPG.Player player)
    {
        var id = Connection().Query($"SELECT player.id FROM player WHERE player.name = '{player.Name}'");
        LoadedLevel loadedLevel = new();
        List<LoadedLevel> mapDataList = Connection().Query<LoadedLevel>($"SELECT currentLevel, mapData, playerStartPosX, playerStartPosY FROM leveldata WHERE leveldata.playerid = {id}").ToList();
        
        foreach (var item in mapDataList)
        {
           loadedLevel.currentLevel = item.currentLevel;
           loadedLevel.mapData = item.mapData;
           loadedLevel.playerStartPosX = item.playerStartPosX;
           loadedLevel.playerStartPosY = item.playerStartPosY;
        }
        return loadedLevel;
    } 
}
  /*  public void SaveLevelMap(int currentLevel, string[,] mapData, int playerStartPosX, int playerStartPosY)
    {
        Connection().Query($"INSERT INTO leveldata (currentlevel, mapData, playerStartPosX, playerStartPosY) VALUES ({currentlevel}, '{mapData}', {playerStartPosX}, {playerStartPosY});");
    }
}*/
