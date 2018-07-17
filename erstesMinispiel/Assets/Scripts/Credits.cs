using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour {

	public void OpenCredits()
    {
        Image credImage = GameObject.Find("Credits").gameObject.GetComponent<Image>();
        credImage.enabled = !credImage.enabled;
    }

}
