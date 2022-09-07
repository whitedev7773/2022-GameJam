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
        SmallWheel.text = $"{data.small_wheel.Count}개 보유중";
        LargeWheel.text = $"{data.big_wheel.Count}개 보유중";
        Handle.text = $"{data.handle.Count}개 보유중";
        Engine.text = $"{data.engine.Count}개 보유중";
        Seat.text = $"{data.seat.Count}개 보유중";
    }
}
