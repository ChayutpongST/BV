using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fromhand : MonoBehaviour
{
    public GameObject[] prefab;
    public float duration=10f;
    public float timer =0;
    public Transform spawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        //timer = 0;
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
          
            Instantiate(prefab[0], spawnpoint.position, Quaternion.identity);
            timer = duration;
        }
    }
}
