﻿using UnityEngine;
//using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class DragHandeler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDragged;
    Vector3 startPosition;
    Transform startParent;

    public void OnBeginDrag(PointerEventData eventData)
    {
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        itemBeingDragged = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if(transform.parent == startParent)
        {
            transform.position = startPosition;
        }
    }
}
