using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroll : MonoBehaviour
{
    public Scrollbar scroll;
    // Start is called before the first frame update
    void Start()
    {
        int num = PlayerPrefs.GetInt("stage");


        if (num > 20 && num <= 40)
        {
            scroll.value = 0.5434484f;
        }
        else if(num > 40)
        {
            scroll.value = 1;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
