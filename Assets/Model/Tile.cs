using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{

    public enum TileExplored { Unexplored, Explored };
    TileExplored state_explored = TileExplored.Unexplored;

    Cave cave;
    int x;
    int y;

    // Constructor
    public Tile( Cave cave, int x, int y )
    {
        this.cave = cave;
        this.x = x;
        this.y = y;
    }
}
