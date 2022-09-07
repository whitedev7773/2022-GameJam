using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemainPartDIsplay : MonoBehaviour
{
    public resources data;

    public Text SmallWheel, LargeWheel, Handle, Engine, Seat;

    // Update is called once per frame
    void Update()
    {
        SmallWheel.text = $"{data.small_wheel.Count}�� ������";
        LargeWheel.text = $"{data.big_wheel.Count}�� ������";
        Handle.text = $"{data.handle.Count}�� ������";
        Engine.text = $"{data.engine.Count}�� ������";
        Seat.text = $"{data.seat.Count}�� ������";
    }
}
