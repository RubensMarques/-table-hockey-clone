using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    
    public GameObject goal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("goal1"))
        {
           
            goal.SetActive(true);
            Invoke("ShowGoal", 1f);


        }

        if (collision.gameObject.CompareTag("goal2"))
        {
            goal.SetActive(true);
            Invoke("ShowGoal", 1f);
          
        }

        
    }

    public void ShowGoal()
    {
        SceneManager.LoadScene("partida");
    }
}
