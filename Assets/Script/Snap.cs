using System;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Snap : MonoBehaviour
{
    // 드래그 종료 후 스폰될 이미지들
    public Image SmallWheel, LargeWheel, Handle, Seat, Engine;

    public Sprite RightSmallWheel, RightLargeWheel, RightHandle, RightSeat, RightEngine;
    public Sprite BrokenSmallWheel, BrokenLargeWheel, BrokenHandle, BrokenSeat, BrokenEngine;

    public resources data;

    public Car car;

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
            if (data.small_wheel.Count <= 0 || SmallWheel.enabled)
            {
                return;
            }
            if (data.small_wheel[0] == 1)
            {
                SmallWheel.sprite = BrokenSmallWheel;
            }
            else
            {
                SmallWheel.sprite = RightSmallWheel;
            }
            SmallWheel.enabled = true;
            car.SmallWheel = true;

            data.small_wheel.RemoveAt(0);

            GetComponent<AudioSource>().pitch = Random.Range(0.7f, 1.7f);
            GetComponent<AudioSource>().Play();
        }
        else if (target.tag == "LargeWheel")
        {
            if (data.big_wheel.Count <= 0 || LargeWheel.enabled)
            {
                return;
            }
            if (data.big_wheel[0] == 1)
            {
                LargeWheel.sprite = BrokenLargeWheel;
            }
            else
            {
                LargeWheel.sprite = RightLargeWheel;
            }
            LargeWheel.enabled = true;
            car.LargeWheel = true;

            data.big_wheel.RemoveAt(0);

            GetComponent<AudioSource>().pitch = Random.Range(0.7f, 1.7f);
            GetComponent<AudioSource>().Play();
        }
        else if (target.tag == "Handle")
        {
            if (data.handle.Count <= 0 || Handle.enabled)
            {
                return;
            }
            if (data.handle[0] == 1)
            {
                Handle.sprite = BrokenHandle;
            }
            else
            {
                Handle.sprite = RightHandle;
            }
            Handle.enabled = true;
            car.Handle = true;

            data.handle.RemoveAt(0);

            GetComponent<AudioSource>().pitch = Random.Range(0.7f, 1.7f);
            GetComponent<AudioSource>().Play();
        }
        else if (target.tag == "Engine")
        {
            if (data.engine.Count <= 0 || Engine.enabled)
            {
                Debug.Log("무시");
                return;
            }
            if (data.engine[0] == 1)
            {
                Engine.sprite = BrokenEngine;
            }
            else
            {
                Engine.sprite = RightEngine;
            }
            Engine.enabled = true;
            car.Engine = true;

            data.engine.RemoveAt(0);

            GetComponent<AudioSource>().pitch = Random.Range(0.7f, 1.7f);
            GetComponent<AudioSource>().Play();
        }
        else
        {
            if (data.seat.Count <= 0 || Seat.enabled)
            {
                return;
            }
            if (data.seat[0] == 1)
            {
                Seat.sprite = BrokenSeat;
            }
            else
            {
                Seat.sprite = RightSeat;
            }
            Seat.enabled = true;
            car.Seat = true;

            data.seat.RemoveAt(0);

            GetComponent<AudioSource>().pitch = Random.Range(0.7f, 1.7f);
            GetComponent<AudioSource>().Play();
        }
    }
}
