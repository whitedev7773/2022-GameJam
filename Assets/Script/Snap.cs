using System;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Snap : MonoBehaviour
{
    // 드래그 종료 후 스폰될 이미지들
    public Image SmallWheel, LargeWheel, Handle, Seat, Engine;
    public Car car = new Car();

    private void Start()
    {
        car.InitCar();

        SmallWheel.enabled = false;
        LargeWheel.enabled = false;
        Handle.enabled = false;
        Seat.enabled = false;
        Engine.enabled = false;
    }

    public void SnapObject(GameObject target)
    {
        // 각 부품들이 보관되는 리스트의 첫번째 요소가 불량인지 아닌지 확인하고 삭제
        if (target.tag == "SmallWheel")
        {
            SmallWheel.enabled = true;
            car.SmallWheel = true;
        }
        else if (target.tag == "LargeWheel")
        {
            LargeWheel.enabled = true;
            car.LargeWheel = true;
        }
        else if (target.tag == "Handle")
        {
            Handle.enabled = true;
            car.Handle = true;
        }
        else if (target.tag == "Engine")
        {
            Engine.enabled = true;
            car.Engine = true;
        }
        else
        {
            Seat.enabled = true;
            car.Seat = true;
        }
    }
}
