using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    public float speed = 5f;
    public float jumpSpeed = 8f;
    private float direction = 0f;
    private Rigidbody2D player;
    Animator animator;
    public int _lives = 3;
    public TextMeshProUGUI score;
    [SerializeField]
    int counterscore;
    public TextMeshProUGUI GameOver;
    public TextMeshProUGUI restart;
    public bool shield = false;
    public bool IsAlive = true;
    public TextMeshProUGUI YouWon;
    public GameObject Shield1;
    public bool IsJump = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 
        direction = Input.GetAxis("Horizontal");

        if (direction > 0f)
        {
            animator.SetBool("IsJump", false);
            animator.SetBool("ISMOVE", true);
            player.gameObject.transform.localScale = new Vector3(1,1,1);
            player.velocity = new Vector2(direction * speed, player.velocity.y);

        }
        else if (direction < 0f)
        {
            animator.SetBool("IsJump", false);
            animator.SetBool("ISMOVE", true);
            player.gameObject.transform.localScale = new Vector3(-1, 1, 1);
            player.velocity = new Vector2(direction * speed, player.velocity.y);
        }
        else
        {
            animator.SetBool("IsJump", false);
            animator.SetBool("ISMOVE", false);
            player.velocity = new Vector2(0, player.velocity.y);
        }

        if (Input.GetButtonDown("Jump")&&!IsJump)
        {
            animator.SetBool("IsJump", true);
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
            IsJump = true;
        }

        float y = transform.position.y;
        if (y < -6)
        {
            _lives = 0;
          
            IsAlive = false;
            restart.gameObject.SetActive(true);
            GameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
            GameManager game = GameObject.Find("GameManager").GetComponent<GameManager>();
            game.GameOver();
        }
    }
    public void damage()
    {
        if (!shield)
        {
            _lives--;

        }

        UImanager UImanage = GameObject.Find("Image111").GetComponent<UImanager>();
        UImanage.UpdateLives(_lives);
        if (_lives == 0)
        {
            IsAlive = false;
            restart.gameObject.SetActive(true);
            GameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
            //Destroy(this.gameObject);


            GameManager game = GameObject.Find("GameManager").GetComponent<GameManager>();
            game.GameOver();
        }
    }

    public void score1(int sc)
    {
        counterscore = sc + counterscore;
        score.text = counterscore.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Finish"))
        {
            Time.timeScale = 0;
            YouWon.gameObject.SetActive(true);
        }
    }
    public void shieldactive()
    {
        StartCoroutine(Shield());
        Shield1.gameObject.SetActive(true);
    }
    IEnumerator Shield()
    {
       


        shield = true;

        yield return new WaitForSeconds(2f);

        Shield1.gameObject.SetActive(false);


        shield = false;


    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            IsJump = false;
        }
    }
}