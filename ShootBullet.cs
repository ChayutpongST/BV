using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 30f;
    public GameObject player;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            // Instantiating a new bullet prefab
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            // Getting the bullet's Rigidbody2D component
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            if(player.transform.localScale.x < 0)
            {
                rb.velocity = new Vector2(-1*bulletSpeed, 0);
            }
            // Determine the direction to shoot the bullet in
            //Vector2 shootDirection = Vector2.right;
            if (player.transform.localScale.x > 0)
            {
                rb.velocity = new Vector2(1*bulletSpeed, 0);
            }
            

            // Adding force to the bullet in the shoot direction
            //rb.AddForce(shootDirection * bulletSpeed, ForceMode2D.Impulse);

         Destroy(bullet, 2f);
            //bullet.layer = LayerMask.NameToLayer("Bullet");
        }
    }
   
}
