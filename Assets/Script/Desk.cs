using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Desk : MonoBehaviour
{
    // �ڽ��� ������ ������ ��� CarŬ������ �����ϴ� ������Ʈ�� ��ũ��Ʈ

    public Image SmallWheel, LargeWheel, Handle, Seat, Engine;

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

        int money = 0;
        QusetTime time = GameObject.Find("GameManager").GetComponent<QusetTime>();

        GameObject.Find("Check").GetComponent<AudioSource>().Play();

        Clear();
        if (GetComponent<Car>().IsSameWith(GetComponent<Car>()))
        {
            // �ֹ��� ��ġ�Ѵٸ�
            if (time.currentTime >= time.maxTime / 2)
            {
                // �ð��� 1/2 �̻��� ������ ��
                money += 10;
            }
            else if (time.currentTime >= time.maxTime / 4)
            {
                // �ð��� 1/4 �̻��� ������ ��
                money += 7;
            }
            else if (time.currentTime > 0)
            {
                // �ð��� 1/4 ����, 0 �̻��� ��
                money += 5;
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
                money += 3;
            }
            else if (time.currentTime >= time.maxTime / 4)
            {
                // �ð��� 1/4 �̻��� ������ ��
                money += 2;
            }
            else if (time.currentTime > 0)
            {
                // �ð��� 1/3 ����, 0 �̻��� ��
                money += 1;
            }
            else if (time.currentTime <= 0)
            {
                // �ð��� 0�϶�
                return;
            }
        }

        Debug.Log(money);
    }
}
