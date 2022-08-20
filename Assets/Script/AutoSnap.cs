using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AutoSnap : MonoBehaviour
{
    public Image small_wheel, large_wheel;
    public Image handle, seat, engine;

    public int CompletedAssemble = 0;
    public int TargetAssemble = 5;

    public string[] needs_list = { "", "", "", "", "" };

    private void Start()
    {
        DisableAllPart();
    }

    private void Update()
    {

    }

    public void DisableAllPart()
    {
        small_wheel.enabled = false;
        large_wheel.enabled = false;
        handle.enabled = false;
        seat.enabled = false;
        engine.enabled = false;
    }
}
