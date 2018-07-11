using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler {
    public GameObject item1
    {
        get
        {
            if(transform.childCount>0)
            {
                return transform.GetChild (0).gameObject;
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

    public void OnDrop(PointerEventData eventData)
    {
        DragHandler.itemBeingDragged.transform.SetParent(transform);
        if(transform.childCount == 2)
        {
            GameObject.Find("grayNew").GetComponent<Image>().enabled = true;
            GameObject.Find("Draggables").SetActive(false);
            GameObject.Find("DropPlaces").SetActive(false);
            this.SetActiveAllChildren(GameObject.Find("AfterTutorial").transform, true);
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
