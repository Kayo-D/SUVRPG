public class DoorTile : Tile
{
    public override int TileID
    {
        get
        {
            return _TileID = 2;
        }
    }
    public override bool canPlayerStandOnTile
    {
        get
        {
            return _canPlayerStandOnTile = true;
        }
    }
}