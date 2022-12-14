using System.Collections;
using System.Collections.Generic;
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
