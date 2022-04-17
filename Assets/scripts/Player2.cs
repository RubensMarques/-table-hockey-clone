using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
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
        if (Input.GetAxisRaw("HorizontalJoystick2")>0)
        {
            xAxis = 1;
        }
        else
        {
            xAxis = -1;
        }

        if(Input.GetAxisRaw("VerticalJoystick2") > 0)
        {
            yAxis = 1;
        }
        else
        {
            yAxis = -1;
        }

        if (Input.GetAxisRaw("HorizontalJoystick2") == 0)
        {
            xAxis = 0;
        }
        
        if (Input.GetAxisRaw("VerticalJoystick2") == 0)
        {
            yAxis = 0;
        }

        rb.velocity = new Vector2(xAxis * 13 * Time.deltaTime, yAxis * 13 * Time.deltaTime);
        
        

    }

}
