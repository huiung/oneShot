using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageClick : MonoBehaviour
{
    bool flag;
    int mystage;
    // Start is called before the first frame update
    void Start()
    {
        flag = true;
        mystage = int.Parse(gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void click(string scene)
    {
        if (flag && mystage <= PlayerPrefs.GetInt("stage"))
        {
            flag = false;
            StartCoroutine(startco(scene));
        }
    }

    IEnumerator startco(string scene)
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(scene);
    }
}
