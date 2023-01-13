using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5f;
 void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        transform.Translate(hor * Time.deltaTime * Speed, 0,0);

    }
}
