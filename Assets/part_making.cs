using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class part_making: MonoBehaviour
{
    public int resources_use(int part, int need_iron, int need_rubber, int need_fuel)
    {
        if (part == 0)
        {
            if (resources.iron >= need_iron && resources.rubber >= need_rubber && resources.fuel >= need_fuel)
            {
                resources.iron -= need_iron;
                resources.rubber -= need_rubber;
                resources.fuel -= need_fuel;

                int per = Random.Range(1, 100);
                if (per <= 70)
                {
                    part = 1;
                    Debug.Log(string.Format("{0}, success", per));
                }
                else
                {
                    part = 2;
                    Debug.Log(string.Format("{0}, failed", per));
                }
                Debug.Log(string.Format("iron : {0}, rubber : {1}, fuel : {2}", resources.iron, resources.rubber, resources.fuel));
            }
            else
            {
                Debug.Log("lack of resources");
            }
        }
        else
        {
            Debug.Log("Already have the parts");
        }
        return part;
    }

    void onclickbutton_big_wheel()
    {
        parts.big_wheel = resources_use(parts.big_wheel, 3, 3, 0);
    }
    void onclickbutton_small_wheel()
    {
        parts.small_wheel = resources_use(parts.small_wheel, 2, 2, 0);
    }
    void onclickbutton_engine()
    {
        parts.engine = resources_use(parts.engine, 3, 0, 4);
    }
    void onclickbutton_saddle()
    {
        parts.saddle = resources_use(parts.saddle, 2, 4, 0);
    }
    void onclickbutton_handle()
    {
        parts.handle = resources_use(parts.handle, 3, 1, 0);
    }
}