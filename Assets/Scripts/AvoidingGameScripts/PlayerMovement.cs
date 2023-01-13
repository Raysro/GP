using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5f;
    int Lives = 3;
    Animator Animator;
    void Start()
    {
        Time.timeScale = 1;
        transform.position = new Vector3(0f, -4f, 0f);
        Animator=GetComponent<Animator>();
    }
    void Update()
    {
        float x = transform.position.x;
        float hor = Input.GetAxis("Horizontal");
        if (hor < 0)
        {
            Animator.SetBool("Left", true);
        }
        else if (hor > 0)
        {
            Animator.SetBool("Right", true);
        }
        else
        {
            Animator.SetBool("Right", false);
            Animator.SetBool("Left", false);
        }
        transform.Translate(hor * Time.deltaTime * Speed, 0,0);
        x = transform.position.x;
        x = Mathf.Clamp(x,-7f, 7f);
        transform.position = new Vector3(x,-4f,0f);
            
            
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "OBS")
        {
            Destroy(this.gameObject);
        }
    }
}
