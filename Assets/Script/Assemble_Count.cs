using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Assemble_Count : MonoBehaviour
{
    public int coin_amount;

    public TextMeshProUGUI coin_display;

    public int count=0;
    public Image s_wheel, l_wheel, handle, engine, seat;

    public Person person;

    public QusetTime time;

    private void Update()
    {
        coin_display.text = $"{coin_amount}¿ø";

        if (count >= 5)
        {
            person.PersonExit();
            person.Order();
            person.PersonEnter();
            count = 0;
            if (time.currentTime > time.maxTime / 2)
            {
                coin_amount += 5;
            }
            else if (time.currentTime > time.maxTime / 4)
            {
                coin_amount += 3;
            }
            else
            {
                coin_amount += 1;
            }
            time.currentTime = time.maxTime;
            s_wheel.enabled = false;
            l_wheel.enabled = false;
            handle.enabled = false;
            engine.enabled = false;
            seat.enabled = false;
        }
    }
}
