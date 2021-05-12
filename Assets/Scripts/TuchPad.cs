using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TuchPad : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    private Vector2 origin;
    private Vector2 direction;

    private void Awake()
    {
        direction = Vector2.zero;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        origin = eventData.position;
    }
    public void OnDrag(PointerEventData eventData)
    {
        Vector2 CurPos = eventData.position;
        Vector2 dirRaw = CurPos - origin;
        direction = dirRaw.normalized;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        direction = Vector2.zero;
    }

    public Vector2 GetDir()
    {
        return direction;
    }
}

