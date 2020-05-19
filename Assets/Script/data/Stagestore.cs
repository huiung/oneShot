using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stagestore : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
        if (!PlayerPrefs.HasKey("stage"))
        {
            PlayerPrefs.SetInt("stage", 1); //초기 스테이지
        }        

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (panel.activeSelf == false)
                panel.SetActive(true);            
            else panel.SetActive(false);
        }
    }
}
