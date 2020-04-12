using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovePiece : MonoBehaviour, IDragHandler
{

    private RectTransform t;

    void Start()
    {
        t = GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        t.position = new Vector3(Input.mousePosition.x,Input.mousePosition.y,0);
    }

}
