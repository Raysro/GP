using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rabitdelete : MonoBehaviour
{
    

    private void Update()
    {
        float x = transform.position.x;
    
        if (x <= -12.17)
        {
            Destroy(this.gameObject);


        }
    }
       

}
