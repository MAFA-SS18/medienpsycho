using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageTrigger1 : MonoBehaviour {

    public Image image;
    public Button button;

    public void CloseImageBlack()
    {
        image.enabled = false;
        button.enabled = false;
    }
}
