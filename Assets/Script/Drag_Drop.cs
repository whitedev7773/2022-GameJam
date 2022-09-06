using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);

        this.transform.position = defaultposition;

        // Debug.Log(worldPosition);

        // 여기서 부품 놓기
        if (446 < mousePos.x && mousePos.x < 1400 && 260 < mousePos.y && mousePos.y < 1400)
        {
            // 작업대에 놓았을 때
            snap.SnapObject(this.gameObject);
        }
        else
        {
            // 작업대에 놓지 않았을 때
        }
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
