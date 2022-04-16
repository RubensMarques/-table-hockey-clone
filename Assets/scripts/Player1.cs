using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float xAxis=0, yAxis=0;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("HorizontalJoystick1")>0)
        {
            xAxis = 1;
        }
        else
        {
            xAxis = -1;
        }

        if(Input.GetAxisRaw("VerticalJoystick1") > 0)
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

        rb.velocity = new Vector2(xAxis * 13, yAxis * 13);
        
        

    }

}
