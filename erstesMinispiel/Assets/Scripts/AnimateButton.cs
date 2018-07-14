using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimateButton : MonoBehaviour {
    double framesPerSecond = 2.0;
    int states = 2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int index = (int)(Time.time * framesPerSecond);
        index = index % states;
        if(index == 0)
        {
            gameObject.GetComponent<Image>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<Image>().enabled = false;
        }
    }
}
