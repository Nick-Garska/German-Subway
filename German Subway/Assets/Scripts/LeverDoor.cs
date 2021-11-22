using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverDoor : MonoBehaviour
{
    public bool IsOpen;

    Animator myAnimator;
    Collider2D myCollider;

    // Start is called before the first frame update
    void Start() {
        myAnimator = GetComponent<Animator>();
        myCollider = GetComponent<Collider2D>();
    }

    public void Open() {
        if (!IsOpen)
            SetState(true);
    }

    public void Close() {
        if (IsOpen)
            SetState(false);
    }

    public void Toggle() {
        if (IsOpen)
            Close();
        else
            Open();
    }

    void SetState(bool open)
    {
        IsOpen = open;
        myAnimator.SetBool("Open", open);
        myCollider.isTrigger = open;
    }
}
