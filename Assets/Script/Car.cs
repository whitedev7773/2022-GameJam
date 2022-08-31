using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    // 자동차 구성요소들. true면 존재한다는 뜻임.
    public bool SmallWheel = false;   // 앞바퀴
    public bool LargeWheel = false;   // 뒷바퀴
    public bool Handle = false;       // 손잡이
    public bool Engine = false;       // 엔진
    public bool Seat = false;         // 운전석

    public void InitCar(bool detached_all = false)
    {
        // 차를 초기화하는 함수. true를 받으면 모든 부품이 만들어진 채로 초기화됨.
        this.SmallWheel = detached_all;   // 앞바퀴
        this.LargeWheel = detached_all;   // 뒷바퀴
        this.Handle = detached_all;       // 손잡이
        this.Engine = detached_all;       // 엔진
        this.Seat = detached_all;         // 운전석

        return;
    }

    public bool IsSameWith(Car other_car = null)
    {
        // 자동차를 전달받지 않았으면 false 반환
        if (!other_car)
        {
            Debug.Log("비교할 차를 전달받지 못함");
            return false;
        }
        else
        {
            bool[] this_car_parts = {
                this.SmallWheel, this.LargeWheel, this.Handle, this.Engine, this.Seat
            };
            bool[] other_car_parts = {
                other_car.SmallWheel, other_car.LargeWheel, other_car.Handle, other_car.Engine, other_car.Seat
            };

            for (int i=0; i<5; i++)
            {
                // i번째 부품 일치하지 않으면 false 반환
                if (this_car_parts[i] != other_car_parts[i])
                {
                    return false;
                }
            }

            // 확인 절차가 끝나면 true 반환
            return true;
        }
    }
}
