using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabitMove : MonoBehaviour
{private Animator animator;
    public float speed = 10f; 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(rabit());
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private IEnumerator rabit()
    {
yield return new WaitForSeconds(4f);
        animator.SetBool("move", true);
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
}
