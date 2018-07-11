using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotTet : MonoBehaviour, IDropHandler {

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
    public GameObject item2
    {
        get
        {
            if (transform.childCount > 1)
            {
                return transform.GetChild(1).gameObject;
            }
            return null;
        }
    }
    private string objectName;
    private string draggedItemName;
    private GameObject draggedItem;

    public void OnDrop(PointerEventData eventData)
    {
        objectName = transform.gameObject.name;
        draggedItem = DragHandler.itemBeingDragged;
        draggedItemName = draggedItem.name;

        if (objectName == "orangeYellow")
        {
            if (draggedItemName.Contains("orange") || draggedItemName.Contains("yellow"))
            {
                draggedItem.transform.SetParent(transform);
            }
            Debug.Log(item1.name);
        }
        if (objectName == "orangeRed")
        {
            if (draggedItemName.Contains("orange") || draggedItemName.Contains("red"))
            {
                draggedItem.transform.SetParent(transform);
            }
        }
        if (objectName == "greenYellow")
        {
            if (draggedItemName.Contains("green") || draggedItemName.Contains("yellow"))
            {
                draggedItem.transform.SetParent(transform);
            }
        }
        if (objectName == "greenBlue")
        {
            if (draggedItemName.Contains("green") || draggedItemName.Contains("blue"))
            {
                draggedItem.transform.SetParent(transform);
            }
        }
        if (objectName == "violettRed")
        {
            if (draggedItemName.Contains("violett") || draggedItemName.Contains("red"))
            {
                draggedItem.transform.SetParent(transform);
            }
        }
        if (objectName == "violettBlue")
        {
            if (draggedItemName.Contains("violett") || draggedItemName.Contains("blue"))
            {
                draggedItem.transform.SetParent(transform);
            }
        }

        if (transform.childCount == 2)
        {
            transform.gameObject.SetActive(false);
            GameObject.Find(objectName + "New").GetComponent<Image>().enabled = true;
        }
        if (GameObject.Find("Draggables").transform.childCount == 0)
        {
            GameObject.Find("Draggables").SetActive(false);
            GameObject.Find("DropPlaces").SetActive(false);
            this.SetActiveAllChildren(GameObject.Find("Mixing").transform, false);
            GameObject.Find("Image").SetActive(false);
            GameObject.Find("ImageComplete").GetComponent<Image>().enabled = true;
            this.SetActiveAllChildren(GameObject.Find("AfterMixing").transform, true);

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
