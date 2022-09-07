using System.Security.Permissions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingBM : MonoBehaviour
{
    [SerializeField] private GameObject settingPn;

    public void Setting()
    {
        if (settingPn.activeSelf)
        {
            settingPn.SetActive(false);
        }
        else
        {
            settingPn.SetActive(true);
        }
    }
}
