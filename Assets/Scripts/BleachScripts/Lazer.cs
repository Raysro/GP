using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
   
    [SerializeField]
    private float _speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move2 m = GameObject.Find("Ichigo").GetComponent<Move2>();
        if (m.IsAlive==false)
        {
            Destroy(this.gameObject);
        }
        transform.Translate(Vector3.down * Time.deltaTime * _speed);
        if (transform.position.y < -10.0f)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            Move2 m = GameObject.Find("Ichigo").GetComponent<Move2>();
            m.damage();
        }

    }
 
}

