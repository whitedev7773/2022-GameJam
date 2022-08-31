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

    // ��ü�� ������ ���� ȣ��Ǵ� �Լ�
    public void MagneticSnap()
    {
        // ���콺�� �� �� ���콺�� ��ġ ��������
        Vector2 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // ���콺�� ����ĭ�� ���� ��
        if ((181 < target.x && target.x < 500) && (120 < target.y && target.y < 220))
        {
            // �巡���ϰ� �ִ� ��Ʈ�� �������� ���� ��Ʈ���
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

            // ���� ���� ��ġ�� ���� �� 0���� �ʱ�ȭ
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
        // ���콺�� �������뿡 ���� ��
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
