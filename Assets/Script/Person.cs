using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Person : MonoBehaviour
{
    public Animator animator;

    public Sprite default_order;
    public Sprite[] order_papers;
    public string[] order_messages;

    public Image order;
    public TextMeshProUGUI message;

    public QusetTime time;

    public int count_of_order;
    private int random_order_number = 0;

    // 처음시작 및 주문 완료 후 새로운 주문까지의 딜레이 시간(초)
    public int order_delay;

    private void Start()
    {
        Invoke("StartFirst", order_delay);
    }

    private void Update()
    {

    }

    private void StartFirst()
    {
        time.start = true;
        Order();
    }

    public void PersonEnter()
    {
        time.start = true;
        animator.Play("Person_In");
    }

    public void PersonExit()
    {
        time.start = true;
        time.currentTime = time.maxTime;
        animator.Play("Person_Out");
    }

    public void Order()
    {
        PersonEnter();
        Car car = new Car();

        int color_number = Random.Range(0, 3);

        random_order_number = Random.Range(0, count_of_order);
        order.sprite = order_papers[random_order_number];

        // 주문에 맞게 자체 변경
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

        // wait_time초 후 메시지로 변경
        Invoke("ChangeToMessage", order_delay);
    }

    public void ChangeToMessage()
    {
        order.sprite = default_order;
        message.text = order_messages[random_order_number];
    }
}
