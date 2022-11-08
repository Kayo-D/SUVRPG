public abstract class Tile
{
    protected int _ID;
    protected bool _canPlayerStandOnTile;
    public abstract int ID { get; }
    public abstract bool canPlayerStandOnTile { get; }
    public bool isPlayerOnTile;
}