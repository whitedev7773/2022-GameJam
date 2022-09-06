using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class resources : MonoBehaviour
{
    public int iron = 0;
    public int rubber = 0;
    public int fuel = 0;

    public int coin = 0;

    public Text Iron_display, Rubber_display, Oil_display;
    public TextMeshProUGUI Coin_Display;

    public List<int> big_wheel = new List<int>();
    public List<int> small_wheel = new List<int>();
    public List<int> engine = new List<int>();
    public List<int> seat = new List<int>();
    public List<int> handle = new List<int>();

    private void Update()
    {
        Iron_display.text = $"{iron}개 보유 중";
        Rubber_display.text = $"{rubber}개 보유 중";
        Oil_display.text = $"{fuel}개 보유 중";
        Coin_Display.text = $"{coin}";
    }
}