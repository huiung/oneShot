using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    bool flag;
    // Start is called before the first frame update
    void Start()
    {
        flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click()
    {
        if (flag) {
            flag = false;
            StartCoroutine("startco");
         }
    }

    IEnumerator startco()
    {
        yield return new WaitForSeconds(0.1f);
        soundeffect.instance.btnsound();
        SceneManager.LoadScene("stage");
    }
}
