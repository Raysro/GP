using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    float health = 100;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        health-=10f;
        FindObjectOfType<HealthUI>().BaseDamage(health);
    }
}
