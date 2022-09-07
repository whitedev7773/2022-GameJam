using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QusetTime : MonoBehaviour
{
    private float qusetTime = 0f;
    [SerializeField] public Image qusetTimeGage = null;
    [SerializeField] private Image questTimeIcon = null;
    public float maxTime = 0f;
    public float currentTime = 0f;
    [SerializeField] private Sprite happy = null;
    [SerializeField] private Sprite notbad = null;
    [SerializeField] private Sprite sobad   = null;

    public bool start = false;
    
    private void Awake() {
        currentTime = maxTime;
    }
    private void Update() {
        if (!start)
        {
            return;
        }
        TimerGage();
        TimerIcon();
    }
    private void TimerGage() {
        if (currentTime > 0) {
            currentTime -= Time.deltaTime;
        }
        qusetTimeGage.fillAmount = Mathf.Lerp(0, 1, currentTime / maxTime);
    }
    private void TimerIcon() {
        if (qusetTimeGage.fillAmount > 0.5) {
            questTimeIcon.sprite = happy;
        }
        else if (qusetTimeGage.fillAmount > 0.25) {
            questTimeIcon.sprite = notbad;
        }
        else {questTimeIcon.sprite = sobad;}
    }

    public void StartTime()
    {
        start = true;
    }

    public void ResetTime()
    {
        start = false;
        currentTime = maxTime;
        qusetTimeGage.fillAmount = 1;
    }
}
