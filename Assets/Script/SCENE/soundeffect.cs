using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundeffect : MonoBehaviour
{
    public static soundeffect instance;

    public AudioSource myAudio;
    // Start is called before the first frame update

    public AudioClip btnclick;
    public AudioClip []move = new AudioClip[8];
    public AudioClip clear;

    public static int idx;
    private void Awake()
    {
        idx = 0;

        if (instance == null)
            instance = this;

        var obj = FindObjectsOfType<soundmanager>();
        if (obj.Length == 1)
        {
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    void Start()
    {
        myAudio = GetComponent<AudioSource>();              
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void stopeffect()
    {
        if (myAudio.volume != 0)
        {
            myAudio.volume = 0;
        }
        else myAudio.volume = 1;
    }

    public void btnsound()
    {
        myAudio.PlayOneShot(btnclick);
    }

    public void clearsound()
    {
        myAudio.PlayOneShot(clear);
    }

    public void movesound()
    {
        myAudio.PlayOneShot(move[idx]);
        idx++;
        idx = idx % 8;
    }
}
