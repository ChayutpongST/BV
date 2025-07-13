using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power_1 : MonoBehaviour
{
    Animator power;
    Transform Player;
    public float speed = 2f;
    public float duration = 100f;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        timer = duration;
        power = GetComponent<Animator>();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Panel.instance.isPause)
        {
            if(timer > 0)
            {
                timer-=Time.deltaTime;
            }
            else
            {
                Destroy(this.gameObject);
            }
            transform.position = Vector3.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
    
