using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    // [0] : �����ִ�, [1] : �ʿ���
    public int[] Handle = { 0, 0 };
    public int[] Small_Wheel = { 0, 0 };
    public int[] Large_Wheel = { 0, 0 };
    public int[] Seat = { 0, 0 };
    public int[] Engine = { 0, 0 };

    public int TargetAssemble = 5;

    public List<string> needs_list = new List<string>();
    public List<string> Assembled_Part = new List<string>();
    public List<GameObject> Assembled_Part_Object = new List<GameObject>();

    private int TotalMoney = 0;

    public QusetTime questtime;

    public AutoSnap autoSnap;

    public bool IsCorrectA_and_B(List<string> A, List<string> B)
    {
        A.Sort();
        B.Sort();
        return List<string>.Equals(A, B);
    }

    public void SetQuest(List<string> needs, int target_amount)
    {
        needs_list = needs;
        TargetAssemble = target_amount;
    }

    public void FinishAssemble()
    {
        Debug.Log(IsThereBadPart());
        /*// ���߰�
        if (questtime.currentTime <= 0) // 1. Ÿ�� �ƿ��Ǹ� ���� ���� �ٷ� ���� if
        {
            autoSnap.DisableAllPart();
            Assembled_Part.Clear();
            Assembled_Part_Object.Clear();
            return;
        }
        if (IsThereBadPart()) // 2. �ҷ� ��ǰ�� ���ִٸ� 1�� ���� �� ���� if
        {
            AddMoney(1);
            autoSnap.DisableAllPart();
            Assembled_Part.Clear();
            Assembled_Part_Object.Clear();
            return;
        }
        if (questtime.currentTime < 30 / 4) // 3. ���� �ð��� 4���� 1���϶�� 3�� ���� �� ���� if
        {
            AddMoney(3);
        }
        else if (questtime.currentTime < 30 / 2) // 4. ���� �ð��� ���� ���϶�� 7�� ���� �� ���� else if
        {
            AddMoney(7);
        }
        else // 5. ���� �ð��� ���� �̻��̶�� 10�� ���� �� ���� else
        {
            AddMoney(10);
        }*/
        autoSnap.DisableAllPart();
        Assembled_Part.Clear();
        Assembled_Part_Object.Clear();
        // ���� �մ� ��������
        // ���ο� �մ� ȣ��
    }

    public bool IsThereBadPart()
    {
        foreach (GameObject obj in Assembled_Part_Object)
        {
            if (obj.GetComponent<Image>().sprite.name.StartsWith("Broken"))
            {
                Debug.Log("�ҷ� ����");
                return true;
            }
            Debug.Log(obj.GetComponent<Image>().sprite.name);
        }
        return false;
    }

    public void AddMoney(int amount)
    {
        TotalMoney += amount;
    }

    public void AddMoney(float amount)
    {
        TotalMoney += (int)amount;
    }

    public int MoneyValue()
    {
        return TotalMoney;
    }

    public void AddHandle(int count)
    {
        Handle[0] += count;
    }

    public void AddSmallWheel(int count)
    {
        Small_Wheel[0] += count;
    }

    public void AddLargeWheel(int count)
    {
        Large_Wheel[0] += count;
    }

    public void AddSeat(int count)
    {
        Seat[0] += count;
    }

    public void AddEngine(int count)
    {
        Engine[0] += count;
    }
}
