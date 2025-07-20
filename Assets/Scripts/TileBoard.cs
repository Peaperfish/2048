using System.Collections.Generic;
using UnityEngine;

public class TileBoard : MonoBehaviour
{
    public Tile tilePrefab;
    public TileState[] TileStates;
    
    private TileGrid grid;
    private List<Tile> tiles;

    private void Awake()
    {
        grid = GetComponentInChildren<TileGrid>();
        tiles = new List<Tile>(16);
    }

    private void Start()
    {
        CreatTile();
        CreatTile();
    }

    private void CreatTile()
    {
        Tile tile  = Instantiate(tilePrefab, grid.transform);
        tile.SetState(TileStates[0], 2);
    }
    
}
