using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    
    public GameObject goal;
    Animator anim;
    public Rigidbody2D rb;
    Collider2D col;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("goal1"))
        {
            GameController.instance.goal.SetActive(true);
            col.enabled = false;
            rb.velocity = new Vector2(0,0);
            anim.SetTrigger("goal");
            Invoke("ShowGoal", 0.3f);
            GameController.instance.scoreboard2++;
            



        }

        if (collision.gameObject.CompareTag("goal2"))
        {
            GameController.instance.goal.SetActive(true);
            col.enabled = false;
            rb.velocity = new Vector2(0, 0);
            anim.SetTrigger("goal");
            Invoke("ShowGoal", 0.3f);
            GameController.instance.scoreboard1++;

        }

        
    }

    public void ShowGoal()
    {
        GameController.instance.goal.SetActive(false);
        SceneManager.LoadScene("partida");
    }

    
}
