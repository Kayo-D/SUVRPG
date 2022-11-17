//Made by Christian Vallvingskog

public class BossTile : Tile
{
    public override int TileID
    {
        get
        {
            return _TileID = 7;
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