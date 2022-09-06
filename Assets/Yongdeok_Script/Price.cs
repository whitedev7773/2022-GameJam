using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Price : MonoBehaviour
{
    public int pricedd;
    //public UIManager uiM;
    public resources data; //가지고 있는 iron, rubber, fuel, coin의 값을 가져오기 위함
    public string product;
    
    public void Buy()
    {
        if (data.coin >= pricedd)
        {
            data.coin -= pricedd;
            int per;
            if (Random.Range(1, 101) < 30)
            {
                per = 1;
            }
            else 
            {
                per = 0;
            }

            if (product == "big_wheel")
            {
                data.big_wheel.Add(per);
            }
            else if (product == "small_wheel")
            {
                data.small_wheel.Add(per);
            }
            else if (product == "engine")
            {
                data.engine.Add(per);
            }
            else if (product == "seat")
            {
                data.seat.Add(per);
            }
            else if (product == "handle")
            {
                data.handle.Add(per);
            }
        }
    }
}
