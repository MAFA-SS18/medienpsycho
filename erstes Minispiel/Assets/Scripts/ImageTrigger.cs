using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageTrigger : MonoBehaviour {

    public Image image;
    public Image image1;
    public Image image2;
    public Button button;
    public bool firstTime = true;

    public void TriggerImageWhite()
    {
        image.enabled = true;
        button.enabled = true;
    }

    public void TriggerImageBlack()
    {
        image1.enabled = true;
        button.enabled = true;
    }

    public void TriggerRed()
    {
        image2.enabled = true;
        button.enabled = true;
    }

    public void CloseImage()
    {
        if (image.enabled == true)
        {
            image.enabled = false;
            if (firstTime == true)
            {
            GameObject.Find("DialogManager").GetComponent<DialogManager>().DisplayNextSentence2();
            }
            firstTime = false;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
        button.enabled = false;
    }

    public void CloseImage2()
    {
        if (image.enabled == true)
        {
            GameObject.Find("DialogManager").GetComponent<DialogManager1>().bluebool = true;
        }
        if (image1.enabled == true)
        {
            GameObject.Find("DialogManager").GetComponent<DialogManager1>().yellowbool = true;
        }
        if (image2.enabled == true)
        {
            GameObject.Find("DialogManager").GetComponent<DialogManager1>().redbool = true;
        }
        GameObject.Find("DialogManager").GetComponent<DialogManager1>().CheckColor();
        image.enabled = false;
        image1.enabled = false;
        image2.enabled = false;
        button.enabled = false;
    }
}
