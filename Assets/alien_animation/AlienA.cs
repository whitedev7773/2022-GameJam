using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class A
{
    public List<Sprite> Aa = new List<Sprite>();
}
public class AlienA : MonoBehaviour
{
    /*
    public List<A> a = new List<A>();
    public Sprite t;
    private float qusetTime = 0f;
    [SerializeField] private Image qusetTimeGage = null;
    [SerializeField] private Image questTimeIcon = null;
    [SerializeField] private float maxTime = 0f;
    public float currentTime = 0f;
    public happy = Aa.ElementAt(0);
    public notbad = Aa.ElementAt(1);
    public sobad = Aa.ElementAt(2);

    private void Awake()
    {
        currentTime = maxTime;
    }
    private void Update()
    {
        TimerGage();
        TimerIcon();
    }

    
    private void TimerGage()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
        }
        qusetTimeGage.fillAmount = Mathf.Lerp(0, 1, currentTime / maxTime);
    }
    private void TimerIcon()
    {
        if (A.Contains(0))
        {
            if (qusetTimeGage.fillAmount >= 0.5)
            {
                questTimeIcon.sprite = happy;
            }
            else if (qusetTimeGage.fillAmount >= 0.25)
            {
                questTimeIcon.sprite = notbad;
            }
            else
            {
                questTimeIcon.sprite = sobad;
            }
        }

        if (A.Contains(1))
        {
            if (qusetTimeGage.fillAmount >= 0.5)
            {
                questTimeIcon.sprite = happy;
            }
            else if (qusetTimeGage.fillAmount >= 0.25)
            {
                questTimeIcon.sprite = notbad;
            }
            else
            {
                questTimeIcon.sprite = sobad;
            }
        }
        if (A.Contains(2))
        {
            if (qusetTimeGage.fillAmount >= 0.5)
            {
                questTimeIcon.sprite = happy;
            }
            else if (qusetTimeGage.fillAmount >= 0.25)
            {
                questTimeIcon.sprite = notbad;
            }
            else
            {
                questTimeIcon.sprite = sobad;
            }
        }
    } 
    */
}
