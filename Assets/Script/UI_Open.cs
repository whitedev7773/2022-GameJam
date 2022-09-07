using System.Security.Permissions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
                Collect.Play("Close");
                Click.Play("Close");
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
                Click.Play("Close");
                Collect.Play("Open");
            }
            Open = !Open;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (Open)
            {
                Click.Play("Close");
            }
            else
            {
                Collect.Play("Close");
                Create.Play("Close");
                Click.Play("Open");
            }
            Open = !Open;
        }
    }
}
