using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moviment2 : MonoBehaviour
{
    int xAxys=0, yAxys = 0;

    public Vector2 dir;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("HorizontalJoystick2") > 0)
        {
            xAxys = 1;
        }
        
        if (Input.GetAxisRaw("VerticalJoystick2") > 0)
        {
            yAxys = 1;
        }
        
        if (Input.GetAxisRaw("HorizontalJoystick2") < 0)
        {
            xAxys = -1;
        }
        if (Input.GetAxisRaw("VerticalJoystick2") < 0)
        {
            yAxys = -1;
        }

        if (Input.GetAxisRaw("HorizontalJoystick2") == 0)
        {
            xAxys = 0;

        }if (Input.GetAxisRaw("VerticalJoystick2") == 0)
        {
            yAxys = 0;
        }

        rb.velocity = new Vector2(xAxys * 15, yAxys *15);
        

    }
}
