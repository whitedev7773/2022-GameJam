using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class price_display : MonoBehaviour
{
    public Price price;
    public Text priceTxt;

    void Update()
    {
        priceTxt.text = $"X {price.pricedd}";
    }
}