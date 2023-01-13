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

        ResetPosition(-1);
        
    }
    public void IncreaseSpeed(Vector2 v)
    {
        rb.AddForce(v);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "AIGoal")
        {
            ResetPosition(1);
            FindObjectOfType<UIManager>().PlayerScored();
        }
        if (collision.gameObject.tag == "PlayerGoal")
        {
            ResetPosition(-1);
            FindObjectOfType<UIManager>().AIScored();
        }
    }
    void ResetPosition(int x)
    {
        rb.velocity = Vector2.zero;
        rb.position = Vector2.zero;
        rb.AddForce(new Vector2(x, Random.Range(1f,-1f)) * speed);
    }


}
