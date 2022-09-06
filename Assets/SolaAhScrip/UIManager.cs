using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class UIManager : MonoBehaviour
{
    private naturalB natural = null;
    [SerializeField] private TMP_Text coinTxt = null;
    public int coins = 0;
    [SerializeField] private TMP_Text ironTxt = null;
    private int irons = 0;
    [SerializeField] private TMP_Text rubberTxt = null;
    private int rubbers = 0;
    [SerializeField] private TMP_Text oilTxt = null;
    private int oils = 0;

    private void Awake() {
        natural = GetComponent<naturalB>();
    }
    private void Update() {
        Txts();
    }
    private void Txts() {
        coinTxt.text = coins + "개";
    }
}