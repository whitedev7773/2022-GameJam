using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject MusicSlider = GameObject.Find("MusicSlider");
        if (MusicSlider != null)
        {
            GetComponent<AudioSource>().volume = MusicSlider.GetComponent<Slider>().value;
        }
    }
}
