using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPn : MonoBehaviour
{
    private static SettingPn s_Instance = null;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
