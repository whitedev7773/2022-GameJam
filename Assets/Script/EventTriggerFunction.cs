using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EventTriggerFunction : MonoBehaviour
{
    public GameObject SummonGear;
    public GameObject SummonBrokenGear;
    public Sprite Broken_Image;

    public AudioSource assemble_sound, complete_sound;

    public AutoSnap autosnap;

    public Data data;

    public bool DragEnable = true;

    public void MoveToMouse()
    {
        if (DragEnable)
        {
            if (this.tag == "SmallWheel" && data.Small_Wheel[0] <= 0)
            {
                return;
            }
            else if (this.tag == "LargeWheel" && data.Large_Wheel[0] <= 0)
            {
                return;
            }
            else if (this.tag == "Handle" && data.Handle[0] <= 0)
            {
                return;
            }
            else if (this.tag == "Seat" && data.Seat[0] <= 0)
            {
                return;
            }
            else if (this.tag == "Engine" && data.Engine[0] <= 0)
            {
                return;
            }
            Vector3 m_vecMouseDownPos = Input.mousePosition;
            Vector2 pos = Camera.main.ScreenToWorldPoint(m_vecMouseDownPos);
            transform.position = pos;
        }
    }

    public void Clone()
    {
        if (this.tag == "SmallWheel" && data.Small_Wheel[0] <= 0)
        {
            return;
        }
        else if (this.tag == "LargeWheel" && data.Large_Wheel[0] <= 0)
        {
            return;
        }
        else if (this.tag == "Handle" && data.Handle[0] <= 0)
        {
            return;
        }
        else if (this.tag == "Seat" && data.Seat[0] <= 0)
        {
            return;
        }
        else if (this.tag == "Engine" && data.Engine[0] <= 0)
        {
            return;
        }
        GameObject clone = Instantiate(this.gameObject, GameObject.Find("Background").transform);
    }

    public void ScaleUp()
    {
        if (this.tag == "SmallWheel" && data.Small_Wheel[0] <= 0)
        {
            return;
        }
        else if (this.tag == "LargeWheel" && data.Large_Wheel[0] <= 0)
        {
            return;
        }
        else if (this.tag == "Handle" && data.Handle[0] <= 0)
        {
            return;
        }
        else if (this.tag == "Seat" && data.Seat[0] <= 0)
        {
            return;
        }
        else if (this.tag == "Engine" && data.Engine[0] <= 0)
        {
            return;
        }
        
        int Broken_Percentage = 15;

        if (Random.Range(0, 101) <= Broken_Percentage)
        {
            GetComponent<Image>().sprite = Broken_Image;
        }

        if (SummonGear.name == "Engine")
        {
            GetComponent<RectTransform>().sizeDelta = new Vector2(389, 227);
        }
        else if (SummonGear.name == "Handle")
        {
            GetComponent<RectTransform>().sizeDelta = new Vector2(62, 186);
        }
        else if (SummonGear.name == "Large Wheel")
        {
            GetComponent<RectTransform>().sizeDelta = new Vector2(368, 371);
        }
        else if (SummonGear.name == "Seat")
        {
            GetComponent<RectTransform>().sizeDelta = new Vector2(286, 287);
        }
        else if (SummonGear.name == "Small Wheel")
        {
            GetComponent<RectTransform>().sizeDelta = new Vector2(273, 295);
        }

        Destroy(GetComponents<EventTrigger>()[0]);
    }

    public void Snap()
    {
        if (this.tag == "SmallWheel" && data.Small_Wheel[0] <= 0)
        {
            return;
        }
        else if (this.tag == "LargeWheel" && data.Large_Wheel[0] <= 0)
        {
            return;
        }
        else if (this.tag == "Handle" && data.Handle[0] <= 0)
        {
            return;
        }
        else if (this.tag == "Seat" && data.Seat[0] <= 0)
        {
            return;
        }
        else if (this.tag == "Engine" && data.Engine[0] <= 0)
        {
            return;
        }

        Vector3 m_vecMouseDownPos = Input.mousePosition;
        Vector3 pos = Camera.main.ScreenToWorldPoint(m_vecMouseDownPos);

        if ((-6 <= pos.x && pos.x <= 6) && (-1 <= pos.y && pos.y <= 2.5))
        {
            if (this.tag == "SmallWheel")
            {
                if (autosnap.small_wheel.enabled)
                {
                    Destroy(this.gameObject);
                    return;
                }
                autosnap.small_wheel.enabled = true;
            }
            else if (this.tag == "LargeWheel")
            {
                if (autosnap.large_wheel.enabled)
                {
                    Destroy(this.gameObject);
                    return;
                }
                autosnap.large_wheel.enabled = true;
            }
            else if (this.tag == "Handle")
            {
                if (autosnap.handle.enabled)
                {
                    Destroy(this.gameObject);
                    return;
                }
                autosnap.handle.enabled = true;
            }
            else if (this.tag == "Seat")
            {
                if (autosnap.seat.enabled)
                {
                    Destroy(this.gameObject);
                    return;
                }
                autosnap.seat.enabled = true;
            }
            else if (this.tag == "Engine")
            {
                if (autosnap.engine.enabled)
                {
                    Destroy(this.gameObject);
                    return;
                }
                autosnap.engine.enabled = true;
            }

            assemble_sound.Play();
            autosnap.CompletedAssemble += 1;
            Destroy(this.gameObject);

            if (autosnap.CompletedAssemble >= autosnap.TargetAssemble)
            {
                FinishAssemble();
                complete_sound.Play();
            }
        }
    }
    
    public void FinishAssemble()
    {
        autosnap.CompletedAssemble = 0;
        autosnap.DisableAllPart();
    }
}
