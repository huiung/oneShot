using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//BGM 이미지 변경
public class changeimage : MonoBehaviour
{
    public Image image;
    public Sprite []sprite = new Sprite[2];

    private void Start()
    {
        if (soundmanager.instance.myAudio.isPlaying == false)
            image.sprite = sprite[0];
        else
            image.sprite = sprite[1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change()
    {
        if(soundmanager.instance.myAudio.isPlaying == false)
            image.sprite = sprite[0];
        else 
            image.sprite = sprite[1];
    }
}
