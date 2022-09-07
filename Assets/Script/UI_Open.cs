<<<<<<< HEAD
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
=======
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Open : MonoBehaviour
{
    public Animator Create;
    public Animator Collect;

    public AudioSource sound_effect;

    public SettingBM settingUI;

    public bool AssembleOpen = false;
    public bool BuyOpen = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (AssembleOpen)
            {
                sound_effect.Play();
                Create.Play("Close");
            }
            else
            {
                if (BuyOpen)
                {
                    Collect.Play("Close");
                    BuyOpen = false;
                }
                sound_effect.Play();
                Create.Play("Open");
                settingUI.settingPn.SetActive(false);
            }
            AssembleOpen = !AssembleOpen;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (BuyOpen)
            {
                sound_effect.Play();
                Collect.Play("Close");
            }
            else
            {
                if (AssembleOpen)
                {
                    Create.Play("Close");
                    AssembleOpen = false;
                }
                sound_effect.Play();
                Collect.Play("Open");
                settingUI.settingPn.SetActive(false);
            }
            BuyOpen = !BuyOpen;
        }
    }
}
>>>>>>> f4dd1a0c93e09bc3a772c98df461a66258f48189
