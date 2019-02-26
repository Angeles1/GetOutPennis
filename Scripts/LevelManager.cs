using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : Singleton<LevelManager> {
    [SerializeField]
    private GameObject tile;
    [SerializeField]
    private Transform parent;

    public float TileSize
    {
        get
        {
            return tile.GetComponent<SpriteRenderer>().sprite.bounds.size.x;
        }
        
    }

	// Use this for initialization
	void Start () {
        CreateLevel();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
  
    private void CreateLevel()
    {
        Vector3 worldStart = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height));
        Debug.Log(Screen.width);
        for (int y =0; y< 15; y++)
        {
            for (int x = 0; x<20; x++)
            {
                PlaceTile(x, y, worldStart, parent);
            }
        }

    }

    private void PlaceTile( int x, int y, Vector3 worldStart, Transform parent)
    {
        GameObject newTile = Instantiate(tile);
        newTile.transform.position = new Vector3(worldStart.x + (TileSize * x), worldStart.y -  (TileSize * y), 0);
        newTile.transform.SetParent(parent);
    }
}
