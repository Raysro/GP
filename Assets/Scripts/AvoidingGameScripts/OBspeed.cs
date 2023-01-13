using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OBspeed : MonoBehaviour
{
    
    public float speed = 5f;
  
    public float speeddouble = 1f;
   
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, -speeddouble * speed * Time.deltaTime, 0f);
        
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bor")
        {
            Destroy(gameObject);
            Debug.Log("destroy");
        }
    }
}
