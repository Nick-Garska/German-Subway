using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

    public GameObject Target;
    public string OnMessage;
    public string OffMessage;
    public bool IsOn = false;

    Animator myAnimator;


    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();    
    }

    public void TurnOn() {
        if (!IsOn)
            SetState(true);
    }

    public void TurnOFf() {
        if (IsOn)
            SetState(false);
    }

    public void Toggle() {
        if (IsOn)
            TurnOFf();
        else
            TurnOn();
    }

    void SetState(bool on) {
        IsOn = on;
        myAnimator.SetBool("On", on);
        if (on)
        {
            if (Target != null && !string.IsNullOrEmpty(OnMessage))
                Target.SendMessage(OnMessage);
        }
        else {
            if (Target != null && !string.IsNullOrEmpty(OffMessage))
                Target.SendMessage(OffMessage);
        }
    }

}
