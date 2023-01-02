using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDiamond : MonoBehaviour
{
    
   

    
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * 5f);
        if (transform.position.y < -6)
        {
            
            Destroy(gameObject);
        }
    }
}
