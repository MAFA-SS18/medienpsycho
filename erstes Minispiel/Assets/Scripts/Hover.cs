using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
    public string clickedOjbectName;

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        GameObject.Find(clickedOjbectName).GetComponent<Image>().enabled = true;
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        GameObject.Find(clickedOjbectName).GetComponent<Image>().enabled = false;
    }
}
