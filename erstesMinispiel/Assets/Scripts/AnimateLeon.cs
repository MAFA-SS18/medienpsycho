using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateLeon : MonoBehaviour {

    public Sprite[] frames;
    double framesPerSecond = 6.0;

    // Update is called once per frame
    void Update()
    {
        int index = (int)(Time.time * framesPerSecond);
        index = index % frames.Length;
        gameObject.GetComponent<SpriteRenderer>().sprite = frames[index];
        //rend.material.mainTexture = frames[index];
    }
}
