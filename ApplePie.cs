using UnityEngine;

public class ApplePie : MonoBehaviour
{
    public Animator anim;
    private float horizontal;
    private bool isFacingRight = true;
    int health = 5;
    public Transform player;

    public float speed = 2f;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        //player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        if (!Panel.instance.isPause)
        {
            anim.Play("AppleWalk");
            transform.position =new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
            

    }

       /* Vector2 direction = (player.position - transform.position).normalized;
        
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
        if (transform.position.y > -11 || transform.position.y < -9)
        {
            transform.position = new Vector3(transform.position.x, -10, transform.position.z);
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
    }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet") || collision.CompareTag("Bullet2"))
        {
            health--;
            
        }
        if (health == 0)
        {
            Panel.instance.DeathCount++;
            Destroy(gameObject);
           // anim.Play("Dead");
            
        }
        if(collision.CompareTag("JustForU"))
        {
            Destroy(gameObject);
        }
        

    }
}
