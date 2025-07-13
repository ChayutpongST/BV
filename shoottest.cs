using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoottest : MonoBehaviour
{
    public GameObject bulletPrefab;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(bulletPrefab);
        }
    }
}
