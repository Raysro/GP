using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SnakeMove : MonoBehaviour
{
    List<Transform> SnakesT = new List<Transform>();
    public Transform TailPrefabe;
    public float Speed = 1f;
    int checky = 0;
    int checkx = 0;
    int Lives = 3; 
    public GameObject gameover;

    void Start()
    {
        Time.timeScale = 1;
        SnakesT.Add(this.transform);
        transform.position = Vector3.zero;
    }


    void FixedUpdate()
    {
        for (int i = SnakesT.Count - 1; i > 0; i--)
        {
            SnakesT[i].position = SnakesT[i - 1].position;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            checky = 1;
            checkx = 0;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            checky = 2;
            checkx = 0;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            checkx = 1;
            checky = 0;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            checkx = 2;
            checky = 0;
        }


        if (checky == 1)
        {
            transform.Translate(0, Speed * Time.deltaTime, 0);
        }
        if (checky == 2)
        {
            transform.Translate(0, -Speed * Time.deltaTime, 0);
        }
        if (checkx == 1)
        {
            transform.Translate(-Speed * Time.deltaTime, 0, 0);
        }
        if (checkx == 2)
        {
            transform.Translate(Speed * Time.deltaTime, 0, 0);
        }
        #region border
        float x = transform.position.x;
        float y = transform.position.y;
        if (transform.position.y >= 16f)
        {
            transform.position = new Vector3(x, -16f, 0);
        }
        else if (transform.position.y <= -16f)
        {
            transform.position = new Vector3(x, 16f, 0);
        }
        x = transform.position.x;
        y = transform.position.y;
        if (transform.position.x >= 20f)
        {
            transform.position = new Vector3(-20f, y, 0);
        }
        else if (transform.position.x <= -20f)
        {
            transform.position = new Vector3(20f, y, 0);
        }
        #endregion
    }
   


    void Grow()
    {
        Transform seg = Instantiate(TailPrefabe);
        seg.position = SnakesT[SnakesT.Count - 1].position;
        SnakesT.Add(seg);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Food")
        {
            Grow();
            Grow();
            Grow();
            Grow();
            Grow();
            FindObjectOfType <UISnakeGame>().UpdateScore();
        }
        
        if (collision.tag == "Posion")
        {
            
            Lives--;
            FindObjectOfType<UISnakeGame>().livesSp(Lives);
            if (Lives == 0)
                GameOver();
        }
         
    }
    public void GameOver()
    {
        gameover.SetActive(true);
        Time.timeScale = 0;
    }

}
