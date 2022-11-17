//Made by Christian Vallvingskog

public class FloorTile : Tile
{
    public override int TileID
    {
        get
        {
            return _TileID = 1;
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