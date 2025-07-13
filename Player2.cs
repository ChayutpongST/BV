using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player2 : MonoBehaviour
{
    TextMeshProUGUI textMeshPro;
    private float horizontal;
    private float speed = 8f;
    private float jump = 20f;
    public GameObject HP;
    public int health = 3;
    //public bool shoot = false;
    private bool isFacingRight = true;
    //public Spawnpoint spawnbullet;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal2");
        if (Input.GetButtonDown("Jump2") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
        }
        if (Input.GetButtonDown("Jump2") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
        /* if (Input.GetKeyDown("q"))
             {
             shoot = true;
         }*/

        Flip();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

    }
    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet2") || collision.CompareTag("Enemy"))
        {
            health--;
        }
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
}
