using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FLY : MonoBehaviour
{
   
    public float speed = -3f;
   
  
    private Rigidbody2D rb;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //  transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        rb.velocity = new Vector2(speed, 0);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "JustForU")
        {
            Destroy(this.gameObject);
        }
       
    }

    


}
