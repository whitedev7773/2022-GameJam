using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    // [0] : 갖고있는, [1] : 필요한
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
        /*// 돈추가
        if (questtime.currentTime <= 0) // 1. 타임 아웃되면 지급 없이 바로 리턴 if
        {
            autoSnap.DisableAllPart();
            Assembled_Part.Clear();
            Assembled_Part_Object.Clear();
            return;
        }
        if (IsThereBadPart()) // 2. 불량 부품이 들어가있다면 1원 지급 후 리턴 if
        {
            AddMoney(1);
            autoSnap.DisableAllPart();
            Assembled_Part.Clear();
            Assembled_Part_Object.Clear();
            return;
        }
        if (questtime.currentTime < 30 / 4) // 3. 남은 시간이 4분의 1이하라면 3원 지급 후 리턴 if
        {
            AddMoney(3);
        }
        else if (questtime.currentTime < 30 / 2) // 4. 남은 시간아 절반 이하라면 7원 지급 후 리턴 else if
        {
            AddMoney(7);
        }
        else // 5. 남은 시간이 절반 이상이라면 10원 지급 후 리턴 else
        {
            AddMoney(10);
        }*/
        autoSnap.DisableAllPart();
        Assembled_Part.Clear();
        Assembled_Part_Object.Clear();
        // 현재 손님 내보내기
        // 새로운 손님 호출
    }

    public bool IsThereBadPart()
    {
        foreach (GameObject obj in Assembled_Part_Object)
        {
            if (obj.GetComponent<Image>().sprite.name.StartsWith("Broken"))
            {
                Debug.Log("불량 감지");
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
