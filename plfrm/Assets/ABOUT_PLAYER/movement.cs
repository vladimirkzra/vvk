using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public int speed = 10;
    public int jmp = 5;
    Rigidbody2D rb;
    public bool isgrounded = true;

    void Start()
    {
rb = GetComponent<Rigidbody2D>();          
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&isgrounded)
        {
            rb.AddForce(new Vector2(0, jmp), ForceMode2D.Impulse);
        }
        
    }
    private void FixedUpdate()
    {
        float horizontalinput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalinput * speed,rb.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isgrounded=true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isgrounded = false;
        }
    }
}
