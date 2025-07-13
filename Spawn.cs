using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] prefab;
    public float duration;
    public float timer;
    public float X;
    public float Xleft;
    public float Y;
    // Start is called before the first frame update
    void Start()
    {
        timer = duration;
            
     
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
           int  random = Random.Range(0, prefab.Length);
            if(Random.value <= 0.9f)
                Instantiate(prefab[random], new Vector2(Random.Range(Xleft,X),Y), Quaternion.identity);
            timer = duration;
        }
    }
}
