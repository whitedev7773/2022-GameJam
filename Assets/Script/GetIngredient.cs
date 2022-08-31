using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class GetIngredient : MonoBehaviour
{
    public int iron_click, rubber_click, oil_click;
    public resources data;

    public void ClickIron()
    {
        iron_click += 1;
        if (iron_click >= 5)
        {
            iron_click = 0;
            data.iron += 1;
        }
    }

    public void ClickRubber()
    {
        rubber_click += 1;
        if (rubber_click >= 5)
        {
            rubber_click = 0;
            data.rubber += 1;
        }
    }

    public void ClickOil()
    {
        oil_click += 1;
        if (oil_click >= 5)
        {
            oil_click = 0;
            data.fuel += 1;
        }
    }
}
