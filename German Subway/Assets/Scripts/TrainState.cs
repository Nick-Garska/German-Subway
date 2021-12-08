using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.Sprites;
using System;
using UnityEngine.UI;

public class TrainState : MonoBehaviour
{
    [SerializeField]
    private Tilemap rails;

    public object PassengerTrain { get; private set; }

    Orientation trainOrientation;
 


    //this represents the trains orientation each value is how the train is faceing
    public enum Orientation { North = 0, NorthEast = 1, SouthEast = 2, South = 3, SouthWest = 4, NorthWest = 5 };

    // Start is called before the first frame update
    void Start()
    {
        trainOrientation = 0; // at the moment the trian defaults  to faceing north theres a way called serializable to make the unity edditor be abble to set this value but for now this works


        //this should hopefuly invoke this methods every 5 seconds after a 1 second delay
        InvokeRepeating("TrainStateMachine", 1.0f, 5.0f);

        //I have no idea what this is- Nick
        // Direction Variable
        //  Orientation myOrientation;
        //  myOrientation = Orientation.South;

    }
    //I have no idea what this is trying to do like obvously its changeing orientation but thats hanndled by the TrainStateMatchine() so I dont know what this is trying to do.-Nick
    /*
        Orientation ChangeOrientation(Orientation dir)
        {
         // Get position of train


         PassengerTrain.GetType();
            if (dir == Orientation.North)
                dir = Orientation.South;
            else if (dir == Orientation.NorthEast)
                dir = Orientation.North; 
            else if (dir == Orientation.East)
                dir = Orientation.West;
            else if (dir == Orientation.West)
                dir = Orientation.East;

            return dir;
        }
     */

    // Update is called once per frame

    void Update()
    {

    }
    public Orientation GetOrientation()
    {
        return trainOrientation;
    }
    public void TrainStateMachine()
    {
        Orientation trainOrientation = GetOrientation();

        Vector3 trainPos = transform.position;
        TileBase currentHex;

        //ok this is an array of all things taged with the HexMap tag witch is just our one tilemap so tempholder[0] will return a refrence to our tilrmap
        //GameObject[] tempholder = GameObject.FindGameObjectsWithTag("HexMap");

        //turns the Gameo
        //TileMap rails = tempholder[0].GetComponent<TileMap>();


        //gets the train position on the XYZ
        //Vector3 trainPos = transform.position;


        //will find the currentHex the train is on
        //Tile currentHex = GetCurrentHex(rails, trainPos);
        currentHex = rails.GetTile(Vector3Int.RoundToInt(trainPos));


        //will change train Orientation based on the hex the train is on
        if (currentHex.ToString().Equals("Green Hex"))
        {
            //do nothing
        }
        else if (currentHex.ToString().Equals("RedHex"))
        {
            trainOrientation = (trainOrientation + 1);
        }
        else if (currentHex.ToString().Equals("Yellow Hex"))
        {
            trainOrientation = (trainOrientation - 1);
        }


        //solves the underflow problem of the Enum- cant use mod for unkown reason
        if (trainOrientation == (Orientation)(-1))
        {
            trainOrientation = (Orientation)(5);
        }
        //solves the overflow problem of the Enum
        else if (trainOrientation == (Orientation)(6))
        {
            trainOrientation = (Orientation)(0);
        }



        switch (trainOrientation)
        {

            case Orientation.North:
                trainPos= moveNorth(Vector3Int.RoundToInt(trainPos));
                break;

            case Orientation.NorthEast:
                trainPos=moveNorthEast(Vector3Int.RoundToInt(trainPos));
                break;

            case Orientation.SouthEast:
                trainPos=moveSouthEast(Vector3Int.RoundToInt(trainPos));
                break;

            case Orientation.South:
                trainPos=moveSouth(Vector3Int.RoundToInt(trainPos));
                break;

            case Orientation.SouthWest:
                trainPos=moveSouthWest(Vector3Int.RoundToInt(trainPos));
                break;

            case Orientation.NorthWest:
                trainPos=moveNorthWest(Vector3Int.RoundToInt(trainPos));
                break;
            default:
                break;
        }


    }

    private Vector3 moveNorthWest(Vector3 trainPosT)
    {
        //move half up 1 left
        float x = trainPosT.x;
        float y = trainPosT.y;
        float z = trainPosT.z;

        x = x - 1;
        y = y + 0.5f;

        trainPosT.Set(x, y, z);

        return trainPosT;
    }

    private static Tile GetCurrentHex(TileMap rails, Vector3 trainPos)
    {
        return rails.GetTile(trainPos);
    }

    private Vector3 moveSouthWest(Vector3 trainPosT)
    {
        //move half down 1 left
        float x = trainPosT.x;
        float y = trainPosT.y;
        float z = trainPosT.z;

        x = x - 1;
        y = y - 0.5f;

        trainPosT.Set(x,y,z);

        return trainPosT;


    }

    private Vector3 moveSouth(Vector3 trainPosT)
    {
        //move down 1
        float x = trainPosT.x;
        float y = trainPosT.y;
        float z = trainPosT.z;

        
        y = y - 1f;

        trainPosT.Set(x, y, z);

        return trainPosT;
    }

    private Vector3 moveSouthEast(Vector3 trainPosT)
    {
        //move half down 1 right
        float x = trainPosT.x;
        float y = trainPosT.y;
        float z = trainPosT.z;

        x = x + 1;
        y = y - 0.5f;

        trainPosT.Set(x, y, z);

        return trainPosT;
    }

    private Vector3 moveNorthEast(Vector3 trainPosT)
    {
        //move half up 1 right
        float x = trainPosT.x;
        float y = trainPosT.y;
        float z = trainPosT.z;

        x = x + 1;
        y = y + 0.5f;

        trainPosT.Set(x, y, z);

        return trainPosT;
    }

    private Vector3 moveNorth(Vector3 trainPosT)
    {
        //move up 1
        float x = trainPosT.x;
        float y = trainPosT.y;
        float z = trainPosT.z;

        
        y = y + 1f;

        trainPosT.Set(x, y, z);

        return trainPosT;
    }
}