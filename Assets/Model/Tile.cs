using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{

    // Storage for cardinal direction
    bool wall_north;
    bool wall_south;
    bool wall_east;
    bool wall_west;

    // Hazard storage
    bool hazard_gas;
    bool hazard_rough;
    bool hazard_horror;
    bool hazard_water;
    bool hazard_cavein;
    bool hazard_narrow;
    bool hazard_cliff;
    bool hazard_slide;

    public bool hazardGas
    {
        get
        {
            return hazard_gas;
        }
    }

    // Extra hazard parameters
    bool hazard_caved;
    bool hazard_flooded;
    enum hazard_cliff_dir {North, South, East, West};
    enum hazard_slide_dir {North, South, East, West};

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

        this.hazard_gas = (Random.value > 0.5f);
    }
}
