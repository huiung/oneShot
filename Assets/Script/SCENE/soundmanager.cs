using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanager : MonoBehaviour
{
    public static soundmanager instance;

    public AudioSource myAudio;        

    private void Awake()
    {
        if (instance == null)
            instance = this;

        var obj = FindObjectsOfType<soundmanager>();
        if(obj.Length == 1)
        {
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        myAudio.Play();        
    }

    // Update is called once per frame
    void Update()
    {
       
    }   

    public void bgmstop()
    {
        if (myAudio.isPlaying == true)
        {
            myAudio.Stop();
        }
        else
        {
            myAudio.Play();
        }
    }

}
