using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    // [0] : �����ִ�, [1] : �ʿ���
    public int[] Handle = { 0, 0 };
    public int[] Small_Wheel = { 0, 0 };
    public int[] Large_Wheel = { 0, 0 };
    public int[] Seat = { 0, 0 };
    public int[] Engine = { 0, 0 };

    public int CompletedAssemble = 0;
    public int TargetAssemble = 5;

    public List<string> needs_list = new List<string>();
    public List<string> Assembled_Part = new List<string>();

    

    private int TotalMoney = 0;

    public AutoSnap autoSnap;

    public bool used_badpart = false;

    public bool IsCorrectA_and_B(List<string> A, List<string> B)
    {
        return List<string>.Equals(A, B);
    }

    public void SetQuest(List<string> needs, int target_amount)
    {
        needs_list = needs;
        TargetAssemble = target_amount;
    }

    public void FinishAssemble()
    {
        CompletedAssemble = 0;
        autoSnap.DisableAllPart();
        Assembled_Part.Clear();
        // ���߰�
        if (timeout) // 1. Ÿ�� �ƿ��Ǹ� ���� ���� �ٷ� ���� if
        {
            return;
        }
        if (used_badpart) // 2. �ҷ� ��ǰ�� ���ִٸ� 1�� ���� �� ���� if
        {
            AddMoney(1);
            return;
        }
        if (remain_time < 30 / 2) // 3. ���� �ð��� 4���� 1���϶�� 3�� ���� �� ���� if
        {
            AddMoney(3);
            return;
        }
        else if (remain_time >= 30 / 2) // 4. ���� �ð��� ���� ���϶�� 7�� ���� �� ���� else if
        {
            AddMoney(7);
            return;
        }
        else // 5. ���� �ð��� ���� �̻��̶�� 10�� ���� �� ���� else
        {
            AddMoney(10);
            return;
        }
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
