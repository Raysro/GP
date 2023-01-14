using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bgscript : MonoBehaviour
{
    public GameObject[] Obs;
    public float timespawn=5f;
    public float timespawn1 = 5f;
    public float timespawn2 = 5f;
    
    public float speed;
   
    void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(spawnOB1());
        StartCoroutine(spawnOB2());
        StartCoroutine(spawnOB3());
       
    }
  
    private IEnumerator spawnOB1()
    {
        while (true)
        {
            yield return new WaitForSeconds(timespawn);
            Instantiate(Obs[0], transform.position = new Vector3(Random.Range(-9f, 9f), 8f, 0f), transform.rotation);
        }
    }
    private IEnumerator spawnOB2()
    {
        while (true)
        {
            yield return new WaitForSeconds(timespawn1);
            Instantiate(Obs[1], transform.position = new Vector3(Random.Range(-9f, 9f), 8f, 0f), transform.rotation);
        }
    }
    private IEnumerator spawnOB3()
    {
        while (true)
        {
            yield return new WaitForSeconds(timespawn2);
            Instantiate(Obs[2], transform.position = new Vector3(Random.Range(-9f, 9f), 8f, 0f), transform.rotation);
        }
    }
   
}
