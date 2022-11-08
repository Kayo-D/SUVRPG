public class Loot : Tile
{
    public override int TileID
    {
        get
        {
            return _TileID = 4;
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