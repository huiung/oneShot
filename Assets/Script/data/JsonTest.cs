using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;

[Serializable]
public class Data
{
    public List<string> num = new List<string>();    
}


public class JsonTest : MonoBehaviour
{
    public string stage;
    ansslime instance;
    // Start is called before the first frame update
    void Awake()
    {
        instance = GameObject.Find("slime").GetComponent<ansslime>();

        if (Application.platform == RuntimePlatform.Android)
        {
            string oriPath = Path.Combine(Application.streamingAssetsPath, stage + ".json");

            WWW reader = new WWW(oriPath);
            while(!reader.isDone)
            {
            }

            string str = reader.text;
            Data data2 = JsonUtility.FromJson<Data>(str);
            
            for (int i = 0; i < data2.num.Count; i++)
            {                
                int first = int.Parse(data2.num[i][0].ToString());
                int second = int.Parse(data2.num[i][1].ToString());

                instance.myList.Add(new KeyValuePair<int, int>(first, second));
            }
        }
        else
        {
            string str = File.ReadAllText(Application.dataPath + "/StreamingAssets/" + stage + ".json");
            Data data2 = JsonUtility.FromJson<Data>(str);            
            for (int i = 0; i < data2.num.Count; i++)
            {                
                int first = int.Parse(data2.num[i][0].ToString());
                int second = int.Parse(data2.num[i][1].ToString());

                instance.myList.Add(new KeyValuePair<int, int>(first, second));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
