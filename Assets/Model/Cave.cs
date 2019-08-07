using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Cave
{
    // Map initialized <tuple> locations to their associated tiles
    Dictionary<Tuple<int, int>, Tile> tiles;
    int width;
    int height;

    // Constructor
    public Cave(int width = 5, int height = 5)
    {
        this.width = width;
        this.height = height;

        tiles = new Dictionary<Tuple<int, int>, Tile>();

        // This is testing
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                GenTileAt(x, y);
                Debug.Log("TileGen() has been called at " + x + ", " + y);
            }
        }

        Debug.Log("World Created");
    }

    public void GenTileAt(int x, int y)
    {
        if (!tiles.ContainsKey(Tuple.Create(x, y)))
        {
            tiles.Add(Tuple.Create(x, y), new Tile(this, x, y));
        }
    }

    public Tile GetTileAt(int x, int y)
    {
        return tiles[Tuple.Create(x, y)];
    }

}
