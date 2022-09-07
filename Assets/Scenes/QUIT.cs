using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QUIT : MonoBehaviour
{
    public GameObject SettingPanel;

    // Start is called before the first frame update
    public void quitsgame()
    {
        Application.Quit();
    }

    public void CloseSetting()
    {
        SettingPanel.SetActive(false);
    }
}
