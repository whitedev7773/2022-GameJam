using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private Order order = null;
    // 자동차 구성요소들. true면 존재한다는 뜻임.
    public bool SmallWheel = false;   // 앞바퀴
    public bool LargeWheel = false;   // 뒷바퀴
    public bool Handle = false;       // 손잡이
    public bool Engine = false;       // 엔진
    public bool Seat = false;         // 운전석

    public int AssembledPartCount = 0; // 조립파트 갯수

    private void Update()
    {
        bool[] this_car_parts = {
                this.SmallWheel, this.LargeWheel, this.Handle, this.Engine, this.Seat
        };

        int count = 0;

        for (int i=0; i<5; i++)
        {
            if (this_car_parts[i])
            {
                count += 1;
            }
        }

        AssembledPartCount = count;
    }

    private void Awake() {
        order = GameObject.Find("메인/Orders/Order").GetComponent<Order>();
    }
    public void rotlqkf() { //주문 받는 스크립트에서 현재 주문을 담는 리스트의 인덱스를 구해와서 스위치로 비교한,, 하지만 예외 처리가 없는
        switch(order.randIndex) {
            case 1 : //전부 다
                SmallWheel = true;
                LargeWheel = true;
                Handle = true;
                Engine = true;
                Seat = true;
                break;
            case 2 : //핸들 없는
                SmallWheel = true;
                LargeWheel = true;
                Handle = false;
                Engine = true;
                Seat = true;
                break;
            case 3 : //큰 바퀴 없는
                SmallWheel = true;
                LargeWheel = false;
                Handle = true;
                Engine = true;
                Seat = true;
                break;
            case 4 : //의자 없는
                SmallWheel = true;
                LargeWheel = true;
                Handle = true;
                Engine = true;
                Seat = false;
                break;
            case 5 : //엔진 없는
                SmallWheel = true;
                LargeWheel = true;
                Handle = true;
                Engine = false;
                Seat = true;
                break;
        
            }
        }
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

    public bool IsSameWith(Car B = null)
    {
        // 자동차를 전달받지 않았으면 false 반환
        if (!B)
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
                B.SmallWheel, B.LargeWheel, B.Handle, B.Engine, B.Seat
            };

            for (int i=0; i<5; i++)
            {
                Debug.Log($"P:{this_car_parts[i]} O:{other_car_parts[i]}");

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
