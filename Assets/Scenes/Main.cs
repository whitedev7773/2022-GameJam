using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("SolaAhh2");
    }

    public void OnExitClick()
    {
        Application.Quit();
    }
}
