using System;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Snap : MonoBehaviour
{
    public resources res;
    public Sprite Broken;

    public GameObject Parent;

    public Image target_image;
    public Image s_wheel_sprite, l_wheel_sprite, handle_sprite, engine_sprite, seat_sprite;

    private int current_assemble_count = 0;
    private Car car = new Car();

    // 물체를 누르고 때면 호출되는 함수
    public void MagneticSnap()
    {
        // 마우스를 땐 후 마우스의 위치 가져오기
        Vector2 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // 마우스가 조립칸에 있을 때
        if ((181 < target.x && target.x < 500) && (120 < target.y && target.y < 220))
        {
            // 드래그하고 있는 파트가 조립되지 않은 파트라면
            if (!FindPart(this.gameObject.tag).GetComponent<Image>().enabled)
            {
                switch (this.gameObject.tag)
                {
                    case "SmallWheel":
                        car.SmallWheel = true;
                        break;
                    case "LargeWheel":
                        car.LargeWheel = true;
                        break;
                    case "Handle":
                        car.Handle = true;
                        break;
                    case "Engine":
                        car.Engine = true;
                        break;
                    case "Seat":
                        car.Seat = true;
                        break;
                }

                current_assemble_count++;
                DisplayPart(this.gameObject.tag, true);
            }

            // 조립 수로 합치면 조립 수 0으로 초기화
            if (current_assemble_count >= car.target_assemble_count)
            {
                current_assemble_count = 0;
                DisplayPart("SmallWheel", false);
                DisplayPart("LargeWheel", false);
                DisplayPart("Handle", false);
                DisplayPart("Engine", false);
                DisplayPart("Seat", false);
            }

            GameObject clone = Instantiate(this.gameObject, Parent.transform);
            Destroy(this.gameObject);
        }
        // 마우스가 쓰레기통에 있을 때
        else if ((32 < target.x && target.x < 87) && (114 < target.y && target.y < 243))
        {
            GameObject clone = Instantiate(this.gameObject, Parent.transform);
            Destroy(this.gameObject);
        }
    }

    public void DisplayPart(string part_tag, bool will_show = true)
    {
        FindPart(part_tag).GetComponent<Image>().enabled = will_show;
    }

    public GameObject FindPart(string part_tag)
    {
        return GameObject.Find(part_tag);
    }
}
