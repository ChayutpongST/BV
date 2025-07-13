using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public Animator anim;
    int health = 1;
    public float speed = 0.5f;
    private bool isFacingRight = true;
    private Transform Player;
    public ShootBullet scriptShootBullet;
   
    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
}

    // Update is called once per frame
    void Update()
    {
        if (!Panel.instance.isPause)
        {
            anim.Play("Oranges");
            /*  Vector3 displacement = Player.position - transform.position;
              displacement = displacement.normalized;
              if (Vector2.Distance(Player.position, transform.position) > 1.0f)
              {
                  transform.position += (displacement * speed * Time.deltaTime);

              }*/
            if (Player.transform.position.x < 0)
            {


                Flip();
            }
            if (Player.transform.position.x > 0)
            {


                Flip();
            }
            transform.position = Vector3.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
        }
    }
    private void Flip()
    {
        if (isFacingRight && Player.transform.position.x > transform.position.x || !isFacingRight && Player.transform.position.x < transform.position.x)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet")|| collision.CompareTag("Bullet2"))
        {
            health--;
            
        }
        if (health == 0)
        {
            Panel.instance.DeathCount++;
            Destroy(gameObject);
            collision.gameObject.SetActive(false);
//anim.Play("Dead");
           

        }
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            collision.gameObject.SetActive(false);

        }

    }
   

}
