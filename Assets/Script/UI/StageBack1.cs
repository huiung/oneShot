using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageBack1 : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject panel;
    GameObject panel2;
    void Start()
    {
        panel = GameObject.Find("Canvas").transform.Find("pause panel").gameObject;
        panel2 = GameObject.Find("Canvas").transform.Find("setting").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (panel2.activeSelf == true) panel2.SetActive(false);
            else if (panel.activeSelf == true) panel.SetActive(false);
            else panel.SetActive(true);
        }
    }
}
