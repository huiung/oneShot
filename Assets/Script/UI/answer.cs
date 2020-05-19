using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class answer : MonoBehaviour
{

    moveslime instance;
    bool flag;
    // Start is called before the first frame update
    void Start()
    {
        instance = GameObject.Find("slime").GetComponent<moveslime>();
        flag = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
