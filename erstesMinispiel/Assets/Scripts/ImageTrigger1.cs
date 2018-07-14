using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageTrigger1 : MonoBehaviour {

    public Image image;
    public Button button;
    public GameObject obj;

    public void CloseImageBlack()
    {
        image.enabled = false;
        button.enabled = false;
    }

    public void CloseItten()
    {
        foreach (Transform child in obj.transform)
        {
            child.gameObject.SetActive(false);
        }
    }
    public void OpenItten()
    {
        foreach (Transform child in obj.transform)
        {
            child.gameObject.SetActive(true);
        }
    }
}
