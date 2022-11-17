//Made by Christian Vallvingskog

public class WallTile : Tile
{
    public override int TileID
    {
        get
        {
            return _TileID = 0;
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