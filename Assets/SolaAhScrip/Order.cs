using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Order : MonoBehaviour
{
    //리스트?,,를 만들어서 5종류의 주문을 리스트에 넣어둔다.
    //랜덤으로 리스트 5종 중 하나를 뽑아 현재 주문에 넣는다.
    //order 이미지에 뽑힌 리스트 이미지를 넣고
    //3초 후 디스트로이 한다.
    //디스트로이 한 직후 주문서 배경에 뽑힌 리스트와 연결된 문장이 나온다?
    [SerializeField] private List<Sprite> orderList = new List<Sprite>();
    private Image currentOrder = null;
    private void Update() {
        
    }
    private void CarOrder() {
        int minType = 1, maxType = 6;
        int Type = Random.Range(minType, maxType);
    }
}
