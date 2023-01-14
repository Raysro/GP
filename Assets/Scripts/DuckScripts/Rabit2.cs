using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabit2 : MonoBehaviour
{
    private Animator animator;
    public float speed = 1f;



    
    void Update()
    {

        if (transform.position.x < 7.6f)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Tail")
            Destroy(this.gameObject);
    }

}
