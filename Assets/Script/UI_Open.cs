using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Open : MonoBehaviour
{
    public Animator Create;
    public Animator Collect;

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
                Create.Play("Close");
            }
            else
            {
                if (BuyOpen)
                {
                    Collect.Play("Close");
                    BuyOpen = false;
                }
                Create.Play("Open");
                settingUI.settingPn.SetActive(false);
            }
            AssembleOpen = !AssembleOpen;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (BuyOpen)
            {
                Collect.Play("Close");
            }
            else
            {
                if (AssembleOpen)
                {
                    Create.Play("Close");
                    AssembleOpen = false;
                }
                Collect.Play("Open");
                settingUI.settingPn.SetActive(false);
            }
            BuyOpen = !BuyOpen;
        }
    }
}
