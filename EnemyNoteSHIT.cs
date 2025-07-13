using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyNoteSHIT : MonoBehaviour
{
    int health = 1;
    public float speed = 3f;
    public Transform Player;
    public ShootBullet scriptShootBullet;
   
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x-speed * Time.deltaTime, transform.position.y);
        if(transform.position.x < -31)
            {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet") || collision.CompareTag("Bullet2"))
        {
            health--;
        }
        if (health == 0)
        {
            Destroy(gameObject);

        }
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

    }


}
