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
    public GameObject gameover;
    public GameObject[] LivesSP;
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
    public void GameOver()
    {
        gameover.SetActive(true);
        Time.timeScale = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "OBS")
        {
            Lives--;
            lives();
        }
        if(Lives == 0)
        {
          Destroy(this.gameObject);
            GameOver();
        }
    }
    public void lives()
    {
        if (Lives == 2)
            LivesSP[0].SetActive(false);
        if (Lives == 1)
            LivesSP[1].SetActive(false);
        if (Lives == 0)
            LivesSP[2].SetActive(false);
    }
}
