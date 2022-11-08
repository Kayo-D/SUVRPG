public class WallTile : Tile
{
    public override int ID
    {
        get
        {
            return _ID = 0;
        }
    }
    public override bool canPlayerStandOnTile
    {
        get
        {
            return _canPlayerStandOnTile = false;
        }
    }
}