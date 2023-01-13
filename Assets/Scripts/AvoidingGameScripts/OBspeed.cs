using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBspeed : MonoBehaviour
{
    public int ID=0;
    public float speed1 = 5f;
    public float speed2 = 5f;
    public float speed3 = 5f;
    public float speeddouble = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ID == 1)
            transform.Translate(0f, -speeddouble*speed1 * Time.deltaTime, 0f);
        if (ID == 2)
            transform.Translate(0f, -speeddouble*speed2 * Time.deltaTime, 0f);
        if (ID == 3)
            transform.Translate(0f, -speeddouble*speed3 * Time.deltaTime, 0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Bor")
            Destroy(this.gameObject);
    }
}
