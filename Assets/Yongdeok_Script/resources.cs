using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resources : MonoBehaviour
{
    public int iron = 0;
    public int rubber = 0;
    public int fuel = 0;

    public Text Iron_display, Rubber_display, Oil_display;

    public List<int> big_wheel = new List<int>();
    public List<int> small_wheel = new List<int>();
    public List<int> engine = new List<int>();
    public List<int> seat = new List<int>();
    public List<int> handle = new List<int>();

    private void Update()
    {
        Iron_display.text = $"{iron}�� ���� ��";
        Rubber_display.text = $"{rubber}�� ���� ��";
        Oil_display.text = $"{fuel}�� ���� ��";
    }
}