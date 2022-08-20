using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    private ironbutton ironButton = null;
    //각 스크립트에서 고철, 고무, 기름, 코인의 값을 받아와서 표시
    [SerializeField] private TMP_Text coinTxt = null;
    private int coins = 0;
    [SerializeField] private TMP_Text ironTxt = null;
    private int irons = 0;
    [SerializeField] private TMP_Text rubberTxt = null;
    private int rubbers = 0;
    [SerializeField] private TMP_Text oilTxt = null;
    private int oils = 0;

    private void Awake() {
        ironButton = GameObject.Find("").GetComponent<ironbutton>();
    }
    private void Update() {
        Txts();
    }
    private void Txts() {
        // coinTxt.text = + "개";
        ironTxt.text = ironButton.iron + "개";
        // rubberTxt.text = ironButton.rubber + "개";
        oilTxt.text = ironButton.iron + "개";
    }
}