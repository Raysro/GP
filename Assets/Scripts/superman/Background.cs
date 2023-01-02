using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime *10f);
        if (transform.position.y < -12)
        {
            transform.position = new Vector2(transform.position.x, 22f);
        }
    }
}
