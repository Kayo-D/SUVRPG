public abstract class Tile
{
    protected int _TileID;
    protected bool _canPlayerStandOnTile;
    protected bool _isPlayerOnTile;
    protected int _connectorID;
    public abstract int TileID { get; }
    public abstract bool canPlayerStandOnTile { get; }
    public bool isPlayerOnTile;
    public int connectorID;
}