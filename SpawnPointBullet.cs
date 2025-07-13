/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointBullet : MonoBehaviour
{
    public GameObject[] BulletPlayer1;

    public PlayerMove scriptPlayerMove;

        public int bullet = 0;
    // Start is called before the first frame update
    void Start()
    {
        scriptPlayerMove = FindObjectOfType<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObj()
    {
        if(scriptPlayerMove.shoot)
        {
            int spawn = Random.Range(0, BulletPlayer1.Length);
            Instantiate(BulletPlayer1[spawn], new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
            bullet++;
        }
    }
}
*/