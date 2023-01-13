using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerOB : MonoBehaviour
{
    public GameObject[] Obs;
    void Start()
    {
        StartCoroutine(spawnOB1());
        StartCoroutine(spawnOB2());
        StartCoroutine(spawnOB4());
    }
    private IEnumerator spawnOB1()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            Instantiate(Obs[0],transform.position=new Vector3(Random.Range(-7f,7f),15f,0f),transform.rotation);
        }
    }
    private IEnumerator spawnOB2()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            Instantiate(Obs[1], transform.position = new Vector3(Random.Range(-7f, 7f), 15f, 0f), transform.rotation);
        }
    }
    private IEnumerator spawnOB3()
    {
        while (true)
        {
            yield return new WaitForSeconds(4f);
            Instantiate(Obs[2], transform.position = new Vector3(Random.Range(-7f, 7f), 15f, 0f), transform.rotation);
        }
    }
    private IEnumerator spawnOB4()
    {
        while (true)
        {
            Instantiate(Obs[3], transform.position=new Vector3(8.732107f,15f,0f), transform.rotation);
            yield return new WaitForSeconds(2f);
            
        }
    }
}
