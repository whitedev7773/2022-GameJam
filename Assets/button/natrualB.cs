using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ironButton : MonoBehaviour
{
    public Button ironB, rubberB, oilB;

    public int iron = 0;
    public int rubber = 0;
    public int oil = 0;
    int ic = 0;
    int rc = 0;
    int oc = 0;

    void Start()
    {
        if (ironB != null)
        {
            ironB.onClick.AddListener(Iron);
        }
        if (rubberB != null)
        {
            rubberB.onClick.AddListener(Rubber);
        }
        if (oilB != null)
        {
            oilB.onClick.AddListener(Oil);
        }
    }


    public void Iron()
    {
        ic++;
        if (ic == 5)
        {
            iron++;
            ic = 0;
        }
    }
    public void Rubber()
    {
        rc++;
        if (rc == 5)
        {
            rubber++;
            rc = 0;
        }
    }
    public void Oil()
    {
        oc++;
        if (oc == 5)
        {
            oil++;
            oc = 0;
        }
    }

}