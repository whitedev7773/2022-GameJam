using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Order : MonoBehaviour
{    
    [SerializeField] private float waitAmount = 0f;
    public int randIndex = 0;
    private Image order = null;
    private TextMeshProUGUI orderText = null;
    [SerializeField] public List<Sprite> orderList = new List<Sprite>();
    [SerializeField] private string[] orderTxt = {};
    private void Awake() {
        order = GameObject.Find("메인/Orders/Order").GetComponent<Image>();
        orderText = GameObject.Find("메인/Orders/OrderTxt").GetComponent<TextMeshProUGUI>();
        randIndex = Random.Range(0, orderList.Count - 1);
    }
    public void CurrnetOrder() { //현재 손님이 바뀌면서 실행된다. (랜덤으로 주문을 정함 > 스프라이트 입히기 > 3초후 Hiding 실행)
        orderText.text = ""; //Text 초기화
        randIndex = Random.Range(0, orderList.Count - 1);
        order.sprite = orderList[randIndex];
        Invoke("Hiding", waitAmount);
    }
    private void Hiding() { //CurrentOrder 메서드에 의해 호출된다. (스프라이트를 다시 덮기 > 위에 입혔던 스프라이트와 인덱스가 같은 글 가져오기)
        order.sprite = orderList[5];
        orderText.text = orderTxt[randIndex];
    }
}