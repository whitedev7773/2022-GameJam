using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class Data : MonoBehaviour
{
    // [0] : 갖고있는, [1] : 필요한
    public int[] Handle = { 0, 0 };
    public int[] Small_Wheel = { 0, 0 };
    public int[] Large_Wheel = { 0, 0 };
    public int[] Seat = { 0, 0 };
    public int[] Engine = { 0, 0 };

    private int TotalMoney = 0;

    public float CalculateRoundMoney(float default_money, float time, bool is_correct)
    {
        if (is_correct)
        {
            return default_money / time;
        }
        else
        {
            return (default_money / time) * 0.7f;
        }
    }

    public void AddMoney(int amount)
    {
        TotalMoney += amount;
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
