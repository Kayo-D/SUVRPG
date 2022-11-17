//Made by Christian Vallvingskog

public class ErrorTile : Tile
{
    public override int TileID
    {
        get
        {
            return _TileID = 999;
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