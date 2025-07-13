using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    TextMeshProUGUI textMeshPro;
    Animator anima;
   
    private float horizontal;
    private float speed = 7f;
    public float jump = 20f;
    public bool dead = false;
    public int health = 3;
    public GameObject Ending;
    //public bool shoot = false;
    private bool isFacingRight = true;
    //public Spawnpoint spawnbullet;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    // Start is called before the first frame update
    void Start()
    {
        
        anima = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
        }
        if (Input.GetButtonDown("Jump") && rb.velocity.y > 0f)
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
        if(isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet2")|| collision.CompareTag("Enemy")|| collision.CompareTag("HITUASS"))
        {
            Debug.Log("TTT");
            health--;
            
        }
       


        if (health == 0)
        {

            Destroy(gameObject);

            Ending.SetActive(true);
            dead = true;
        }

        if (collision.CompareTag("HitUrAss"))
        {
            Ending.SetActive(true);
            Destroy(gameObject);
        }
        if (collision.CompareTag("void"))
        {
            Ending.SetActive(true);
            
        }
        if (collision.CompareTag("hair"))
        {
            Ending.SetActive(true);
            Destroy(gameObject);
        }
    }
    
}
