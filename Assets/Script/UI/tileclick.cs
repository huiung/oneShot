using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileclick : MonoBehaviour
{    
    moveslime instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = GameObject.Find("slime").GetComponent<moveslime>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnMouseDown()
    {
        string cur = gameObject.name;

        int myx = int.Parse(cur[0].ToString());
        int myy = int.Parse(cur[2].ToString());
        
        int curx = instance.curx;
        int cury = instance.cury;

        Vector3 curpos = gameObject.transform.position;
   

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
