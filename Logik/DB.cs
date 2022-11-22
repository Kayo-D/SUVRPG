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
        var playerList = Connection().Query<SUVRPG.Player>("SELECT name, race, characterDescription, maxhealth, currentGold, health, attackdmg, armor FROM player;");
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
        Connection().Query($"INSERT INTO player (name, characterDescription, health, maxhealth, armor, attackdmg, race, currentGold) VALUES ('{player.Name}', '{player.CharacterDescription}', '{player.Health}', '{player.MaxHealth}', '{player.Armor}', '{player.AttackDmg}', '{player.Race}', '{player.CurrentGold}');");
    }
    public LoadedLevel LoadLevelMap(SUVRPG.Player player)
    {
        List<SUVRPG.Player> playerID = Connection().Query<SUVRPG.Player>($"SELECT player.id FROM player WHERE player.name = '{player.Name}'").ToList();
        LoadedLevel loadedLevel = new LoadedLevel();
        List<LoadedLevel> mapDataList = Connection().Query<LoadedLevel>($"SELECT mapdata, currentLevel, playerStartPosX, playerStartPosY FROM leveldata WHERE leveldata.playerid = {playerID[0].ID}").ToList();
        loadedLevel.currentLevel = mapDataList[0].currentLevel;
        loadedLevel.playerStartPosX = mapDataList[0].playerStartPosX;
        loadedLevel.playerStartPosY = mapDataList[0].playerStartPosY;
        string[] temparray = new string[29];
        temparray = mapDataList[0].mapData.Split("C");
        for (int i = 0; i < temparray.Length; i++)
        {
            loadedLevel.level[i, 0] = temparray[i];
        }
        return loadedLevel;
    }
    public void SaveLevelMap(string playerName, string[,] leveldata, SUVRPG.TileEngine engine, int currentLevel)
    {
        List<SUVRPG.Player> playerID = Connection().Query<SUVRPG.Player>($"SELECT player.id FROM player WHERE player.name = '{playerName}'").ToList();
        string leveldatastring;
        string[] tempArray = new string[29];
        for (int i = 0; i < leveldata.Length; i++)
        {
            string addSeperator = leveldata[i, 0].Insert(45, "C");
            tempArray[i] = addSeperator;
        }
        leveldatastring = String.Join("",tempArray);
        Console.WriteLine(leveldatastring);
        Connection().Query($"INSERT INTO leveldata (playerid, mapData, playerStartPosX, playerStartPosY, currentLevel) VALUES ('{playerID[0]}', '{leveldatastring}', '{engine.currentPlayerPosX}', '{engine.currentPlayerPosY}', '{currentLevel}');");
    }
}


