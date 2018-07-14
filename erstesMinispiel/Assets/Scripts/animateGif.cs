using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateGif : MonoBehaviour {
    public Sprite[] frames;
    double framesPerSecond = 6.0;

    //function Update() { var index : int = Time.time * framesPerSecond; index = index % frames.Length; renderer.material.mainTexture = frames[index]; }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int index = (int)(Time.time * framesPerSecond);
        index = index % frames.Length;
        gameObject.GetComponent<SpriteRenderer>().sprite = frames[index];
        //rend.material.mainTexture = frames[index];
    }
}
