using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Open : MonoBehaviour
{
    public Animator animator;

    public bool Open = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Open)
            {
                animator.Play("Close");
            }
            else
            {
                animator.Play("Open");
            }
            Open = !Open;
        }
    }

    public void Toggle()
    {
        if (Open)
        {
            animator.Play("Close");
        }
        else
        {
            animator.Play("Open");
        }
        Open = !Open;
    }
}
