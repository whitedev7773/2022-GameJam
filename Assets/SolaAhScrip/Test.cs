using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class A {
    public List<Sprite> a = new List<Sprite>();
}
public class Test : MonoBehaviour
{
    [SerializeField] public List<A> aa = new List<A>();
    private QusetTime qusetTime = null;
    private Sprite tleos = null;
   [SerializeField] private float currnetTime = 0f;
    private int ranIndex = 0;
    private int min = 0, max = 2;
    private void Awake() {
        tleos = GameObject.Find("tlqkf").GetComponent<Sprite>();
        qusetTime = GameObject.Find("GameManager").GetComponent<QusetTime>();
    }
    private void Update() {
        tiqkf();
        currnetTime = qusetTime.qusetTimeGage.fillAmount;
    }
    private void tiqkf() {
        ranIndex = UnityEngine.Random.Range(min, max);
        tleos = aa[ranIndex].a[0]; //ranIndex 는 aa의 인덱스로 색을 결정하고 0 은 정해진 색의 인덱스로 1단계를 의미한다.
    }
    private void tlqkf() {
        if (currnetTime > 0.5) {
            tleos = aa[ranIndex].a[0];
        }
        else if (currnetTime > 0.25) {
            tleos = aa[ranIndex].a[1];
        }
        else {tleos = aa[ranIndex].a[2];}
    }
}
