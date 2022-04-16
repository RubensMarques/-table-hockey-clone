using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class moviment : MonoBehaviour
{
    
    public float horizontal, vertical;
    
   
    public Rigidbody2D rb;
    PlayerInputActions input;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Awake()
    {
        input = new PlayerInputActions();

       

    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        


    }

    public void OnMoveX(InputAction.CallbackContext context)
    {
        
        horizontal = context.ReadValue<float>();
        rb.velocity = new Vector2(horizontal * 13, rb.velocity.y);
    }

    public void OnMoveY(InputAction.CallbackContext context)
    {
        vertical = context.ReadValue<float>();
        rb.velocity = new Vector2(rb.velocity.x, vertical*13);
    }

}