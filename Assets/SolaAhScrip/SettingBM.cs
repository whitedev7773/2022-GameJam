using System.Security.Permissions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingBM : MonoBehaviour
{
    public GameObject settingPn;
    public UI_Open ui;

    public AudioSource sound_effect;

    public void Setting() {
        sound_effect.Play();
        if (settingPn.activeSelf ) {
            settingPn.SetActive(false);
        }
        else {
            if (ui.AssembleOpen)
            {
                ui.Create.Play("Close");
            }
            else if (ui.BuyOpen)
            {
                ui.Collect.Play("Close");
            }
            settingPn.SetActive(true);
        }
    }
}
