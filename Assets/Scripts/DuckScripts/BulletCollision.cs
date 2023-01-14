using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BulletCollision : MonoBehaviour
{
    public int scoreValue = 1;
 



    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("rabbit"))
        {
            counter c = GameObject.Find("Canvas").gameObject.GetComponent<counter>();
            c.rabit(2);
         
            Destroy(other.gameObject);
         
           
        }
    }
  
}