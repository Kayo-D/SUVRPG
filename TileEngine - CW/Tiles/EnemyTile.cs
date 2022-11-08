public class EnemyTile : Tile
{
    public override int TileID
    {
        get
        {
            return _TileID = 5;
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