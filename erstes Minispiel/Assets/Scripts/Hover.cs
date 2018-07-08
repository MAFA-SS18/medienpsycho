using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hover : MonoBehaviour {
    public string clickedOjbectName;

    void OnMouseEnter()
    {
        print("Mouse is over GameObject.");
        Debug.Log("Mouse is over GameObject.");
    }

    void OnMouseExit()
    {
    }
}
