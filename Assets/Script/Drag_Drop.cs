using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag_Drop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public bool actived = true;
    public static Vector2 defaultposition;

    public Snap snap;

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData) //�巡�׽����� ��
    {
        defaultposition = this.transform.position;
    }

    void IDragHandler.OnDrag(PointerEventData eventData) //�巡������ ��
    {
        Vector2 currentPos = Input.mousePosition;
        this.transform.position = currentPos;
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData) //�巡�� ������ ��
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = defaultposition;

        // ���⼭ ��ǰ ����
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
