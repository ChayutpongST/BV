using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Panel : MonoBehaviour
{
    public GameObject panel;
    public GameObject CompLvpanel;
    Animator animator;
    public TMPro.TextMeshPro scoreText;
    public int DeathCount = 0;
    public bool isPause;
    public static Panel instance;
    int Alldeath = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        instance = this;
        CompLvpanel.SetActive(false);
        panel.SetActive(false);
        
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            
        }
        
       if(DeathCount == 20)
        {
            isPause = true;
            CompLvpanel.SetActive(true);
            
            animator.Play("ComLv");
            
        }
    }
}
