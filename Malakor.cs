using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Malakor : MonoBehaviour
{
    private float horizontal;
    private bool isFacingRight = true;
    int health = 10;
    public Transform player;

    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 direction = (player.position - transform.position).normalized;

        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
        if (player.transform.position.x < 0)
        {


            Flip();
        }
        if (player.transform.position.x > 0)
        {


            Flip();
        }
    }
    private void Flip()
    {
        if (isFacingRight && player.transform.position.x < transform.position.x || !isFacingRight && player.transform.position.x > transform.position.x)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
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


    }
}
