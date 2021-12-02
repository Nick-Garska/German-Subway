using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TrainStateM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating(trainStateMatchine, 0, 1.0);
		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void trainStateMatchine(){
		//this repusents the trains orientation eatch value is how the train is faceing
		enum Orientation { North = 1, NorthEast = 2, SouthEast = 3, South = 4, SouthWest=5, NorthWest=6   };
		//gets the train position on the XYZ 
		Vector3Int trainPos = transform.position;
		//will find the currentHex the train is on
		Tile currentHex=TileMap.getTile(trainPos);
		
		
		//will change train Orientation beased on the hex the train is on
		if(currentHex=Stright){
				//do nothing
			}
			else if(currentHex=Right){
				Orientation=Orientation+1;
			}
			else if(currentHex=Left){
				Orientation=Orientation-1;
			}
		
		
		
		
		switch(Orientation){
			
			case North:
			moveNorth();
			break;
			
			case NorthEast:
			moveNorthEast();
			break;
			
			case SouthEast:
			moveSouthEast();
			break;
			
			case South:
			moveSouth();
			break;
			
			case SouthWest:
			moveSouthWest();
			break;
			
			case SouthEast:
			moveSouthEast();
			break;
			
			
			
			
		}
		
	}
	
	
	



}
