using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage3 : MonoBehaviour
{
    public Image image;
    public Sprite[] sprite = new Sprite[2];
    public Text text;

    private void Start()
    {
        int mystage = int.Parse(gameObject.name);

        if (mystage <= PlayerPrefs.GetInt("stage"))
        {
            text.enabled = true;
            image.sprite = sprite[0];
        }
        else
        {
            text.enabled = false;
            image.sprite = sprite[1];
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
  
