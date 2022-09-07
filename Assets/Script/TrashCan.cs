using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    public Desk desk;

    public void Click()
    {
        desk.Clear();
        GetComponent<AudioSource>().Play();
    }
}
