using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class block : MonoBehaviour
{
    // Start is called before the first frame update

    private SpriteRenderer spriteRenderer;
    public Sprite sprites;

    moveslime instance;
    void Start()
    {
        instance = GameObject.Find("slime").GetComponent<moveslime>();
        spriteRenderer = GetComponent<SpriteRenderer>();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }    
    private void OnTriggerEnter2D(Collider2D other)
    {        
        if (other.tag.Equals("slime"))
        {
            if (spriteRenderer.sprite != sprites)
            {

                if (instance.curdir == "L")
                {
                    instance.cury--;
                }
                else if (instance.curdir == "R")
                {
                    instance.cury++;
                }
                else if (instance.curdir == "U")
                {
                    instance.curx--;
                }
                else if (instance.curdir == "D")
                {
                    instance.curx++;
                }
          
                instance.curnum++;
                spriteRenderer.sprite = sprites;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag.Equals("slime"))
        {
            StartCoroutine("colide");      
        }
    }


    IEnumerator colide()
    {
        yield return new WaitForSeconds(0.1f);
        BoxCollider2D col = gameObject.GetComponent<BoxCollider2D>();
        col.enabled = true;
    }
}
