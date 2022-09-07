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
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);

        this.transform.position = defaultposition;

        // Debug.Log(worldPosition);

        // ���⼭ ��ǰ ����
        if (446 < mousePos.x && mousePos.x < 1400 && 260 < mousePos.y && mousePos.y < 1400)
        {
            // �۾��뿡 ������ ��
            snap.SnapObject(this.gameObject);
        }
        else
        {
            // �۾��뿡 ���� �ʾ��� ��
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
