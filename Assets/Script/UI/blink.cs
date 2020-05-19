using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class blink : MonoBehaviour
{
    Text flashingText;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        flashingText = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time < 0.5f)
        {
            flashingText.color = new Color(0, 0, 0, 1 - time);
        }
        else
        {
            flashingText.color = new Color(0, 0, 0, time);
            if(time > 1f)
            {
                time = 0;
            }
        }

        time += Time.deltaTime;
    }

    

}
