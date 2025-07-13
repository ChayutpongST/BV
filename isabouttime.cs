using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class isabouttime : MonoBehaviour
{
    public float duration = 5f;
    private float timer = 0;
    public GameObject Ending;

    // Start is called before the first frame update
    void Start()
    {
        timer = duration;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Ending.activeSelf)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;

            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
       
    }
}
