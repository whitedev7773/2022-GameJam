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
