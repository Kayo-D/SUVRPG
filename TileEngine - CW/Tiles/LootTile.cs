//Made by Christian Vallvingskog

public class LootTile : Tile
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