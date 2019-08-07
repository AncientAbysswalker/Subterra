using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveController : MonoBehaviour
{
    public Sprite testSprite;
    public Sprite debugSprite;
    public Sprite gasSprite;


    Cave cave;

    // Start is called before the first frame update
    void Start()
    {
        cave = new Cave();

        // Create game objects for each tile
        for (int x = 0; x < 5; x++)
        {
            for (int y = 0; y < 5; y++)
            {
                AddTileGameObject(cave.GetTileAt(x, y), x, y);
            }
        }
    }

    float randomizeTimer = 2f;

    // Update is called once per frame
    void Update()
    {
        randomizeTimer -= Time.deltaTime;

        if(randomizeTimer < 0)
        {
            randomizeTimer = 2f;
        }
    }

    // Update is called once per frame
    void AddTileGameObject(Tile tile_data, int x, int y)
    {
        Debug.Log("TileUpdate() has been called for " + x + ", " + y);

        GameObject tile_object = new GameObject();
        tile_object.name = "Tile_" + x + "_" + y;
        tile_object.transform.position = new Vector3(x, y, 0);

        // Add a sprite renderer
        SpriteRenderer tile_sr = tile_object.AddComponent<SpriteRenderer>();
        if (tile_data.hazardGas == true)
            tile_sr.sprite = gasSprite;
        else
            tile_sr.sprite = debugSprite;
    }
}
