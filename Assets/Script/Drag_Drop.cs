using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag_Drop : MonoBehaviour
{
    public resources res;


    private void Update()
    {
        if (Gate())
        {
            transform.localScale = new Vector3(0, 0, 0);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    public void MoveToMouse()
    {
        Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(target);
        transform.position = target;
    }

    public bool Gate()
    {
        if (
        (this.tag == "Engine" && res.engine.Count <= 0) ||
        (this.tag == "SmallWheel" && res.small_wheel.Count <= 0) ||
        (this.tag == "Handle" && res.handle.Count <= 0) ||
        (this.tag == "Seat" && res.seat.Count <= 0) ||
        (this.tag == "LargeWheel" && res.big_wheel.Count <= 0))
        {
            return true;
        }
        return false;
    }
}
