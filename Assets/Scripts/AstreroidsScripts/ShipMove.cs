using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour
{
    //hala wallah
    public GameObject gameover;
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] float rotationSpeed = 1f;
    [SerializeField] GameObject bulletPre;
    [SerializeField] int lives=3;
    bool isMoving;
    float direction;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }
    void Update()
    {
        isMoving = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            direction = 1.0f;
        }
        else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            direction = -1.0f;
        }
        else
        {
            direction = 0.0f;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void FixedUpdate()
    {
        if (isMoving)
        {
            rb.AddForce(this.transform.up * moveSpeed);
        }
        if(direction != 0)
        {
            rb.AddTorque(direction * rotationSpeed );
        }
       
    }
    void Shoot()
    {
        Instantiate(bulletPre, this.transform.position, this.transform.rotation);
        
    }
    
    public void Damage()
    {
        lives--;
        FindObjectOfType<UIAsteroids>().UpdateLives(lives);
        if (lives == 0)
        {
            Destroy(gameObject);
            GameOver();
        }

    }
    public void GameOver()
    {
        gameover.SetActive(true);
        Time.timeScale = 0;
    }
}
