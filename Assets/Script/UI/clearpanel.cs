using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clearpanel : MonoBehaviour
{

    private GameObject panel;
    AdmobVideoScript ad;
    private string cur;
    // Start is called before the first frame update
    void Awake()
    {
        cur = SceneManager.GetActiveScene().name;

        if (cur.Length <= 7) cur += "ans";

        ad =  GameObject.Find("AD").GetComponent<AdmobVideoScript>();
        panel = GameObject.Find("Canvas").transform.Find("clearPanel").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(ad.isend == true)
        {
            StartCoroutine(ans(cur)); //테스트     
        }

    }

    public void RetryBtn(string stage)
    {
        string curstage = "";
        for(int i = 5; i < cur.Length; i++)
        {
            if (cur[i] == 'a') break;
            curstage += cur[i];
        }

        StartCoroutine(retry(curstage));
    }

    public void ansBtn(string stage)
    {        
        ad.Show();        
    }

    public void QuitBtn() //스테이지 씬으로
    {        
        StartCoroutine(retry());
    }

    IEnumerator retry(string stage = "")
    {
        yield return new WaitForSeconds(0.2f);        
        SceneManager.LoadScene("stage" + stage);
    }

    IEnumerator ans(string stage = "")
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(stage);
    }
}
