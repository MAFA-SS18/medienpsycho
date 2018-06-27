using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageTrigger : MonoBehaviour {

    public Image image;
    public Button button;

    public void TriggerImage()
    {
        image.enabled = true;
        button.enabled = true;
    }

    public void CloseImage()
    {
        image.enabled = false;
        button.enabled = false;
    }
}
