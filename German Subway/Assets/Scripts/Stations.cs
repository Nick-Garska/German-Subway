using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Stations : MonoBehaviour
{
	//public Button stationClicked;

	void Start()
	{
		//Button btn = stationClicked.GetComponent<Button>();
		//btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log("Station Clicked");
	}

	// Update is called once per frame
	void Update()
    {
		if(Input.GetMouseButtonDown(0))
        {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit, 100.0f))
			{
				if (hit.transform)
				{
					Rigidbody rb;
					if(rb = hit.transform.GetComponent<Rigidbody>())
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
