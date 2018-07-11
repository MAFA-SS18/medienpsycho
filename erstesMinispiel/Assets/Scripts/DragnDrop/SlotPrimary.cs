using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotPrimary : MonoBehaviour, IDropHandler
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
    public Image image;

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.gameObject.name == "orange")
        {
            if(DragHandler.itemBeingDragged.name.Contains("red") || DragHandler.itemBeingDragged.name.Contains("yellow"))
            {
                DragHandler.itemBeingDragged.transform.SetParent(transform);
            }
        }
        if (transform.gameObject.name == "violett")
        {
            if (DragHandler.itemBeingDragged.name.Contains("red") || DragHandler.itemBeingDragged.name.Contains("blue"))
            {
                DragHandler.itemBeingDragged.transform.SetParent(transform);
            }
        }
        if (transform.gameObject.name == "green")
        {
            if (DragHandler.itemBeingDragged.name.Contains("yellow") || DragHandler.itemBeingDragged.name.Contains("blue"))
            {
                DragHandler.itemBeingDragged.transform.SetParent(transform);
            }
        }

        if (transform.childCount == 2)
        {
            transform.gameObject.SetActive(false);
            GameObject.Find(transform.name + "New").GetComponent<Image>().enabled = true;
        }
        if (GameObject.Find("Draggables2").transform.childCount == 0)
        {
            GameObject.Find("Draggables2").SetActive(false);
            GameObject.Find("DropPlaces2").SetActive(false);
            this.SetActiveAllChildren(GameObject.Find("AfterTutorial").transform, false);
            GameObject.Find("Image").SetActive(false);
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
