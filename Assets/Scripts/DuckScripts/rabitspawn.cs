using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rabitspawn : MonoBehaviour
{
    public GameObject[] rabitPrefab; 
    public float spawnInterval = 3f; 
    public float minX = 7.7f; 
    public float maxX = 7.7f; 
    public float minY = -3.46f; 
    public float maxY = -3.46f;
   
    private bool canSpawn = true; 

    // Start is called before the first frame update
    private void Start()
    {
       
        StartCoroutine(Spawnrabit());
    }
    IEnumerator Spawnrabit()
    {
        while (canSpawn)
        {
            int counter = 0; 
            int maxRABITS = 3; 

            while (counter < maxRABITS)
            {
                // wait for the spawn interval
                yield return new WaitForSeconds(spawnInterval);

                // randomly select a position within the specified range for spawning
                float x = Random.Range(minX, maxX);
                float y = Random.Range(minY, maxY);
                Vector2 spawnPos = new Vector2(x, y);

                // instantiate the duck at the spawn position
                GameObject rabit = Instantiate(rabitPrefab[Random.Range(0,2)], spawnPos, Quaternion.identity);
                counter++;
             
            }
        }

    }
}
