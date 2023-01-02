using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePre;
    private void Start()
    {
        StartCoroutine(SpawnObstacle());
    }

    
    private IEnumerator SpawnObstacle()
    {
        while (true)
        {
            Instantiate(obstaclePre[Random.Range(0, 3)], new Vector2(Random.Range(8.46f, -8.46f), 6), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(1f, 2f));
        }
        
    }
}
