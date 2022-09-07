using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Person : MonoBehaviour
{
    public Animator animator;
    public Image cunPerson;

    [SerializeField] private List<Sprite> personColor = new List<Sprite>();

    public Sprite default_order; //기본 주문서
    public Sprite[] order_papers; //주문서 스프라이트
    public string[] order_messages; //주문서 부가설명

    public Image order; //주문 본체
    public TextMeshProUGUI message; //부가 설명 본체

    public QusetTime time;

    public int count_of_order;
    private int random_order_number = 0;
    private int ran = 0;

    public Car car;

    // ó������ �� �ֹ� �Ϸ� �� ���ο� �ֹ������� ������ �ð�(��)
    public int order_delay;

    private void Start()
    {
        InvokeStart();
    }

    public void InvokeStart()
    {
        Invoke("StartFirst", order_delay);
    }

    private void Update() {
        SpriteChange();
    }
    private void curColor() {
        ran = Random.Range(0, 2);
    }

    private void StartFirst()
    {
        time.start = true;
        Order();
    }

    public void PersonEnter()
    {
        time.start = true;
        curColor();
        animator.Play("Person_In");
    }

    public void PersonExit()
    {
        time.start = false;
        time.ResetTime();

        order.sprite = order_papers[5];
        message.text = "";

        animator.Play("Person_Out");
    }

    public void Order()
    {
        car = GetComponent<Car>();
        PersonEnter();

        int color_number = Random.Range(0, 3);

        random_order_number = Random.Range(0, count_of_order);
        order.sprite = order_papers[random_order_number];

        // �ֹ��� �°� ��ü ����
        switch (random_order_number)
        {
            case 0:
                car.InitCar(true);
                break;
            case 1:
                car.InitCar(true);
                car.Handle = false;
                break;
            case 2:
                car.InitCar(true);
                car.LargeWheel = false;
                break;
            case 3:
                car.InitCar(true);
                car.Seat = false;
                break;
            case 4:
                car.InitCar(true);
                car.Engine = false;
                break;
        }

        // wait_time�� �� �޽����� ����
        Invoke("ChangeToMessage", order_delay);
    }

    public void ChangeToMessage()
    {
        order.sprite = default_order;
        message.text = order_messages[random_order_number];
    }
    private void SpriteChange() {
        if (time.qusetTimeGage.fillAmount > 0.5) {
            cunPerson.sprite = personColor[ran];
        }
        else if (time.qusetTimeGage.fillAmount > 0.25) {
            cunPerson.sprite = personColor[ran + 3];
        }
        else {cunPerson.sprite = personColor[ran + 6];}
    }
}
