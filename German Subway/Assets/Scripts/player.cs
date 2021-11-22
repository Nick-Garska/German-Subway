using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public Animator playAnim;


    // Start is called before the first frame update
    void Start()
    {
        playAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        float walking = Input.GetAxis("Horizontal");
        if (walking > 0f)
        {
            playAnim.SetBool("baseLayer", true);
            transform.rotation = Quaternion.Euler(0f, walking * -90f, 0f);

        }
        else if (walking < 0f)
        {
            playAnim.SetBool("baseLayer", true);
            transform.rotation = Quaternion.Euler(0f, walking * -90f, 0f);
        }
        else
        {
            playAnim.SetBool("baseLayer", false);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

    }
}
