using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Open : MonoBehaviour
{
    public Animator Create;
    public Animator Collect;
    public Animator Click;

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
                Create.Play("Open");
            }
            Open = !Open;
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            if (Open)
            {
                Collect.Play("Close");
            }
            else
            {
                Collect.Play("Open");
            }
            Open = !Open;
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            if (Open)
            {
                Click.Play("Close");
            }
            else
            {
                Click.Play("Open");
            }
            Open = !Open;
        }

    }
}
