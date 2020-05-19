using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileclickans : MonoBehaviour
{
    SpriteRenderer render;
    ansslime instance;
    int myx;
    int myy;
    float time;
    bool oneflag;
    // Start is called before the first frame update
    void Start()
    {
        oneflag = true;
        string cur = gameObject.name;
        myx = int.Parse(cur[0].ToString());
        myy = int.Parse(cur[2].ToString());
        instance = GameObject.Find("slime").GetComponent<ansslime>();

        render = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if(instance.blockflag[myx, myy] == true)
        {            

            if (time < 0.5f)
            {
                render.color = new Color(255, 0, 255, 1-time);
            }
            else            
            {
                render.color = new Color(255, 0, 255, time);
                if (time > 1f)
                {
                    time = 0;
                }
            }

            time += Time.deltaTime;
        }

    }

    public void OnMouseDown()
    {
        string cur = gameObject.name;

        int myx = int.Parse(cur[0].ToString());
        int myy = int.Parse(cur[2].ToString());


        int curx = instance.curx;
        int cury = instance.cury;
        Vector3 curpos = gameObject.transform.position;

        if ( instance.blockflag[myx, myy] == true && oneflag && !instance.flag)
        {            
            oneflag = false;            
            render.color = new Color(255, 255, 255, 1);
            instance.blockflag[myx, myy] = false;

            if (curx - 1 == myx && cury == myy) //위로 이동
            {
                instance.ButtonClick("U", curpos);
            }
            else if (curx + 1 == myx && cury == myy) //아래로
            {
                instance.ButtonClick("D", curpos);
            }
            else if (curx == myx && cury - 1 == myy) //왼쪽
            {
                instance.ButtonClick("L", curpos);
            }
            else if (curx == myx && cury + 1 == myy) //오른쪽
            {
                instance.ButtonClick("R", curpos);
            }
        }
        
    }
}
