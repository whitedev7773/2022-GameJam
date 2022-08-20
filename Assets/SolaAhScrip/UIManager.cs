using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    private naturalB natural = null;
    [SerializeField] private TMP_Text coinTxt = null;
    private int coins = 0;
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
        // coinTxt.text = + "개";
        ironTxt.text = natural.iron + "개";
        rubberTxt.text = natural.rubber + "개";
        oilTxt.text = natural.oil + "개";
    }
}