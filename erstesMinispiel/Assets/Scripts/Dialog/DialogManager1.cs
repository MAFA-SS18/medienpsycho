using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogManager1 : MonoBehaviour {
    public Text nameText;
    public Text dialogText;
    private Queue<string> sentences;
    public Animator animator;
    public Button back;
    public Button black;
    public Button white;
    public Button red;
    public Button yellow;
    public Button blue;
    public bool redbool = false;
    public bool yellowbool = false;
    public bool bluebool = false;
    public GameObject obj;
    public GameObject next;


    // Use this for initialization
    void Start () {
        
        sentences = new Queue<string>();
        GameObject.Find("DialogManager").GetComponent<DialogTrigger1>().TriggerDialog();

    }

    public void StartDialog(Dialog dialog)
    {
        animator.SetBool("IsOpen", true);
        nameText.text = dialog.name;
        sentences.Clear();

        foreach (string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialog();
            if (GameObject.Find("DisableHover"))
            {
                GameObject.Find("DisableHover").SetActive(false);
            }
            back.enabled = true;
            black.enabled = true;
            white.enabled = true;
            red.enabled = true;
            yellow.enabled = true;
            blue.enabled = true;
            return;
        }
        if (obj)
        {
            if(obj.name == "Draggables")
            {
                if(sentences.Count == 5 || sentences.Count == 4)
                {
                    next.GetComponent<Image>().enabled = false;
                }
            }
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
    public void DisplayNextSentence2()
    {
        animator.SetBool("IsOpen", true);
        if (sentences.Count == 0)
        {
            if (GameObject.Find("DisableHover"))
            {
                GameObject.Find("DisableHover").SetActive(false);
            }
            EndDialog();
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogText.text += letter;
            yield return null;
        }
    }

    void EndDialog()
    {
        animator.SetBool("IsOpen", false);
    }

    public void CheckColor()
    {
        if (redbool == true && bluebool == true && yellowbool == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
	
}
