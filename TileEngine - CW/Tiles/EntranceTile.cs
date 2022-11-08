public class EntranceTile : Tile
{
    public override int TileID
    {
        get
        {
            return _TileID = 3;
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