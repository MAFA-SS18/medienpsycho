using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotMalen : MonoBehaviour, IDropHandler
{

    public GameObject item1
    {
        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }
    private Transform spritesObject;
    private Transform palette;

    public void Start()
    {
        spritesObject = GameObject.Find("Sprites").transform;
        palette = GameObject.Find("Palette").transform;
    }

    public void OnDrop(PointerEventData eventData)
    {
        string objectName = transform.gameObject.name;
        GameObject draggedItem = DragHandler.itemBeingDragged;

        if(draggedItem.name == objectName)
        {
            draggedItem.transform.SetParent(transform);
 
            spritesObject.Find(objectName).gameObject.GetComponent<Image>().enabled = true;
            if(objectName == "black" || objectName == "grey" || objectName == "blue")
            {
                spritesObject.Find(objectName+1).gameObject.GetComponent<Image>().enabled = true;
                if(objectName == "black")
                {
                    spritesObject.Find(objectName + 2).gameObject.GetComponent<Image>().enabled = true;
                }
            }
            transform.gameObject.SetActive(false);

        }
        if(palette.childCount == 2)
        {
            spritesObject.gameObject.SetActive(false);
            GameObject.Find("ImageComplete").GetComponent<Image>().enabled = true;
        }
    }

    private void SetActiveAllChildren(Transform transform, bool value)
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(value);
        }
    }

}
