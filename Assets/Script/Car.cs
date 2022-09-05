using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private Order order = null;
    // �ڵ��� ������ҵ�. true�� �����Ѵٴ� ����.
    public bool SmallWheel = false;   // �չ���
    public bool LargeWheel = false;   // �޹���
    public bool Handle = false;       // ������
    public bool Engine = false;       // ����
    public bool Seat = false;         // ������

    // �����Ǿ���ϴ� ��Ʈ�� ����
    public int target_assemble_count = 0;

    private void Awake() {
        order = GameObject.Find("����/Orders/Order").GetComponent<Order>();
    }
    public void rotlqkf() { //�ֹ� �޴� ��ũ��Ʈ���� ���� �ֹ��� ��� ����Ʈ�� �ε����� ���ؿͼ� ����ġ�� ����,, ������ ���� ó���� ����
        switch(order.randIndex) {
            case 1 : //���� ��
                SmallWheel = true;
                LargeWheel = true;
                Handle = true;
                Engine = true;
                Seat = true;
                break;
            case 2 : //�ڵ� ����
                SmallWheel = true;
                LargeWheel = true;
                Handle = false;
                Engine = true;
                Seat = true;
                break;
            case 3 : //ū ���� ����
                SmallWheel = true;
                LargeWheel = false;
                Handle = true;
                Engine = true;
                Seat = true;
                break;
            case 4 : //���� ����
                SmallWheel = true;
                LargeWheel = true;
                Handle = true;
                Engine = true;
                Seat = false;
                break;
            case 5 : //���� ����
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
        // ���� �ʱ�ȭ�ϴ� �Լ�. true�� ������ ��� ��ǰ�� ������� ä�� �ʱ�ȭ��.
        this.SmallWheel = detached_all;   // �չ���
        this.LargeWheel = detached_all;   // �޹���
        this.Handle = detached_all;       // ������
        this.Engine = detached_all;       // ����
        this.Seat = detached_all;         // ������

        return;
    }

    public bool IsSameWith(Car other_car = null)
    {
        // �ڵ����� ���޹��� �ʾ����� false ��ȯ
        if (!other_car)
        {
            Debug.Log("���� ���� ���޹��� ����");
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
                // i��° ��ǰ ��ġ���� ������ false ��ȯ
                if (this_car_parts[i] != other_car_parts[i])
                {
                    return false;
                }
            }

            // Ȯ�� ������ ������ true ��ȯ
            return true;
        }
    }
}
