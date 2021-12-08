using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.Sprites;
using UnityEngine.UI;


public class Levers : MonoBehaviour
{
    [SerializeField]
    private Tilemap rails;

    public GameObject lever1;
    
    private bool lever1Open = true;
    private float delay = 1;

 
    
    

    // Start is called before the first frame update
    void Start()
    {
        lever1 = GameObject.Find("Lever");
        //rails = TileMap.Find("HexMap (1)");
        //rails = map as TileMap;

        InvokeRepeating("LocateHex", 1.0f, 5.0f);
        //StartCoroutine(LocateHex(delay));
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 trainPos = transform.position;
        //Tile currentHex = TileMap.getTile(trainPos);
        // print("pos" + currentHex);
        if (lever1Open)
        {
            // SetTile(Vector3Int position, Tilemaps.TileBase tile);
        }
    }

    public void LocateHex()
    {
        
        Vector3 trainPos = transform.position;
        TileBase currentHex;

        //rails.GetTile(trainPos);
        //yield return new WaitForSeconds(delay);

        //ok this is an array of all things taged with the HexMap tag witch is just our one tilemap so tempholder[0] will return a refrence to our tilrmap
        //GameObject[] tempholder = GameObject.FindGameObjectsWithTag("HexMap");

        //turns the Gameo
        //Tile rails = tempholder[0].GetComponent<Tile>();
        //TileMap rails = tempholder[0] as TileMap;

        //gets the train position on the XYZ



        //will find the currentHex the train is on
        if (rails == null)
        {
            print("rails");
        }
        else if (trainPos == null)
        {
            print("train");
        }
        else
        {

            //print(rails.GetTile(Vector3Int.RoundToInt(trainPos)/*) + " " + Vector3Int.RoundToInt(rails.GetTile(trainPos))*/));
        }
           
        currentHex = rails.GetTile(Vector3Int.RoundToInt(trainPos));

        print(rails.GetTile(Vector3Int.RoundToInt(trainPos)));

        //print(currentHex.ToString() + " " + trainPos);


    }

    /*private static Vector3int GetCurrentHex(Tilemap rails, Vector3 trainPos)
    {
        return rails.GetTile(trainPos);
    }*/
}
    internal class TileMap
{
    internal static Tile getTile(Vector3 trainPos)
    {
        throw new NotImplementedException();
    }

    internal Tile GetTile(Vector3 trainPos)
    {
        throw new NotImplementedException();
    }
}
// declare levers
// based on position, alter currentHex
