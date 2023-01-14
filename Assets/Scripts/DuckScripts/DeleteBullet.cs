using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeleteBullet : MonoBehaviour
{
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        if (y >= 7.0f || x <= -12.17 || y <= -9 || x >= 12)
        {
            Destroy(this.gameObject);


        }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Bor")
            Destroy(this.gameObject);
    }
}
