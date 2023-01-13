using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    float speed = 10f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Vector2 v = collision.GetContact(0).normal;
            FindObjectOfType<Ball>().IncreaseSpeed(-v * speed);
            
        }
    }
}
