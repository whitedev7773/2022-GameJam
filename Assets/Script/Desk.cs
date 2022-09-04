using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Desk : MonoBehaviour
{
    // 자신이 조립한 정보가 담긴 Car클래스가 존재하는 오브젝트용 스크립트

    public Image SmallWheel, LargeWheel, Handle, Seat, Engine;

    public void Clear()
    {
        // 책상 정리 함수
        GetComponent<Car>().InitCar();
        SmallWheel.enabled = false;
        LargeWheel.enabled = false;
        Handle.enabled = false;
        Seat.enabled = false;
        Engine.enabled = false;
    }

    public void Finish()
    {
        if (false == SmallWheel.enabled && false == LargeWheel.enabled && false == Handle.enabled &&
            false == Seat.enabled && false == Engine.enabled)
        {
            // 아무 것도 올라가있지 않다면 무시
            return;
        }

        int money = 0;
        QusetTime time = GameObject.Find("GameManager").GetComponent<QusetTime>();

        GameObject.Find("Check").GetComponent<AudioSource>().Play();

        Clear();
        if (GetComponent<Car>().IsSameWith(GetComponent<Car>()))
        {
            // 주문과 일치한다면
            if (time.currentTime >= time.maxTime / 2)
            {
                // 시간의 1/2 이상을 남겼을 때
                money += 10;
            }
            else if (time.currentTime >= time.maxTime / 4)
            {
                // 시간의 1/4 이상을 남겼을 때
                money += 7;
            }
            else if (time.currentTime > 0)
            {
                // 시간의 1/4 이하, 0 이상일 때
                money += 5;
            }
            else if (time.currentTime <= 0)
            {
                // 시간이 0일때
                return;
            }
        }
        else
        {
            // 주문과 일치하지 않는다면
            if (time.currentTime >= time.maxTime / 2)
            {
                // 시간의 1/2 이상을 남겼을 때
                money += 3;
            }
            else if (time.currentTime >= time.maxTime / 4)
            {
                // 시간의 1/4 이상을 남겼을 때
                money += 2;
            }
            else if (time.currentTime > 0)
            {
                // 시간의 1/3 이하, 0 이상일 때
                money += 1;
            }
            else if (time.currentTime <= 0)
            {
                // 시간이 0일때
                return;
            }
        }

        Debug.Log(money);
    }
}
