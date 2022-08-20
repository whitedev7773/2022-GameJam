using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    // [0] : 갖고있는, [1] : 필요한
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
        // 돈추가
        if (timeout) // 1. 타임 아웃되면 지급 없이 바로 리턴 if
        {
            return;
        }
        if (used_badpart) // 2. 불량 부품이 들어가있다면 1원 지급 후 리턴 if
        {
            AddMoney(1);
            return;
        }
        if (remain_time < 30 / 2) // 3. 남은 시간이 4분의 1이하라면 3원 지급 후 리턴 if
        {
            AddMoney(3);
            return;
        }
        else if (remain_time >= 30 / 2) // 4. 남은 시간아 절반 이하라면 7원 지급 후 리턴 else if
        {
            AddMoney(7);
            return;
        }
        else // 5. 남은 시간이 절반 이상이라면 10원 지급 후 리턴 else
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
