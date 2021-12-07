using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.Sprites;
using System;

public class TrainStateM : MonoBehaviour
{
    public object PassengerTrain { get; private set; }

    Orientation trainOrientation;

    //this represents the trains orientation each value is how the train is faceing
   public enum Orientation { North = 0, NorthEast = 1, SouthEast = 2, South = 3, SouthWest = 4, NorthWest = 5 };

    // Start is called before the first frame update
    void Start()
    {
        trainOrientation = 0; // at the moment the trian defaults  to faceing north theres a way called serializable to make the unity edditor be abble to set this value but for now this works

        
        //this should hopefuly invoke this methods every 5 seconds after a 1 second delay
        InvokeRepeating("TrainStateMachine(trainOrientation)", 1.0f, 5.0f);




       

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

 
       public void TrainStateMachine(Orientation trainOrientation)
       {

        Tilemap rails= this.FindGameObjectsWithTag("HexMap");

        //gets the train position on the XYZ
        Vector2 trainPos = transform.position;
           


        //this stuff down here has the red underline because it needsa refrence to the tilemap which im trying to get above by giveing it a tag and then useing the get taged object method
        // which is a funtion of gameobject which should be this but its not and I dont know why I pass the torch to someone else now.


           //will find the currentHex the train is on
           Tile currentHex = Tilemap.getTile(trainPos);
        
            //will change train Orientation based on the hex the train is on
            if (currentHex.ToString == "Green Hex")
            {
                //do nothing
            }
            else if (currentHex.ToString == "RedHex")
            {
            trainOrientation = (trainOrientation + 1)%6;
            }
            else if (currentHex.ToString == "Yellow Hex")
            {
            trainOrientation = (trainOrientation - 1)%6;
            }
     
        switch (trainOrientation)
        {

            case Orientation.North:
                moveNorth();
                break;

            case Orientation.NorthEast:
                moveNorthEast();
                break;

            case Orientation.SouthEast:
                moveSouthEast();
                break;

            case Orientation.South:
                moveSouth();
                break;

            case Orientation.SouthWest:
                moveSouthWest();
                break;

            case Orientation.NorthWest:
                moveSouthEast();
                break;
            default:
                break;
        }


    }

    private void moveSouthWest()
    {
        throw new NotImplementedException();
    }

    private void moveSouth()
    {
        throw new NotImplementedException();
    }

    private void moveSouthEast()
    {
        throw new NotImplementedException();
    }

    private void moveNorthEast()
    {
        throw new NotImplementedException();
    }

    private void moveNorth()
    {
        throw new NotImplementedException();
    }
}
