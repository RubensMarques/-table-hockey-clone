using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public static Player1 pl1;
    public float xAxis=0, yAxis=0;
    public Rigidbody2D rb;
    
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (GameController.instance.SFW.active == true)
        {
            Stop();
        }
        else
        {
            Move();
        }

        if ((GameController.instance.scoreboard1 == GameController.instance.scoreForWin || GameController.instance.scoreboard2 == GameController.instance.scoreForWin) && GameController.instance.scoreForWin != 0)
        {
            rb.velocity = new Vector2(0, 0);
        }
    }

    public void Move()
    {
        if (Input.GetAxisRaw("HorizontalJoystick1") > 0)
        {
            xAxis = 1;
        }
        else
        {
            xAxis = -1;
        }

        if (Input.GetAxisRaw("VerticalJoystick1") > 0)
        {
            yAxis = 1;
        }
        else
        {
            yAxis = -1;
        }

        if (Input.GetAxisRaw("HorizontalJoystick1") == 0)
        {
            xAxis = 0;
        }

        if (Input.GetAxisRaw("VerticalJoystick1") == 0)
        {
            yAxis = 0;
        }

        rb.velocity = new Vector2(xAxis * Time.deltaTime * 500, yAxis * Time.deltaTime * 500);
    }

    public void Stop()
    {
        rb.velocity = new Vector2(0, 0);
    }


}
