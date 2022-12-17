using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] Sprite[] sprites;
    SpriteRenderer spriteRenderer;
    Rigidbody2D rb;
    public float size = 1f;
    public float minSize = 0.5f;
    public float maxSize = 1.5f;
    public float speed = 50f;
    public float maxLifetime = 20f;



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        
        spriteRenderer.sprite = sprites[Random.Range(0, sprites.Length)];

        transform.eulerAngles = new Vector3(0f, 0f, Random.value * 360f);
        transform.localScale = Vector3.one * size;

        rb.mass = size;
        
    }

    public void SetDirection(Vector2 direction)
    {
        rb.AddForce(direction * speed);
        Destroy(gameObject, maxLifetime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }


}
