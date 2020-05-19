using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject panel;
    // Start is called before the first frame update
    void Awake()
    {
        panel = GameObject.Find("Canvas").transform.Find("pause panel").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click()
    {
        panel.SetActive(true);

    }

    public void cancel()
    {
        panel.SetActive(false);
    }
}
