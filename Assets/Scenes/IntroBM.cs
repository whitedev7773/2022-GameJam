using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroBM : MonoBehaviour
{
    [SerializeField] private GameObject keyPanel = null;
    [SerializeField] private GameObject tutorialPanel = null;

    public void key() {
        if (keyPanel.activeSelf ) {
            keyPanel.SetActive(false);
        }
        else {keyPanel.SetActive(true);}
    }
    public void Tutorial() {
        if (tutorialPanel.activeSelf ) {
            tutorialPanel.SetActive(false);
        }
        else {tutorialPanel.SetActive(true);}
    }
}
