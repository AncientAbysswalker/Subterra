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
    public Cave(int width = 0, int height = 0)
    {
        this.width = width;
        this.height = height;

        tiles = new Dictionary<Tuple<int, int>, Tile>();

        Debug.Log("World Created");
    }

    public void GenTileAt(int x, int y)
    {
        if (tiles[Tuple.Create(x, y)] == null)
        {
            tiles.Add(Tuple.Create(x, y), new Tile(this, x, y));
        }
    }

    public Tile GetTileAt(int x, int y)
    {
        return tiles[Tuple.Create(x, y)];
    }

}
