using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroBM : MonoBehaviour
{
    [SerializeField] private GameObject keyPanel = null;
    [SerializeField] private GameObject tutorialPanel = null;
    [SerializeField] private GameObject tutorial2Panel = null;

    public void key() {
        if (keyPanel.activeSelf ) {
            keyPanel.SetActive(false);
        }
        else
        {
            keyPanel.SetActive(true);
            tutorialPanel.SetActive(false);
            tutorial2Panel.SetActive(false);
        }
    }
    public void Tutorial()
    {
        if (tutorialPanel.activeSelf )
        {
            tutorialPanel.SetActive(false);
            tutorial2Panel.SetActive(false);
        }
        else
        {
            tutorialPanel.SetActive(true);
            keyPanel.SetActive(false);
        }
    }

    public void Next()
    {
        tutorialPanel.SetActive(false);
        tutorial2Panel.SetActive(true);
    }

    public void Close()
    {
        tutorial2Panel.SetActive(false);
    }
}
