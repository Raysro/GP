using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMove : MonoBehaviour
{
    public Vector2 direction = Vector2.right;
    List<Transform> Segments;
    public Transform segmentPre;

    private void Start()
    {
        Segments = new List<Transform>();
        Segments.Add(this.transform);
    }
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = Vector2.down;
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = Vector2.right;
        }
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = Vector2.left;
        }
    }
    private void FixedUpdate()
    {
        for(int i = Segments.Count - 1; i > 0 ; i--)
        {
            Segments[i].position = Segments[i - 1].position;
        }

        transform.position = new Vector3(
            Mathf.Round(transform.position.x) + direction.x,
           Mathf.Round(transform.position.y) + direction.y,
            0.0f);
        if (transform.position.y >= 15.5f)
        {
            transform.position = new Vector3(transform.position.x, -15.5f, 0f);
        }
        else if (transform.position.y <= -15.5f)
        {
            transform.position = new Vector3(transform.position.x, 15.5f, 0f);
        }
        else if(transform.position.x >= 17f)
        {
            transform.position = new Vector3(-17f, transform.position.y, 0f);
        }
        else if(transform.position.x <= -17f)
        {
            transform.position = new Vector3(17f, transform.position.y, 0f);
        }
    }

    void Grow()
    {
        Transform seg = Instantiate(segmentPre);
        seg.position = Segments[Segments.Count - 1].position;
        Segments.Add(seg);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Food")
        {
            Grow(); 
        }
    }
}
