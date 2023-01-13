using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 200f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {

        rb.AddForce(Vector2.left * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
