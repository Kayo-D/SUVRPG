//Made by Christian Vallvingskog

public class ExitTile : Tile
{
    public override int TileID
    {
        get
        {
            return _TileID = 6;
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