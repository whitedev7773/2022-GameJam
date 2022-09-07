using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Open : MonoBehaviour
{
    public Animator Create;
    public Animator Collect;

    public bool Open = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Open)
            {
                Create.Play("Close");
            }
            else
            {
                Collect.Play("Close");
                Create.Play("Open");
            }
            Open = !Open;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Open)
            {
                Collect.Play("Close");
            }
            else
            {
                Create.Play("Close");
                Collect.Play("Open");
            }
            Open = !Open;
        }
    }
}
