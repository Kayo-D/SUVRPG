//Made by Christian Vallvingskog

public abstract class Tile
{
    protected int _TileID;
    protected bool _canPlayerStandOnTile;
    protected bool _isPlayerOnTile;
    protected int _connectorID;
    public abstract int TileID { get; }
    public abstract bool canPlayerStandOnTile { get; }
    //Not currently in use. Use for further development to have events while players are standing still.
    public bool isPlayerOnTile;
    //Not currently in use. Use for further development to connect levels. Maybe have it in just exit/entry tiles
    public int connectorID;
}