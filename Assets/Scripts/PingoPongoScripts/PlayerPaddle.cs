using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : MonoBehaviour
{
    Vector2 direction;
    Rigidbody2D rb;
    float speed = 17f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            direction = Vector2.down;
        }
        else
            direction = Vector2.zero;
    }
    private void FixedUpdate()
    {
        if(direction != Vector2.zero)
        {
            rb.AddForce(direction * speed);
        }
    }
}
