using UnityEngine;
using PathCreation;
using System.Diagnostics;
using System.Collections;
using System;
using System.Globalization;
using System.Collections.Generic;
using UnityEngine.UI;

public class Follower : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5;
    float distanceTraveled;
    public Vector3 station1pos;
    public Vector3 station2pos;
    public Stopwatch stopwatch;
    private float fallTime;
    private GameObject train;
    private GameObject passenger;
    private bool sleeping;
    public float timer = 7;
    private int num = 1;
    public Player passengerP;
    //GameObject anyObjectWhichShouldBeTheParentOfThisOne = GameObject.Find("NameOfTheObjectWhichIsGoingToBeTheParent");

    float t = 0;
    bool pause = false;

    // Start is called before the first frame update
    void Start()
    {
        train = GameObject.Find("PassengerTrain");
        passenger = GameObject.Find("player");
        Instantiate(passenger, new Vector3(6.89f, -0.9f, 1f), Quaternion.identity);

        //trainWpassenger.GetComponent<Renderer>().enabled = false;
        t = timer;
    }

    // Update is called once per frame
    void Update()
    {
        station1pos.Set(-0.9f, -2.3f, 0.0f);
        station2pos.Set(5.5f, -1.1f, 0.0f);
        distanceTraveled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTraveled);
        //transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTraveled);

        //print(station1pos + " " + pathCreator.path.GetPointAtDistance(distanceTraveled));
        if(String.Compare(pathCreator.path.GetPointAtDistance(distanceTraveled).ToString(), station1pos.ToString()) == 0
            || String.Compare(pathCreator.path.GetPointAtDistance(distanceTraveled).ToString(), station2pos.ToString()) == 0)
        {
            
            //distanceTraveled = 0;
            //System.Threading.Thread.Sleep(500);

            stopwatch = Stopwatch.StartNew();
            while (true)
            {
                //some other processing to do STILL POSSIBLE
                if (stopwatch.ElapsedMilliseconds >= 1000)
                {
                    break;
                }
                System.Threading.Thread.Sleep(1); //so processor can rest for a while
            }

            if (num % 2 == 1) 
            {
                //GameObject go;


                // passenger = Instantiate(player, spawnpos, Quaternion.identity) as GameObject;
                //passenger.transform.parent = transform;
                //Instantiate(m_Prefab, (0, 0, 0), (0, 0, 0) as GameObject).transform.parent = parentGameObject.transform;
                if (passenger != null) { passenger.transform.parent = train.transform; }
                //passenger.transform.Translate(0, 0, 0);
            }
            else 
            {
                //passenger.transform.parent = null;
                //Destroy(passenger);
                
                Instantiate(passenger, new Vector3(6.89f, -0.9f, 1f), Quaternion.identity);
            }
            num++;

            //train.GetComponent<Renderer>().enabled = false;
            //trainWpassenger.GetComponent<Renderer>().enabled = true;

            //this.transform.parent = parentTrain;
            /*if (fallTime > 1.0f)
            {
                if (sleeping)
                {
                    rbGO.WakeUp();
                    print("wakeup");
                }
                else
                {
                    rbGO.Sleep();
                    print("sleep");
                }

                sleeping = !sleeping;

                fallTime = 0.0f;
            }

            fallTime += Time.deltaTime;*/

            /* if (t < 0)
             {
                 t = timer;
                 pause = false;
                 time.timescale = 1;
             }
             else
             {
                 t -= Time.deltaTime;
                 time.timescale = 0;
             }*/

        }
    }
}
