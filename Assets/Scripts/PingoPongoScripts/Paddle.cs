using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed =10;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
}
