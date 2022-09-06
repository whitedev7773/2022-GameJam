using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Desk : MonoBehaviour
{
    // �ڽ��� ������ ������ ��� CarŬ������ �����ϴ� ������Ʈ�� ��ũ��Ʈ

    public Image SmallWheel, LargeWheel, Handle, Seat, Engine;
    public resources data;
    public Car OrderCar;
    public Person person;

    public Snap snap;

    public void Clear()
    {
        // å�� ���� �Լ�
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
            // �ƹ� �͵� �ö����� �ʴٸ� ����
            return;
        }

        QusetTime time = GameObject.Find("GameManager").GetComponent<QusetTime>();

        GameObject.Find("Check").GetComponent<AudioSource>().Play();

        Debug.Log(GetComponent<Car>().IsSameWith(OrderCar));

        int money = 0;

        if (GetComponent<Car>().IsSameWith(OrderCar))
        {
            // �ֹ��� ��ġ�Ѵٸ�
            if (time.currentTime >= time.maxTime / 2)
            {
                // �ð��� 1/2 �̻��� ������ ��
                money = 10;
            }
            else if (time.currentTime >= time.maxTime / 4)
            {
                // �ð��� 1/4 �̻��� ������ ��
                money = 7;
            }
            else if (time.currentTime > 0)
            {
                // �ð��� 1/4 ����, 0 �̻��� ��
                money = 5;
            }
            else if (time.currentTime <= 0)
            {
                // �ð��� 0�϶�
                return;
            }
        }
        else
        {
            // �ֹ��� ��ġ���� �ʴ´ٸ�
            if (time.currentTime >= time.maxTime / 2)
            {
                // �ð��� 1/2 �̻��� ������ ��
                money = 3;
            }
            else if (time.currentTime >= time.maxTime / 4)
            {
                // �ð��� 1/4 �̻��� ������ ��
                money = 2;
            }
            else if (time.currentTime > 0)
            {
                // �ð��� 1/3 ����, 0 �̻��� ��
                money = 1;
            }
            else if (time.currentTime <= 0)
            {
                // �ð��� 0�϶�
                return;
            }
        }

        if (IsThereBadGear())
        {
            data.coin += money / 2;
        }
        else
        {
            data.coin += money;
        }

        Clear();
        person.PersonExit();
        person.InvokeStart();
    }

    private bool IsThereBadGear()
    {
        Image[] Gears = { snap.SmallWheel, snap.LargeWheel, snap.Handle, snap.Seat, snap.Engine };
        Sprite[] BadGears = { snap.BrokenSmallWheel, snap.BrokenLargeWheel, snap.BrokenHandle, snap.BrokenSeat, snap.BrokenEngine };
        
        for (int i=0; i<5; i++)
        {
            if (Gears[i].sprite == BadGears[i])
            {
                return true;
            }
        }
        
        return false;
    }
}
