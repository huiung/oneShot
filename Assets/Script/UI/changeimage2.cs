using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//효과음 이미지 변경
public class changeimage2 : MonoBehaviour
{
    public Image image;
    public Sprite[] sprite = new Sprite[2];

    private void Start()
    {
        if (soundeffect.instance.myAudio.volume == 0)
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
        if (soundeffect.instance.myAudio.volume == 0)
            image.sprite = sprite[0];
        else
            image.sprite = sprite[1];
    }
}
