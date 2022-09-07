using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class resources : MonoBehaviour
{
    public int coin = 0;
    public TextMeshProUGUI Coin_Display;

    public List<int> big_wheel = new List<int>();
    public List<int> small_wheel = new List<int>();
    public List<int> engine = new List<int>();
    public List<int> seat = new List<int>();
    public List<int> handle = new List<int>();

    private void Update()
    {
        Coin_Display.text = $"{coin}";
    }
}