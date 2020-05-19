using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ansslime : MonoBehaviour
{

    public Transform Player;
    public int blockx = 4; //총 행
    public int blocky = 4;  //총 열
    public int curnum = 0; //현재 지나간 block 개수 (이미 색이 차있는)
    public int curx;
    public int cury;
    public string curdir;
    public int blockidx;
    public bool[,] blockflag = new bool[8, 5]; //정답확인시 다음 블럭을 표시하기 위한 배열
    public bool flag;
    public int stage;

    //    정답 경로를 저장한 배열       
    public List<KeyValuePair<int, int>> myList = new List<KeyValuePair<int, int>>();


    private Animator animator;
    private float Speed = 0.08f;
    private float startTime;
    private bool clearflag = true;


    GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        blockidx = 0;
        // 정답 경로       
        
        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 5; j++)
                blockflag[i, j] = false;  // 초기 모두 false            

        blockflag[myList[blockidx].Key, myList[0].Value] = true;    //초기 이동값    

        curx = blockx - 1;
        cury = blocky - 1;
        animator = Player.GetComponent<Animator>();
        panel = GameObject.Find("Canvas").transform.Find("clearPanel").gameObject;
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (curnum == blockx * blocky && clearflag)
        {
            clearflag = false;
            StartCoroutine("panelac");

            if (PlayerPrefs.GetInt("stage") < stage+1)
            {
                PlayerPrefs.SetInt("stage", stage+1);
            }
        }
    }

    public void ButtonClick(string type, Vector3 pos)
    {
        if (!flag)
        {
            curdir = type;
            soundeffect.instance.movesound();
            flag = true;
            startTime = Time.time;
           
            if (type == "L")
            {
                StartCoroutine(Move("L", pos));
                animator.SetFloat("dirX", -1);
                animator.SetFloat("dirY", 0);
            }
            else if (type == "R")
            {
                StartCoroutine(Move("R", pos));
                animator.SetFloat("dirY", 0);
                animator.SetFloat("dirX", 1);
            }
            else if (type == "U")
            {
                StartCoroutine(Move("U", pos));
                animator.SetFloat("dirX", 0);
                animator.SetFloat("dirY", 1);
            }
            else if (type == "D")
            {
                StartCoroutine(Move("D", pos));
                animator.SetFloat("dirX", 0);
                animator.SetFloat("dirY", -1);
            }
            else flag = false;
        }
    }


    //코루틴을 이용해 0.01초마다 이동(부드러운)
    IEnumerator Move(string cur, Vector3 pos)
    {
        float deltaTime = 0f;
        while (deltaTime < 0.2f)
        {
            deltaTime = Time.time - startTime;
            if (cur == "L" && Player.position.x >= pos.x)
            {
                Player.position += Vector3.left * Speed;
                if (Player.position.x < pos.x) break;
            }
            else if (cur == "R" && Player.position.x <= pos.x)
            {
                Player.position += Vector3.right * Speed;
                if (Player.position.x > pos.x) break;
            }
            else if (cur == "U" && Player.position.y <= pos.y)
            {
                Player.position += Vector3.up * Speed;
                if (Player.position.y > pos.y) break;
            }
            else if (cur == "D" && Player.position.y >= pos.y)
            {
                Player.position += Vector3.down * Speed;
                if (Player.position.y < pos.y) break;
            }
            yield return new WaitForSeconds(0.01f);
        }

        flag = false;
        yield return null;
    }

    IEnumerator panelac()
    {
        yield return new WaitForSeconds(0.3f);
        panel.SetActive(true);
        soundeffect.instance.clearsound();
    }

}
