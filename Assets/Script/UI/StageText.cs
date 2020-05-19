using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageText : MonoBehaviour
{
    string cur;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        cur = SceneManager.GetActiveScene().name;
        text = gameObject.GetComponent<Text>();
        text.text = cur;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
