using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag_Drop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public bool actived = true;
    public static Vector2 defaultposition;

    public Snap snap;

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData) //드래그시작할 때
    {
        defaultposition = this.transform.position;
    }

    void IDragHandler.OnDrag(PointerEventData eventData) //드래그중일 때
    {
        Vector2 currentPos = Input.mousePosition;
        this.transform.position = currentPos;
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData) //드래그 끝났을 때
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = defaultposition;

        // 여기서 부품 놓기
        snap.SnapObject(this.gameObject);
    }

    public void Enable()
    {
        actived = true;
    }
    public void Disable()
    {
        actived = false;
    }
}
