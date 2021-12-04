using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class Levers : MonoBehaviour
{
    public GameObject lever1;
    private bool lever1Open = true;
    // Start is called before the first frame update
    void Start()
    {
       lever1 = GameObject.Find("Lever");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 trainPos = transform.position;
        Tile currentHex = TileMap.getTile(trainPos);
        print("pos" + currentHex);
        if (lever1Open)
        {
           // SetTile(Vector3Int position, Tilemaps.TileBase tile);
        }
    }
}
// declare levers
// based on position, alter currentHex
