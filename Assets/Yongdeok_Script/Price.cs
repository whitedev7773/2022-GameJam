using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Price : MonoBehaviour
{
    public int iron, rubber, fuel;
    public resources data;
    public string product;
    public void Buy()
    {
        if (data.iron >= iron && data.rubber >= rubber && data.fuel >= fuel)
        {
            data.iron -= iron;
            data.rubber -= rubber;
            data.fuel -= fuel;

            int per;
            if (Random.Range(1, 101) < 30)
            {
                per = 1;
            }
            else {
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
