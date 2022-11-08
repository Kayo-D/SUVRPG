public class FloorTile : Tile
{
    public override int ID
    {
        get
        {
            return _ID = 1;
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