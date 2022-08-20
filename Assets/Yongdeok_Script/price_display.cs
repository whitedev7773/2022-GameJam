using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class price_display : MonoBehaviour
{
    public Price price;
    public Text iron_display;
    public Text rubber_display;
    public Text fuel_display;

    void Update()
    {   
        if (iron_display)
        {
            iron_display.text = $"X {price.iron}";
        }
        if (rubber_display)
        {
            rubber_display.text = $"X {price.rubber}";
        }
        if (fuel_display)
        {
            fuel_display.text = $"X {price.fuel}";
        }
    }
}