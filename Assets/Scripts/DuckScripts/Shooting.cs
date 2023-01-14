using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
  
  
    public GameObject projectilePrefab;
    Rigidbody2D rb;
    private void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Create an instance of the projectile prefab at the position of the game object
            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            // Get the position of the mouse cursor in screen coordinates
            Vector3 mousePos = Input.mousePosition;

            // Convert the screen coordinates to world coordinates
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

            // Calculate the direction from the game object to the world position
            Vector2 direction = worldPos - transform.position;

            //Get the Rigidbody2D component of the projectile
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            // Set the velocity of the projectile in the direction calculated above
           rb.velocity = direction * 10;
            
        }
    }

}
