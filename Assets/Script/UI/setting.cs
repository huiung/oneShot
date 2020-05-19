using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setting : MonoBehaviour
{
    private GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        panel = GameObject.Find("Canvas").transform.Find("setting").gameObject;

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
