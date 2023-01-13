using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : MonoBehaviour
{
    public Rigidbody2D ballRb;
    Rigidbody2D rb;
    float speed = 5f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate()
    {
        if(ballRb.velocity.x > 0.0f)
        {
            if(ballRb.position.y > this.transform.position.y)
            {
                rb.AddForce(Vector2.up * speed);
            }
            else if (ballRb.position.y < this.transform.position.y)
            {
                rb.AddForce(Vector2.down * speed);
            }
        }
        else
        {
            if (this.transform.position.y > 0.0f)
            {
                rb.AddForce(Vector2.down * speed);
            }
            else if(this.transform.position.y < 0.0f)
            {
                rb.AddForce(Vector2.up * speed);
            }
        }
    }
}
