﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopsound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void bgmclick()
    {
        soundmanager.instance.bgmstop();
    }

    public void effectclick()
    {
        soundeffect.instance.stopeffect();
    }

}
