using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MalakorBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 30f;
    public float speedSpawn = .2f;



    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnObj", 3f);

    }

    // Update is called once per frame
    void Update()
    {
        GameObject bullet = Instantiate(bulletPrefab, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (enemy.transform.localScale.x < 0)
        {
            rb.velocity = new Vector2(-1 * bulletSpeed, 0);
            
        }
        if (enemy.transform.localScale.x > 0)
        {
            rb.velocity = new Vector2(1 * bulletSpeed, 0);
           
        }
        Destroy(bullet, 2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")|| collision.CompareTag("Player2"))
        {
            Destroy(bulletPrefab);
        }
    }
}
