using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementParicles : MonoBehaviour
{
    public float speed = 5f;

 

    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f,-speed * Time.deltaTime, 0f);
        

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "PAR")
        {
            Destroy(gameObject);

        }
    }
}
