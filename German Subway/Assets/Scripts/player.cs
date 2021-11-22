using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    List<CircleCollider2D> inColliders = new List<CircleCollider2D>();
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            inColliders.ForEach (n => n.SendMessage("Use", SendMessageOptions.DontRequireReceiver));
        }
    }
}
