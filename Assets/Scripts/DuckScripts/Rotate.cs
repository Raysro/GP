using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int ID = 0;
    public float rotationSP1 = 5f;
    public float rotationSP2= 5f;
    public float rotationSP3 = 5f;
    void Update()
    {
        if (ID == 1)
            transform.Rotate(0f, 0f, rotationSP1 * Time.deltaTime);
        if (ID == 2)
            transform.Rotate(0f, 0f, rotationSP2 * Time.deltaTime);
        if (ID == 3)
            transform.Rotate(0f, 0f, rotationSP3 * Time.deltaTime);
    }
}
