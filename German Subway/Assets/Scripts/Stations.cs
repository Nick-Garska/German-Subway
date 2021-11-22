using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Stations : MonoBehaviour
{
    public GameObject station1;
    public GameObject station2;
    public GameObject passenger;


    void Start()
    {
        Instantiate(station1, new Vector3(-0.7f, -3.5f, 1f), Quaternion.identity);
        Instantiate(station2, new Vector3(6.89f, -0.9f, 1f), Quaternion.identity);
        //Instantiate(passenger, new Vector3(6.89f, -0.9f, 1f), Quaternion.identity);
    }

    void TaskOnClick()
    {
        Debug.Log("Station Clicked");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform)
                {
                    Rigidbody rb;
                    if (rb = hit.transform.GetComponent<Rigidbody>())
                    {
                        SwitchTrainDirection();
                    }
                }
            }
        }
    }

    private void SwitchTrainDirection()
    {
        //Code to control train direction
        print("platform clicked");
    }
}
