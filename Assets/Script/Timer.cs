using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int second = -1;
    private bool stop = false;

    private void Start()
    {
        StartTime();
    }

    public void ResetTime()
    {
        second = -1;
        stop = false;
    }

    public void StartTime()
    {
        if (stop)
        {
            return;
        }
        else
        {
            AddSecond();
            Invoke("StartTime", 1);
        }
    }

    private void AddSecond()
    {
        second += 1;
    }

    public void Stop()
    {
        stop = true;
    }
}
