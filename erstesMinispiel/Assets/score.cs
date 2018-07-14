using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public int scorepoints = 0;
    public Text scoretext;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void scoreUpdate()
    {
        scorepoints += 1;
        scoretext.text = scorepoints.ToString();
    }

    public void resetScore()
    {
        scorepoints = 0;
        scoretext.text = scorepoints.ToString();
    }
}
