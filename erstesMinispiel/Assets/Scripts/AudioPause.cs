using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioPause : MonoBehaviour {

    public GameObject pause;
    public GameObject play;
    public Image image;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PauseAudio()
    {
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Pause();
        play.SetActive(true);
        pause.SetActive(false);
        image.enabled = true;

    }

    public void PlayAudio()
    {
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().UnPause();
        play.SetActive(false);
        pause.SetActive(true);
        image.enabled = false;
    }
}
