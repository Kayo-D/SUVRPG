public class RoomManager
{
    public TileEngine tileEngine = new TileEngine();
    public void ChangeRoom(string[,] levelData, int connectorID, int selectedTileYPos, int selectedTileXPos, int mapWidth)
    {
        int selectedTileID = tileEngine.SelectTile(levelData,selectedTileYPos,selectedTileXPos,mapWidth);
    }
}