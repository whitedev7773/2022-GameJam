using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    //각 스크립트에서 고철, 고무, 기름, 코인의 값을 받아와서 표시
    [SerializeField] private TMP_Text coinTxt;
    private int coins = 0;
    [SerializeField] private TMP_Text tlqkfTxt;
    private int tlqkf = 0;
    [SerializeField] private TMP_Text oilTxt;
    private int oils = 0;
    [SerializeField] private TMP_Text dkdkdkd;
    private int dkdkdkdk = 0;

    private void Awake() {
        
    }
}